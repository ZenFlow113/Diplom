using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Kyrsach.Director
{
    public partial class Info : Form
    {
        TaskMgrADO db = new TaskMgrADO();
        Employees emp = Autorization.USER.Employees;
        public Info()
        {
            InitializeComponent();
        }

        private void Info_Load(object sender, EventArgs e)
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
