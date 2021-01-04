namespace Session1
{
    partial class EditRole
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.cbbOffice = new System.Windows.Forms.ComboBox();
            this.rdbtnUser = new System.Windows.Forms.RadioButton();
            this.rdbtnAdministrator = new System.Windows.Forms.RadioButton();
            this.Apply = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "First name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Office";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 262);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Role";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(280, 31);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(269, 22);
            this.txtEmail.TabIndex = 5;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(280, 80);
            this.txtFirstname.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(269, 22);
            this.txtFirstname.TabIndex = 6;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(280, 129);
            this.txtLastname.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(269, 22);
            this.txtLastname.TabIndex = 7;
            // 
            // cbbOffice
            // 
            this.cbbOffice.FormattingEnabled = true;
            this.cbbOffice.Location = new System.Drawing.Point(280, 181);
            this.cbbOffice.Margin = new System.Windows.Forms.Padding(4);
            this.cbbOffice.Name = "cbbOffice";
            this.cbbOffice.Size = new System.Drawing.Size(269, 24);
            this.cbbOffice.TabIndex = 8;
            // 
            // rdbtnUser
            // 
            this.rdbtnUser.AutoSize = true;
            this.rdbtnUser.Location = new System.Drawing.Point(280, 257);
            this.rdbtnUser.Margin = new System.Windows.Forms.Padding(4);
            this.rdbtnUser.Name = "rdbtnUser";
            this.rdbtnUser.Size = new System.Drawing.Size(59, 21);
            this.rdbtnUser.TabIndex = 9;
            this.rdbtnUser.TabStop = true;
            this.rdbtnUser.Text = "User";
            this.rdbtnUser.UseVisualStyleBackColor = true;
            this.rdbtnUser.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbtnAdministrator
            // 
            this.rdbtnAdministrator.AutoSize = true;
            this.rdbtnAdministrator.Location = new System.Drawing.Point(280, 292);
            this.rdbtnAdministrator.Margin = new System.Windows.Forms.Padding(4);
            this.rdbtnAdministrator.Name = "rdbtnAdministrator";
            this.rdbtnAdministrator.Size = new System.Drawing.Size(112, 21);
            this.rdbtnAdministrator.TabIndex = 10;
            this.rdbtnAdministrator.TabStop = true;
            this.rdbtnAdministrator.Text = "Administrator";
            this.rdbtnAdministrator.UseVisualStyleBackColor = true;
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(163, 395);
            this.Apply.Margin = new System.Windows.Forms.Padding(4);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(129, 28);
            this.Apply.TabIndex = 11;
            this.Apply.Text = "Apply";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(329, 395);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 28);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EditRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.rdbtnAdministrator);
            this.Controls.Add(this.rdbtnUser);
            this.Controls.Add(this.cbbOffice);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditRole";
            this.Text = "EditRole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.ComboBox cbbOffice;
        private System.Windows.Forms.RadioButton rdbtnUser;
        private System.Windows.Forms.RadioButton rdbtnAdministrator;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.Button button2;
    }
}