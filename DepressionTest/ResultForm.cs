using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DepressionTest
{
    public partial class ResultForm : Form
    {
        
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



        public ResultForm()
        {
            InitializeComponent();

            if (Results.AnexityResult > 1.28)
            {
                label1.Text =
                    "Набранная Вами шкала тревожности свидетельствует о хорошем психическом состоянии, здоровье.";
            }
            else if ((Results.AnexityResult < 1.28) && (Results.AnexityResult > -1.28))
            {
                label1.Text =
                    "Набранная Вами шкала тревожности свидетельствует о неустойчивой психической адаптации, неопределенности данных. ";
            }
            else
            {
                label1.Text =
                    "Набранная Вами шкала тревожности свидетельствует о пограничном состоянии тревожности. " +
                    "Оно проявляется в снижении порога возбуждения по отношению к различным стимулам, в нерешительности, " +
                    "нетерпеливости, непоследовательности действия. Невротическая реакция тревожности как беспокойства за собственное " +
                    "здоровья и за здоровье своих близких, в общении с людьми проявляется в том, что человек ведет себя неуверенно. ";
            }

            if (Results.DepressionResult > 1.28)
            {
                label2.Text =
                    "Набранная Вами шкала депрессии свидетельствует о хорошем психическом состоянии, здоровье. ";
            }
            else if ((Results.DepressionResult < 1.28) && (Results.DepressionResult > -1.28))
            {
                label2.Text =
                    "Набранная Вами шкала депрессии свидетельствует о неустойчивой психической адаптации, неопределенности данных. ";
            }
            else
            {
                label2.Text =
                    "Набранная Вами шкала депрессии свидетельствует о пограничном состоянии депрессии. Оно проявляется в невротических реакциях: в ослаблении тонуса жизни и энергии, в снижении фона настроения, сужении и ограничении контактов с окружающими, наличии и ограничении контактов с окружающими, наличии чувства безрадостности и одиночества.";
            }
            
            using (StreamWriter resultToFiler = File.AppendText("TestResult.txt"))
            {
                resultToFiler.WriteLine($"{UserName.SecondName} {UserName.Name} [ Баллы Тревожности: {Results.AnexityResult} | Баллы Депрессии: {Results.DepressionResult} ]" );
                resultToFiler.Close();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}