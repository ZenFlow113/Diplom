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
    public partial class Autorization : MaterialSkin.Controls.MaterialForm
    {
        public static int STATICID;
        public static Autorization AUT { get; set; }
        // открытое статическое свойство для хранения объекта класса USER 
        // для передачи данных о пользователе другим формам
        public static Users USER { get; set; }

        // закрытое поле хранит объект модели 
        // для использования данных о пользователях в методах класса
        TaskMgrADO db = new TaskMgrADO();
        public Autorization()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey500, Primary.BlueGrey700, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void materialSingleLineTextField2_Click(object sender, EventArgs e)
        {
            materialSingleLineTextField2.PasswordChar = '*';
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            if (materialSingleLineTextField1.Text == "" || materialSingleLineTextField2.Text == "")
            {
                MessageBox.Show("Нужно задать логин и пароль!");
                return;
            }
            // ищем с введенным логином – первичным ключем
            Users usr = db.Users.Find(materialSingleLineTextField1.Text);


            if ((usr != null) && (usr.Password == materialSingleLineTextField2.Text))
            {
                // сохраняем данные пользователя в статической переменной
                // для использования данных пользователя в других формах
                USER = usr;

                // сохраняем ссылку на данную форму в статической переменной
                // для возврата к этой форме      
                AUT = this;

                try
                {
                    if (usr.Role == "Director")
                    {
                        Direc dr = new Direc();
                        dr.Show();
                        this.Hide();
                    }
                    if (usr.Role == "Admin")
                    {
                        Adm ad = new Adm();
                        ad.Show();
                        this.Hide();
                    }
                    if (usr.Role == "Manager")
                    {
                        ManagerA ma = new ManagerA();
                        ma.Show();
                        this.Hide();
                    }
                }

                catch
                {
                    MessageBox.Show("Вы удалены из системы!");
                    return;
                }
                
            }
            else
            {
                MessageBox.Show("Пользователя с таким логином и паролем нет!");
                return;
            }
        }
    }
}
