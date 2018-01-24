namespace Code_Academy_project
{
    partial class AdminPanelForm
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
            this.teacherGridView = new System.Windows.Forms.DataGridView();
            this.btn_add_teacher = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.teacherGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // teacherGridView
            // 
            this.teacherGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.teacherGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacherGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.teacherGridView.Location = new System.Drawing.Point(46, 178);
            this.teacherGridView.Name = "teacherGridView";
            this.teacherGridView.Size = new System.Drawing.Size(1264, 150);
            this.teacherGridView.TabIndex = 0;
            // 
            // btn_add_teacher
            // 
            this.btn_add_teacher.Location = new System.Drawing.Point(1184, 137);
            this.btn_add_teacher.Name = "btn_add_teacher";
            this.btn_add_teacher.Size = new System.Drawing.Size(126, 23);
            this.btn_add_teacher.TabIndex = 1;
            this.btn_add_teacher.Text = "New Teacher";
            this.btn_add_teacher.UseVisualStyleBackColor = true;
            this.btn_add_teacher.Click += new System.EventHandler(this.btn_add_teacher_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Teacher Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Teacher Surname";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Teacher Email";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Teacher Gender";
            this.Column4.Name = "Column4";
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.btn_add_teacher);
            this.Controls.Add(this.teacherGridView);
            this.Name = "AdminPanelForm";
            this.Text = "AdminPanelForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.teacherGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView teacherGridView;
        private System.Windows.Forms.Button btn_add_teacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}