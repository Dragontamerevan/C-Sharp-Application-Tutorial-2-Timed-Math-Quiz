using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        // Create a Random object called randomizer to generate random numbers
        Random randomizer = new Random();

        // Initialise integer variables to store numbers for the addition problem
        int addend1;
        int addend2;
        // Initialise integer variables to store numbers for the subtraction problem
        int minuend;
        int subtrahend;
        // Intialise integer variables to store numbers for multiplication problem
        int multiplicand;
        int multiplier;
        // Intialise integer variables to store numbers for division problem
        int dividend;
        int divisor;

        // Initialise integer variable to keep track of remaining time
        int timeLeft;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Start quiz by filling in all problems & starting the timer
        /// </summary>
        public void StartTheQuiz()
        {
            // Fill in addition problem.
            // Generate two random numbers to add.
            // Store values in variables addend1 & addend2
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);
            // Convert randomly generated numbers into string to be displayed in label controls
            lblAddL.Text = addend1.ToString();
            lblAddR.Text = addend2.ToString();
            // Ensure NumericUpDown control value is zero before adding any values
            sum.Value = 0;

            //Fill the subtraction problem
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            lblSubL.Text = minuend.ToString();
            lblSubR.Text = subtrahend.ToString();
            diff.Value = 0;

            //Fill the multiplication problem
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            lblMulL.Text = multiplicand.ToString();
            lblMulR.Text = multiplier.ToString();
            product.Value = 0;

            //Fill the division problem
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            lblDivL.Text = dividend.ToString();
            lblDivR.Text = divisor.ToString();
            quotient.Value = 0;


            //Start the timer
            timeLeft = 30;
            lblTime.Text = "30 seconds";
            timer1.Start();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Call StartTheQuiz method
            StartTheQuiz();
            //Lock btnStart so that it cannot be clicked during a quiz
            btnStart.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                //If CheckTheAnswer() returns true, then the user got it right. Stop the timer & show a MessageBox
                timer1.Stop();
                MessageBox.Show("You got all the answers right!", "Congratulations!");
                btnStart.Enabled = true;
            }
            if (timeLeft > 0)
            {
                //Display new time left by updating the time left label
                timeLeft = timeLeft - 1;
                lblTime.Text = timeLeft + " seconds";
                if (timeLeft <= 5)
                {
                    lblTime.BackColor = Color.Red;
                }
            }
            else
            {
                //If the user ran out of time, stop the timer, show a message box & fill in the answers
                timer1.Stop();
                lblTime.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                sum.Value = addend1 + addend2;
                diff.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                btnStart.Enabled = true;
                lblTime.BackColor = Color.Transparent;
            }
        }

        /// <summary>
        /// Check answer to see if user got everything right
        /// </summary>
        /// <returns></returns>
        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == sum.Value) 
                && (minuend - subtrahend == diff.Value)
                && (multiplicand * multiplier == product.Value)
                && (dividend / divisor == quotient.Value))
                return true;
            else
                return false;
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            //Select the whole answer in the NumericUpDown control (NumericUpDown control is named answerBox in this method)
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void answer_Check(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;
            if ((answerBox.Name == "sum") && (answerBox.Value == addend1 + addend2))
            {
                PlaySimpleSound();
            }
            else if ((answerBox.Name == "diff") && (answerBox.Value == minuend - subtrahend))
            {
                PlaySimpleSound();
            }
            else if ((answerBox.Name == "product") && (answerBox.Value == multiplicand * multiplier))
            {
                PlaySimpleSound();
            }
            else if ((answerBox.Name == "quotient") && (answerBox.Value == dividend / divisor))
            {
                PlaySimpleSound();
            }
        }

        private void PlaySimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Windows\Media\chimes.wav");
            simpleSound.Play();
        }
    }
}
