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
    public partial class Form1 : Form
    {
        Code_AcademyEntities db = new Code_AcademyEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_sing_in_Click(object sender, EventArgs e)
        {
            AdminPanelForm admin_panel = new AdminPanelForm();
            admin_panel.ShowDialog();
        }
    }
}
