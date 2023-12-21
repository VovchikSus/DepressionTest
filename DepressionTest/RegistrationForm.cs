using System;
using System.Drawing;
using System.Windows.Forms;

namespace DepressionTest
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

// Переменные для движения окна
        bool dragging = false;
        Point dragCursorPoint;
        Point dragFormPoint;


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }


        private void closeButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(guna2TextBox1.Text) || string.IsNullOrWhiteSpace(guna2TextBox2.Text)) &&
                (guna2CheckBox1.Checked == false))
            {
                NameExeption nameExeption = new NameExeption();
                nameExeption.ShowDialog();
            }

            else
            {
                if (guna2CheckBox1.Checked == false)
                {
                    UserName.Name = guna2TextBox1.Text.ToUpper();
                    UserName.SecondName = guna2TextBox2.Text.ToUpper();
                }
                else
                {
                    UserName.Name = "ПОЛЬЗОВАТЕЛЬ";
                    UserName.SecondName = "АНОНИМНЫЙ";
                }

                HelloForm helloForm = new HelloForm();
                Hide();
                helloForm.Show();
            }
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked)
            {
                guna2TextBox1.Enabled = false;
                guna2TextBox2.Enabled = false;
            }
            else
            {
                guna2TextBox1.Enabled = true;
                guna2TextBox2.Enabled = true;
            }
        }
    }
}