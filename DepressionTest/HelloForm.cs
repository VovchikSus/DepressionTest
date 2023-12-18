using System;
using System.Windows.Forms;

namespace DepressionTest
{
    public partial class HelloForm : Form
    {
        public HelloForm()
        {
            InitializeComponent();
        }


        private void iconButton1_Click(object sender, EventArgs e)
        {
            TestForm newTestForm = new TestForm();
            HelloForm newHelloForm = new HelloForm();
            newTestForm.Show();
            newHelloForm.Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}