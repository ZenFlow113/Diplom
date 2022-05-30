using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kyrsach
{
    public partial class Adm : Form
    {
        public Adm()
        {
            InitializeComponent();
        }

        private Form activeForm;

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane1.Controls.Add(childForm);
            this.panelDesktopPane1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Adm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdPosition());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admini.AdUser());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admini.infoA());
        }
    }
}
