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
    public partial class infoA : Form
    {
        Employees emp = Autorization.USER.Employees;
        public infoA()
        {
            InitializeComponent();
        }

        private void infoA_Load(object sender, EventArgs e)
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
