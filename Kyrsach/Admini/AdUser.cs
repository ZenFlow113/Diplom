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
    public partial class AdUser : Form
    {
        TaskMgrADO db = new TaskMgrADO();
        public AdUser()
        {
            InitializeComponent();
        }

        private void AdUser_Load(object sender, EventArgs e)
        {
            usersBindingSource.DataSource = db.Users.ToList();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Admini.usAddCentre us = new usAddCentre();
            us.db = db;
            DialogResult dr = us.ShowDialog();
            if (dr == DialogResult.OK)
            {
                usersBindingSource.DataSource = db.Users.ToList();
            }
        }
    }
}

//Admini.posAddCentre ps = new Admini.posAddCentre();
//ps.db = db;
//DialogResult dr = ps.ShowDialog();
//if (dr == DialogResult.OK)
//{
//    positionsBindingSource.DataSource = db.Positions.ToList();
//}