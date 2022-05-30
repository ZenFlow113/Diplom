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
    public partial class usAddCentre : Form
    {
        public TaskMgrADO db { get; set; }
        public usAddCentre()
        {
            InitializeComponent();
        }

        private void usAddCentre_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "" && textBoxPaswrd.Text == "" && textBoxRole.Text == "")
            {
                MessageBox.Show("Нужно ввести все требуемые данные!");
            }
            Users users = new Users();
            users.UserID = Convert.ToInt32(textBoxUserID.Text);
            users.EmployeeID = Convert.ToInt32(textBoxEmplId.Text);
            users.Login = Convert.ToString(textBoxLogin.Text);
            users.Password = Convert.ToString(textBoxPaswrd.Text);
            users.Role = Convert.ToString(textBoxRole.Text);
            db.Users.Add(users);
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

        private void btnBackPos_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
//if (textBoxName.Text == "")
//{
//    MessageBox.Show("Нужно ввести все требуемые данные!");
//    return;
//}
//Positions positions = new Positions();
//positions.PositionID = Convert.ToInt32(textBoxId.Text);
//positions.PostionName = Convert.ToString(textBoxName.Text);
//db.Positions.Add(positions);
//try
//{
//    db.SaveChanges();
//    DialogResult = DialogResult.OK;
//}
//catch (Exception ex)
//{
//    MessageBox.Show(ex.InnerException.InnerException.Message);
//}