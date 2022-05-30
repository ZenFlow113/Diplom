using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kyrsach.ManagerABC
{
    public partial class infoM : Form
    {
        Employees emp = Autorization.USER.Employees;
        public infoM()
        {
            InitializeComponent();
        }

        private void infoM_Load(object sender, EventArgs e)
        {
            string str = emp.Photo + ".png";
            photoBox.Image = Image.FromFile(str);

            fnameLabel.Text = emp.FirstName;
            snameLabel.Text = emp.SecondName;
            mnameLabel.Text = emp.ThirdName;
            mailLabel.Text = emp.E_mail;
            addressLabel.Text = emp.Address;
            phoneLabel.Text = emp.Phone;
        }
    }
}
