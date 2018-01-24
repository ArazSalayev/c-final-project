using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Academy_project
{
    public partial class AdminPanelForm : Form
    {
        Code_AcademyEntities db = new Code_AcademyEntities();
        public AdminPanelForm()
        {
            InitializeComponent();
            ShowGridTeacher();
        }

        private void btn_add_teacher_Click(object sender, EventArgs e)
        {
            AddNewTeacherForm new_teacher = new AddNewTeacherForm();
            new_teacher.ShowDialog();
        }

        private void ShowGridTeacher()
        {
            teacherGridView.Rows.Clear();
            int i = 0;
            List<Teacher> list_teacher = db.Teachers.ToList();
            foreach (Teacher t_item in list_teacher)
            {
                teacherGridView.Rows.Add();
                teacherGridView.Rows[i].Cells[0].Value = t_item.teacher_name;
                teacherGridView.Rows[i].Cells[1].Value = t_item.teacher_surname;
                teacherGridView.Rows[i].Cells[2].Value = t_item.teacher_email;
                teacherGridView.Rows[i].Cells[3].Value = t_item.Gender.gender_name;
                DataGridViewButtonColumn bt = new DataGridViewButtonColumn();
                bt.DefaultCellStyle.NullValue = "Show";
                DataGridViewButtonColumn dl = new DataGridViewButtonColumn();
                dl.DefaultCellStyle.NullValue = "Delete";
                DataGridViewButtonColumn ed = new DataGridViewButtonColumn();
                ed.DefaultCellStyle.NullValue = "Edit";
                teacherGridView.Columns.Add(bt);
                teacherGridView.Columns.Add(dl);
                teacherGridView.Columns.Add(ed);


            }
        }
    }
}
