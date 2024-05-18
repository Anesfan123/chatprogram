
namespace Client_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.screen_tbx = new System.Windows.Forms.TextBox();
            this.IP_tbx = new System.Windows.Forms.TextBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Message_tbx = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_setUsername = new System.Windows.Forms.Button();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.btn_uploadPicture = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // screen_tbx
            // 
            this.screen_tbx.Location = new System.Drawing.Point(514, 166);
            this.screen_tbx.Multiline = true;
            this.screen_tbx.Name = "screen_tbx";
            this.screen_tbx.ReadOnly = true;
            this.screen_tbx.Size = new System.Drawing.Size(500, 382);
            this.screen_tbx.TabIndex = 0;
            // 
            // IP_tbx
            // 
            this.IP_tbx.Location = new System.Drawing.Point(161, 327);
            this.IP_tbx.Multiline = true;
            this.IP_tbx.Name = "IP_tbx";
            this.IP_tbx.Size = new System.Drawing.Size(180, 39);
            this.IP_tbx.TabIndex = 1;
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(347, 327);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(90, 39);
            this.btn_connect.TabIndex = 2;
            this.btn_connect.Text = "Anslut";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP Adress";
            // 
            // Message_tbx
            // 
            this.Message_tbx.Location = new System.Drawing.Point(12, 457);
            this.Message_tbx.Multiline = true;
            this.Message_tbx.Name = "Message_tbx";
            this.Message_tbx.Size = new System.Drawing.Size(386, 61);
            this.Message_tbx.TabIndex = 4;
            this.Message_tbx.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(404, 457);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(104, 61);
            this.btn_send.TabIndex = 5;
            this.btn_send.Text = "Skicka";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(587, 98);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTextBox.Size = new System.Drawing.Size(426, 62);
            this.logTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(609, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Protokol";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(161, 372);
            this.usernameTextBox.Multiline = true;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(180, 39);
            this.usernameTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Användarnamn";
            // 
            // btn_setUsername
            // 
            this.btn_setUsername.Location = new System.Drawing.Point(347, 375);
            this.btn_setUsername.Name = "btn_setUsername";
            this.btn_setUsername.Size = new System.Drawing.Size(90, 39);
            this.btn_setUsername.TabIndex = 10;
            this.btn_setUsername.Text = "Skicka";
            this.btn_setUsername.UseVisualStyleBackColor = true;
            this.btn_setUsername.Click += new System.EventHandler(this.btn_setUsername_Click);
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.BackColor = System.Drawing.SystemColors.GrayText;
            this.profilePictureBox.Location = new System.Drawing.Point(161, 12);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(180, 201);
            this.profilePictureBox.TabIndex = 11;
            this.profilePictureBox.TabStop = false;
            // 
            // btn_uploadPicture
            // 
            this.btn_uploadPicture.Location = new System.Drawing.Point(170, 219);
            this.btn_uploadPicture.Name = "btn_uploadPicture";
            this.btn_uploadPicture.Size = new System.Drawing.Size(97, 31);
            this.btn_uploadPicture.TabIndex = 12;
            this.btn_uploadPicture.Text = "Ladda Upp";
            this.btn_uploadPicture.UseVisualStyleBackColor = true;
            this.btn_uploadPicture.Click += new System.EventHandler(this.btn_uploadPicture_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 601);
            this.Controls.Add(this.btn_uploadPicture);
            this.Controls.Add(this.profilePictureBox);
            this.Controls.Add(this.btn_setUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.Message_tbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.IP_tbx);
            this.Controls.Add(this.screen_tbx);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox screen_tbx;
        private System.Windows.Forms.TextBox IP_tbx;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Message_tbx;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_setUsername;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Button btn_uploadPicture;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

