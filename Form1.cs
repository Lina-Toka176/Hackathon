using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Реактор_22_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ВОЙТИ(object sender, EventArgs e)
        {
            string Login = TbRegistr.Text;
            string Password = TbPassword.Text;
            if (Login == "польз1" && Password == "123")
            {
                MessageBox.Show("Успешно", "Авторизация", MessageBoxButtons.OK);
                // переходs на другую форму

                var user_form = new Form2();
                Form2 User_form = new Form2();

                user_form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Авторизация", MessageBoxButtons.OK);
                TbRegistr.Focus();
                TbPassword.Clear();
            }
        }
    }
}
