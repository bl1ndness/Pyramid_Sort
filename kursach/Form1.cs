using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach
{
    public partial class Form1 : Form
    {
        List<User> list = new List<User>();
        public Form1()
        {
            InitializeComponent();
            
            if(Serialize.IsFile("users.txt"))
            {
                list = Serialize.LoadFromFile("users.txt");
            }
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void button_login_Click(object sender, EventArgs e)
        {
            bool user_is_existed = false;
            foreach (var user in list)
            {
                if (textBox_login.Text == user.login && textBox_password.Text == user.password)
                {
                    user_is_existed = true;
                    Form2 form2 = new Form2();
                    form2.Tag = this; // сохраняем ссылку в form2.Tag
                    this.Hide();
                    form2.Show();
                }
            }
            if (user_is_existed == false)
            {
                MessageBox.Show("Такого пользователя не существует, зарегистрируйтесь!");
            }
        }
        public void button_register_Click(object sender, EventArgs e)
        {
            User user = new User();
            
            foreach(var usr in list)
            {
                if (usr.login == textBox_login.Text)
                {
                    MessageBox.Show("Пользователь с таким логином уже существует!");
                    goto Marker1;
                }
                
            }
            user.login = textBox_login.Text;
            user.password = textBox_password.Text;           
            list.Add(user);
            MessageBox.Show("Вы успешно зарегистрировались, используйте свой пароль и логин для входа в программу!");
            Marker1:
            textBox_login.Text = "";
            textBox_password.Text = "";
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        public void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Serialize.SaveToFile("users.txt", list);
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Вы действительно хотите выйти из программы?"
, "Завершение программы", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
