namespace Code_Academy_project
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_userpassword = new System.Windows.Forms.TextBox();
            this.btn_sing_in = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Password";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(509, 259);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(158, 20);
            this.txt_username.TabIndex = 2;
            // 
            // txt_userpassword
            // 
            this.txt_userpassword.Location = new System.Drawing.Point(509, 303);
            this.txt_userpassword.Name = "txt_userpassword";
            this.txt_userpassword.Size = new System.Drawing.Size(158, 20);
            this.txt_userpassword.TabIndex = 2;
            // 
            // btn_sing_in
            // 
            this.btn_sing_in.Location = new System.Drawing.Point(592, 353);
            this.btn_sing_in.Name = "btn_sing_in";
            this.btn_sing_in.Size = new System.Drawing.Size(75, 23);
            this.btn_sing_in.TabIndex = 3;
            this.btn_sing_in.Text = "Sing In";
            this.btn_sing_in.UseVisualStyleBackColor = true;
            this.btn_sing_in.Click += new System.EventHandler(this.btn_sing_in_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.btn_sing_in);
            this.Controls.Add(this.txt_userpassword);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_userpassword;
        private System.Windows.Forms.Button btn_sing_in;
    }
}

