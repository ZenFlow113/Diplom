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
    public partial class taskList : Form
    {
        TaskMgrADO db = new TaskMgrADO();
        public taskList()
        {
            InitializeComponent();
        }

        

        private void taskList_Load(object sender, EventArgs e)
        {
            tasksBindingSource.DataSource = db.Tasks.ToList();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            TaskAdd ta = new TaskAdd();
            ta.db = db;
            DialogResult dr = ta.ShowDialog();
            if (dr == DialogResult.OK)
            {
                tasksBindingSource.DataSource = db.Tasks.ToList();
            }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            // создаем новую объект формы для изменения данных
            TaskChange tc = new TaskChange();
            // Находим объект, который выбрал пользователь (текущий)
            Tasks tasks = (Tasks)tasksBindingSource.Current;
            // передаем данные в форму
            tc.db = db;
            tc.tasks = tasks;
            // Показываем форму в диалоговом режиме
            DialogResult dr = tc.ShowDialog();
            // если измененные данные сохранены в БД, то таблицу обновим
            if (dr == DialogResult.OK)
            {
                tasksBindingSource.DataSource = db.Tasks.ToList();
            }
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            // находим объект для записи, которую выбрал пользователь
            Tasks tasks = (Tasks)tasksBindingSource.Current;
            // показываем диалоговое окно с кнопками Yes и No
            DialogResult dr = MessageBox.Show(" Вы действительно хотите удалить задачу под номером - " + tasks.TaskID,
            " Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // если пользователь нажал кнопку «Да», то удаляем данные из БД
            if (dr == DialogResult.Yes)
            {
                // удаление записи из базы данных
                db.Tasks.Remove(tasks);

                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                tasksBindingSource.DataSource = db.Tasks.ToList();
            }
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void tasksBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
