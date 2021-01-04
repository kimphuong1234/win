namespace Section1again
{
    partial class monitoring_activities
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
            this.txtReason = new System.Windows.Forms.TextBox();
            this.rdbtnSoftware = new System.Windows.Forms.RadioButton();
            this.rbbtnSystem = new System.Windows.Forms.RadioButton();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "No logout detected for your last login on ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "06/07/2017";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "at";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Reason :";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(36, 125);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(702, 207);
            this.txtReason.TabIndex = 5;
            this.txtReason.UseWaitCursor = true;
            this.txtReason.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rdbtnSoftware
            // 
            this.rdbtnSoftware.AutoSize = true;
            this.rdbtnSoftware.Location = new System.Drawing.Point(121, 387);
            this.rdbtnSoftware.Name = "rdbtnSoftware";
            this.rdbtnSoftware.Size = new System.Drawing.Size(125, 21);
            this.rdbtnSoftware.TabIndex = 6;
            this.rdbtnSoftware.TabStop = true;
            this.rdbtnSoftware.Text = "Software Crash";
            this.rdbtnSoftware.UseVisualStyleBackColor = true;
            // 
            // rbbtnSystem
            // 
            this.rbbtnSystem.AutoSize = true;
            this.rbbtnSystem.Location = new System.Drawing.Point(332, 387);
            this.rbbtnSystem.Name = "rbbtnSystem";
            this.rbbtnSystem.Size = new System.Drawing.Size(116, 21);
            this.rbbtnSystem.TabIndex = 7;
            this.rbbtnSystem.TabStop = true;
            this.rbbtnSystem.Text = "System Crash";
            this.rbbtnSystem.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(563, 385);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // monitoring_activities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.rbbtnSystem);
            this.Controls.Add(this.rdbtnSoftware);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "monitoring_activities";
            this.Text = "No logout detected";
            this.Load += new System.EventHandler(this.monitoring_activities_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.RadioButton rdbtnSoftware;
        private System.Windows.Forms.RadioButton rbbtnSystem;
        private System.Windows.Forms.Button btnConfirm;
    }
}