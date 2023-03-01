
namespace AS_CourseWork
{
    partial class Login
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
            this.lblLoginUsername = new System.Windows.Forms.Label();
            this.lblLoginPassword = new System.Windows.Forms.Label();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.comboLoginUsername = new System.Windows.Forms.ComboBox();
            this.btnBackToMenuLogin = new System.Windows.Forms.Button();
            this.lblPlayerOneLogin = new System.Windows.Forms.Label();
            this.picPlayerOneLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerOneLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoginUsername
            // 
            this.lblLoginUsername.AutoSize = true;
            this.lblLoginUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLoginUsername.Location = new System.Drawing.Point(380, 112);
            this.lblLoginUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginUsername.Name = "lblLoginUsername";
            this.lblLoginUsername.Size = new System.Drawing.Size(135, 32);
            this.lblLoginUsername.TabIndex = 0;
            this.lblLoginUsername.Text = "Username:";
            // 
            // lblLoginPassword
            // 
            this.lblLoginPassword.AutoSize = true;
            this.lblLoginPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLoginPassword.Location = new System.Drawing.Point(380, 313);
            this.lblLoginPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginPassword.Name = "lblLoginPassword";
            this.lblLoginPassword.Size = new System.Drawing.Size(129, 32);
            this.lblLoginPassword.TabIndex = 1;
            this.lblLoginPassword.Text = "Password:";
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Location = new System.Drawing.Point(594, 310);
            this.txtLoginPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.Size = new System.Drawing.Size(141, 31);
            this.txtLoginPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(380, 530);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(357, 122);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // comboLoginUsername
            // 
            this.comboLoginUsername.FormattingEnabled = true;
            this.comboLoginUsername.Location = new System.Drawing.Point(580, 108);
            this.comboLoginUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboLoginUsername.Name = "comboLoginUsername";
            this.comboLoginUsername.Size = new System.Drawing.Size(171, 33);
            this.comboLoginUsername.TabIndex = 5;
            // 
            // btnBackToMenuLogin
            // 
            this.btnBackToMenuLogin.Location = new System.Drawing.Point(100, 610);
            this.btnBackToMenuLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBackToMenuLogin.Name = "btnBackToMenuLogin";
            this.btnBackToMenuLogin.Size = new System.Drawing.Size(129, 42);
            this.btnBackToMenuLogin.TabIndex = 6;
            this.btnBackToMenuLogin.Text = "Back to Menu";
            this.btnBackToMenuLogin.UseVisualStyleBackColor = true;
            this.btnBackToMenuLogin.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // lblPlayerOneLogin
            // 
            this.lblPlayerOneLogin.AutoSize = true;
            this.lblPlayerOneLogin.Location = new System.Drawing.Point(814, 112);
            this.lblPlayerOneLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerOneLogin.Name = "lblPlayerOneLogin";
            this.lblPlayerOneLogin.Size = new System.Drawing.Size(91, 25);
            this.lblPlayerOneLogin.TabIndex = 8;
            this.lblPlayerOneLogin.Text = "Username";
            // 
            // picPlayerOneLogin
            // 
            this.picPlayerOneLogin.Location = new System.Drawing.Point(971, 70);
            this.picPlayerOneLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picPlayerOneLogin.Name = "picPlayerOneLogin";
            this.picPlayerOneLogin.Size = new System.Drawing.Size(84, 67);
            this.picPlayerOneLogin.TabIndex = 12;
            this.picPlayerOneLogin.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.picPlayerOneLogin);
            this.Controls.Add(this.lblPlayerOneLogin);
            this.Controls.Add(this.btnBackToMenuLogin);
            this.Controls.Add(this.comboLoginUsername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtLoginPassword);
            this.Controls.Add(this.lblLoginPassword);
            this.Controls.Add(this.lblLoginUsername);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerOneLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoginUsername;
        private System.Windows.Forms.Label lblLoginPassword;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ComboBox comboLoginUsername;
        private System.Windows.Forms.Button btnBackToMenuLogin;
        private System.Windows.Forms.Label lblPlayerOneLogin;
        private System.Windows.Forms.PictureBox picPlayerOneLogin;
    }
}