using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kyrsach.Admini
{
    public partial class posAddCentre : Form
    {
        public TaskMgrADO db { get; set; }
        public posAddCentre()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Нужно ввести все требуемые данные!");
                return;
            }
            Positions positions = new Positions();
            positions.PositionID = Convert.ToInt32(textBoxId.Text);
            positions.PostionName = Convert.ToString(textBoxName.Text);
            db.Positions.Add(positions);
            try
            {
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.InnerException.Message);
            }
        }

        private void posAddCentre_Load(object sender, EventArgs e)
        {

        }

        private void btnBackPos_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
