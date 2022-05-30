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
    public partial class AdPosition : Form
    {
        TaskMgrADO db = new TaskMgrADO();

        public AdPosition()
        {
            InitializeComponent();
        }


        private void AdPosition_Load(object sender, EventArgs e)
        {
            positionsBindingSource.DataSource = db.Positions.ToList();
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            // находим объект для записи, которую выбрал пользователь
            Positions positions = (Positions)positionsBindingSource.Current;
            // показываем диалоговое окно с кнопками Yes и No
            DialogResult dr = MessageBox.Show(" Вы действительно хотите удалить позицию под номером - " + positions.PositionID,
            " Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //если пользователь нажал кнопку «Да», то удаляем данные из БД
            if (dr == DialogResult.Yes)
            {
                // удаление записи из базы данных
                db.Positions.Remove(positions);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                positionsBindingSource.DataSource = db.Positions.ToList();
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Admini.posAddCentre ps = new Admini.posAddCentre();
            ps.db = db;
            DialogResult dr = ps.ShowDialog();
            if (dr == DialogResult.OK)
            {
                positionsBindingSource.DataSource = db.Positions.ToList();
            }


        }
    }
}