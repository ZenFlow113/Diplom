using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;

namespace Kyrsach
{
    public partial class TaskAdd : Form
    {
        public TaskMgrADO db { get; set; }
        public TaskAdd()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage/*(this)*/;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey500, Primary.BlueGrey700, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            // проверяем, что имеется минимум необходимых данных
            if (materialSingleLineTextField3.Text == "")
            {
                MessageBox.Show("Нужно ввести все требуемые данные!");
                return;
            }
            //добавление новой записи в таблицу БД
            // создаем новый объект
            Tasks tasks = new Tasks();
            // задаем свойства объекта
            //tasks.TaskID = Convert.ToInt32(materialSingleLineTextField2.Text);
            tasks.EmployeeID = Convert.ToInt32(materialSingleLineTextField3.Text);
            tasks.GivingDate = beginDatePicker.Value;
            tasks.EndDate = endTimePicker.Value;
            tasks.Status = false;
            tasks.Description = richTextBox1.Text;
           
            // добавляем новый объект к коллекции        
            db.Tasks.Add(tasks);
            try
            {
                // сохраняем изменения коллекции в БД
                db.SaveChanges();
                // задаем свойство DialogResult, чтобы закрыть форму
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            { // сложная конструкция для показа сообщений сервера БД
                MessageBox.Show(ex.InnerException.InnerException.Message);
            }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void TaskAdd_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*GIF;*.PNG)|*.BMP;*.JPG;*GIF;*.PNG|All files (*.*)|*.*";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(ofd.FileName);
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
    }
}
