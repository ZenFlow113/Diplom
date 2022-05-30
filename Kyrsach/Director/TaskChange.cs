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
namespace Kyrsach
{
    public partial class TaskChange : Form
    {
        public TaskMgrADO db {get; set;}
        public Tasks tasks { get; set; }
        public TaskChange()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey500, Primary.BlueGrey700, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }


        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            tasks.EmployeeID = Convert.ToInt32(materialSingleLineTextField3.Text);
            tasks.GivingDate = beginTimePicker.Value;
            tasks.EndDate = endTimePicker.Value;
            tasks.Status = statusButton.Checked;
            tasks.Description = richTextBox1.Text;
            // теперь пытаемся сохранить измененный объект в БД
            try
            {
                // сохраняем изменения, сделанные в объектах коллекции в БД
                db.SaveChanges();
                // задаем свойство DialogResult, чтобы закрыть форму
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            { // если произошла ошибка - сообщаем
                MessageBox.Show(ex.InnerException.InnerException.Message);
            }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TaskChange_Load(object sender, EventArgs e)
        {
            materialSingleLineTextField3.Text = Convert.ToString(tasks.EmployeeID);
            statusButton.Checked = Convert.ToBoolean(tasks.Status);
            richTextBox1.Text = Convert.ToString(tasks.Description);
            beginTimePicker.Value = Convert.ToDateTime(tasks.GivingDate);
            endTimePicker.Value = Convert.ToDateTime(tasks.EndDate);
        }
    }
}
