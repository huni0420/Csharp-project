using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            textBox1.MaxLength = 16;
            textBox2.MaxLength = 11;
        }
        static string ID = "mysky0420";
        static string PWD = "1234";
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("아이디를 입력해주세요");
            }
            else if (!String.IsNullOrWhiteSpace(textBox1.Text))
            {
                if (!String.IsNullOrWhiteSpace(textBox2.Text))
                {
                    if (textBox1.Text.Equals(ID.ToString()))
                    {
                        if (textBox2.Text.Equals(PWD.ToString()))
                        {
                            MessageBox.Show("행복한 하루 되세요!!^^");
                            this.Close();
                        }
                        else if (!(textBox2.Text.Equals("1234")))
                        {
                            MessageBox.Show("비밀번호가 틀렸습니다");
                        }
                    }
                    else if (!(textBox1.Text.Equals("mysky0420")))
                    {
                        MessageBox.Show("아이디가 틀렸습니다.");
                    }
                }
                else if (String.IsNullOrWhiteSpace(textBox2.Text))
                {
                    MessageBox.Show("비밀번호를 입력해주세요");
                }
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Close();
        }
    }
}