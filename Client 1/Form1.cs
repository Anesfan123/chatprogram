using System;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Client_1
{
    public partial class Form1 : Form
    {

        private string username;// Variabel för att lagra användarnamnet

        public Form1()
        {
            InitializeComponent();
            ConfigureLogging();// Konfigurerar loggningen när programmet initieras
        }
        
        UdpClient server;// UdpClient för att kommunicera med servern
        IPEndPoint remoteIP;// Endpoint för den fjärranslutna servern
        int remotPort = 55555; // Portnummer för fjärranslutningen
        int port = 44444;  // Lokalt portnummer

        // Metod för att konfigurera loggnings metod
        private void ConfigureLogging()
        {
            Trace.Listeners.Add(new TextWriterTraceListener("application.log"));// Loggning skickas till en fil
            Trace.Listeners.Add(new TextBoxTraceListener(logTextBox)); // Loggning till logTextBox
            Trace.AutoFlush = true; 
        }

        // Eventhanterare för när användaren klickar på "Connect"-knappen
        
        // Callback-metod som anropas när data tas emot
        private void onReceive(IAsyncResult AR)
        {
            Log("Tar emot data...");
            byte[] buff = server.EndReceive(AR, ref remoteIP);// Slutför mottagandet av data samt tar emot data
            server.BeginReceive(new AsyncCallback(onReceive), server);// Börjar ta emot data igen 
            string receivedMessage = Encoding.ASCII.GetString(buff);// Konverterar mottagen byte-array(data) till string variabel
            Log($"Mottaget meddelande: {receivedMessage}");
            ControlInvoke(screen_tbx, () => screen_tbx.AppendText(">>" + Encoding.ASCII.GetString(buff) + Environment.NewLine));// Visar meddelandet i screen_tbx
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        // Eventhanterare för när användaren klickar på "Send"-knappen
        private void btn_send_Click(object sender, EventArgs e)
        {
            string messageToSend = Message_tbx.Text;
            Log($"Skickar meddelande: {messageToSend}");
            server.Connect(remoteIP);// Ansluter till den fjärranslutna IP och porten
            server.Send(Encoding.ASCII.GetBytes(Message_tbx.Text), Message_tbx.Text.Length);// Skickar meddelandet som byte-array
            Message_tbx.Clear();// Rensar textBox efter att meddelandet skickats
            Log("Meddelande skickat.");

        }

        // Delegat för universell void-funktion
        delegate void UniversalVoidDelegate();

        // Metod för att utföra en åtgärd på en kontroll på ett säkert sätt
        public static void ControlInvoke(Control control, Action function)
        {
            if (control.IsDisposed || control.Disposing)
                return;

            if (control.InvokeRequired)
            {
                control.Invoke(new UniversalVoidDelegate(() => ControlInvoke(control, function)));
                    return;
            }
            function();// Utför funktionen
        }

        // Metod för att logga meddelanden
        private void Log(string message)
        {
            string logMessage = string.IsNullOrEmpty(username) ? message : $"{username}: {message}"; // Lägger till användarnamn om det finns
            Trace.WriteLine($"{DateTime.Now}: {message}"); // Skriver loggmeddelandet med tidsstämpel
        }

        // Eventhanterare för när användaren klickar på "Set Username"-knappen
        private void btn_setUsername_Click(object sender, EventArgs e)
        {
            username = usernameTextBox.Text.Trim(); // Hämtar och trimmar användarnamnet
            if (!string.IsNullOrEmpty(username))
            {
                Log($"Användare: {username}"+"har loggat in"); // Loggar användarnamnet
            }
            else
            {
                Log("Användarnamn kan inte vara tomt. Snälla skriv in ett giltigt användarnamn."); // Loggar felmeddelande om användarnamnet är tomt
            }
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            Log("Försökar att ansluta...");
            server = new UdpClient(port); // Initialiserar UdpClient på den lokala porten
            remoteIP = new IPEndPoint(IPAddress.Parse(IP_tbx.Text), remotPort);// Sätter fjärranslutningens IP och port
            server.BeginReceive(new AsyncCallback(onReceive), server); // Börjar ta emot data 
            Log($"Ansluten till {remoteIP.Address}:{remoteIP.Port}");

        }

        private void btn_uploadPicture_Click(object sender, EventArgs e)
        {
            // Konfigurerar OpenFileDialog för att välja bildfiler
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog1.Title = "Select a Profile Picture";

            // Visar OpenFileDialog och kontrollerar om användaren valt en fil
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Laddar den valda bilden i PictureBox
                profilePictureBox.Image = Image.FromFile(openFileDialog1.FileName);
                Log("Profile picture uploaded."); // Loggar att profilbilden har laddats upp
            }
        }
    }

    // Anpassad TraceListener för att skriva loggar till en TextBox
    public class TextBoxTraceListener : TraceListener
    {
        private readonly TextBox _target; // TextBox där loggar anteckans
        private readonly StringSendDelegate _invokeWrite; // Delegat för att skicka strängar

        public TextBoxTraceListener(TextBox target)
        {
            _target = target;
            _invokeWrite = new StringSendDelegate(SendString);
        }

        public override void Write(string message)
        {
            _target.Invoke(_invokeWrite, new object[] { message }); // Skriv meddelandet till TextBox
        }

        public override void WriteLine(string message)
        {
            _target.Invoke(_invokeWrite, new object[] { message + Environment.NewLine });
        }

        private delegate void StringSendDelegate(string message); // Delegat för att skicka strängar

        private void SendString(string message)
        {
            _target.AppendText(message); // Lägger till meddelandet i TextBox
        }
    }
}
