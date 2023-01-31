using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        Random rnd = new Random();
        string[] Maths = {"Add", "Subtract", "Multiply"};
        int total;
        int score;
        int timercont = 25;

        public Form1()
        {
            InitializeComponent();
            SetUpGame();
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CheckAmswer(object sender, EventArgs e)
        {
            //Logra limitar que el usuario solo coloque "letras" de 0 a 9 y si no es asi le manda un msj.
            if (System.Text.RegularExpressions.Regex.IsMatch(textAnswer.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only number! ");
                textAnswer.Text= textAnswer.Text.Remove(textAnswer.Text.Length - 1);
            }
        }

        private void CheckButtonClickEvent(object sender, EventArgs e)
        {
            int userEntered = Convert.ToInt32(textAnswer.Text);
            timer1.Start(); 
            if (userEntered == total)
            {
                resultAnswer.Text = "Correct!";
                resultAnswer.ForeColor= Color.Green;
                score += 1;
                countScore.Text = "Score: " + score;
                SetUpGame();
            }
            else
            {
                resultAnswer.Text = "Incorrect";
                resultAnswer.ForeColor = Color.Red;
                textAnswer.Text = null;
            }
        }

        private void SetUpGame()
        {
            //harcodeado para que no salga negativo
            int numA = rnd.Next(10,50);
            int numB = rnd.Next(0,10);
            timer1.Start();

            textAnswer.Text = null;
            //elijir de forma aleatoria el simbolo
            switch (Maths[rnd.Next(0,Maths.Length)])
            {
                case "Add":
                    total = numA + numB;
                    simbol.Text = "+";
                    simbol.ForeColor= Color.Red;    
                    break;

                case "Subtract":
                    total = numA - numB;
                    simbol.Text = "-";
                    simbol.ForeColor = Color.Blue;
                    break;

                case "Multiply":
                    total = numA * numB;
                    simbol.Text = "x";
                    simbol.ForeColor = Color.Purple;
                    break;

                // no necesario default
            }

            numberA.Text = numA.ToString();
            numberB.Text = numB.ToString();
        }

        private void resultAnswer_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timerlb_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timercont <= 0)
            {
                timer1.Stop();
                timer1= null;
                MessageBox.Show("Time finish, your score is: " + score);                
            }
            else
            {
                timercont--;
            }
                
                textBox1.Text = timercont.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
