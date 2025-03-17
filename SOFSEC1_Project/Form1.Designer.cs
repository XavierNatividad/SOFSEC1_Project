namespace SOFSEC1_Project
{
    partial class GPAware
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
            this.Top = new System.Windows.Forms.Panel();
            this.LOGO = new System.Windows.Forms.Label();
            this.HOME = new System.Windows.Forms.Panel();
            this.Bottom = new System.Windows.Forms.Panel();
            this.Right = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Signup = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.LOGO2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.About = new System.Windows.Forms.TabPage();
            this.ConversionTable = new System.Windows.Forms.TabPage();
            this.Top.SuspendLayout();
            this.HOME.SuspendLayout();
            this.Right.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Top
            // 
            this.Top.BackColor = System.Drawing.Color.SeaGreen;
            this.Top.Controls.Add(this.LOGO);
            this.Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top.Location = new System.Drawing.Point(0, 0);
            this.Top.Name = "Top";
            this.Top.Size = new System.Drawing.Size(1264, 89);
            this.Top.TabIndex = 0;
            // 
            // LOGO
            // 
            this.LOGO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LOGO.Font = new System.Drawing.Font("Inter", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGO.ForeColor = System.Drawing.Color.White;
            this.LOGO.Location = new System.Drawing.Point(18, 19);
            this.LOGO.Name = "LOGO";
            this.LOGO.Size = new System.Drawing.Size(242, 52);
            this.LOGO.TabIndex = 0;
            this.LOGO.Text = "GPAware";
            this.LOGO.Click += new System.EventHandler(this.lblGPAware);
            // 
            // HOME
            // 
            this.HOME.AutoScroll = true;
            this.HOME.Controls.Add(this.tabControl1);
            this.HOME.Controls.Add(this.Top);
            this.HOME.Controls.Add(this.Bottom);
            this.HOME.Controls.Add(this.Right);
            this.HOME.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HOME.Location = new System.Drawing.Point(0, 0);
            this.HOME.Name = "HOME";
            this.HOME.Size = new System.Drawing.Size(1264, 681);
            this.HOME.TabIndex = 1;
            this.HOME.Paint += new System.Windows.Forms.PaintEventHandler(this.HOME_Paint);
            // 
            // Bottom
            // 
            this.Bottom.BackColor = System.Drawing.Color.SeaGreen;
            this.Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Bottom.Location = new System.Drawing.Point(0, 592);
            this.Bottom.Name = "Bottom";
            this.Bottom.Size = new System.Drawing.Size(1264, 89);
            this.Bottom.TabIndex = 1;
            // 
            // Right
            // 
            this.Right.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Right.BackColor = System.Drawing.Color.PaleGreen;
            this.Right.Controls.Add(this.label2);
            this.Right.Controls.Add(this.Signup);
            this.Right.Controls.Add(this.Login);
            this.Right.Controls.Add(this.textBox1);
            this.Right.Controls.Add(this.Password);
            this.Right.Controls.Add(this.UsernameBox);
            this.Right.Controls.Add(this.Username);
            this.Right.Controls.Add(this.LOGO2);
            this.Right.Location = new System.Drawing.Point(824, 119);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(406, 418);
            this.Right.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(193, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "or";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Signup
            // 
            this.Signup.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signup.Location = new System.Drawing.Point(48, 343);
            this.Signup.Name = "Signup";
            this.Signup.Size = new System.Drawing.Size(314, 35);
            this.Signup.TabIndex = 7;
            this.Signup.Text = "Create a new account";
            this.Signup.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(48, 267);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(314, 35);
            this.Login.TabIndex = 6;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(48, 193);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(314, 35);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = " ";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.Black;
            this.Password.Location = new System.Drawing.Point(44, 167);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(98, 23);
            this.Password.TabIndex = 4;
            this.Password.Text = "Password";
            // 
            // UsernameBox
            // 
            this.UsernameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameBox.Location = new System.Drawing.Point(44, 113);
            this.UsernameBox.Multiline = true;
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(314, 35);
            this.UsernameBox.TabIndex = 3;
            this.UsernameBox.Text = " ";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.Black;
            this.Username.Location = new System.Drawing.Point(40, 87);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(102, 23);
            this.Username.TabIndex = 2;
            this.Username.Text = "Username";
            // 
            // LOGO2
            // 
            this.LOGO2.BackColor = System.Drawing.Color.Transparent;
            this.LOGO2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LOGO2.Font = new System.Drawing.Font("Inter", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGO2.ForeColor = System.Drawing.Color.Black;
            this.LOGO2.Location = new System.Drawing.Point(0, 23);
            this.LOGO2.Name = "LOGO2";
            this.LOGO2.Size = new System.Drawing.Size(406, 40);
            this.LOGO2.TabIndex = 1;
            this.LOGO2.Text = "GPAware";
            this.LOGO2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.About);
            this.tabControl1.Controls.Add(this.ConversionTable);
            this.tabControl1.Font = new System.Drawing.Font("Inter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(28, 119);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(654, 418);
            this.tabControl1.TabIndex = 0;
            // 
            // About
            // 
            this.About.Location = new System.Drawing.Point(4, 34);
            this.About.Name = "About";
            this.About.Padding = new System.Windows.Forms.Padding(3);
            this.About.Size = new System.Drawing.Size(646, 380);
            this.About.TabIndex = 0;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = true;
            // 
            // ConversionTable
            // 
            this.ConversionTable.Location = new System.Drawing.Point(4, 34);
            this.ConversionTable.Name = "ConversionTable";
            this.ConversionTable.Padding = new System.Windows.Forms.Padding(3);
            this.ConversionTable.Size = new System.Drawing.Size(646, 380);
            this.ConversionTable.TabIndex = 1;
            this.ConversionTable.Text = "Conversion Table";
            this.ConversionTable.UseVisualStyleBackColor = true;
            // 
            // GPAware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.HOME);
            this.Name = "GPAware";
            this.Text = "GPAware";
            this.Load += new System.EventHandler(this.GPAware_Load);
            this.Top.ResumeLayout(false);
            this.HOME.ResumeLayout(false);
            this.Right.ResumeLayout(false);
            this.Right.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Top;
        private System.Windows.Forms.Label LOGO;
        private System.Windows.Forms.Panel HOME;
        private System.Windows.Forms.Panel Right;
        private System.Windows.Forms.Label LOGO2;
        private System.Windows.Forms.Panel Bottom;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Signup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage About;
        private System.Windows.Forms.TabPage ConversionTable;
    }
}

