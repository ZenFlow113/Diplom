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
    public partial class Staff : Form
    {
        TaskMgrADO db = new TaskMgrADO();

        public Staff()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            if (Autorization.USER.Role == "Director")
            {
                materialRaisedButton2.Visible = false;
                materialRaisedButton3.Visible = false;
                materialRaisedButton4.Visible = false;
            }
            else if (Autorization.USER.Role == "Admin")
            {
                materialRaisedButton2.Visible = true;
                materialRaisedButton3.Visible = true;
                materialRaisedButton4.Visible = true;
            }
            else if (Autorization.USER.Role == "Manager")
            {
                materialRaisedButton2.Visible = false;
                materialRaisedButton3.Visible = false;
                materialRaisedButton4.Visible = false;
            }
            employeesBindingSource.DataSource = db.Employees.ToList();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
 
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
