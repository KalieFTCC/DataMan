using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dataman_Library;

namespace Dataman
{
    public partial class AnswerMan : Form
    {
        string[] Operators = { "Add", "Subtract", "Multiply" };
        int total;
        int score;

        public AnswerMan()
        {
            InitializeComponent();
            AnswerManStart();
        }

        private void CheckAnswer(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(answerTxT.Text, "[^0-9]"))
            //checks if anything in the textbox is between 0-9
            {
                MessageBox.Show("Please enter only numbers","Error!");
                answerTxT.Text = answerTxT.Text.Remove(answerTxT.Text.Length - 1);
                //removes only the letters or symbols people answer, and removes the instance of that they enter, therefore what they typed in previously isn't removed.
            }
        }

        private void CheckBtnClick(object sender, EventArgs e)
        {
            int numberEntered = Convert.ToInt32(answerTxT.Text);
            if (numberEntered == total)
            {
                answerLbl.Text = "Correct";
                answerLbl.ForeColor = Color.ForestGreen;
                score += 1;
                scoreLbl.Text = "Score: " + score;
                AnswerManStart();
            }
            else 
            {
                answerLbl.Text = "Incorrect";
                answerLbl.ForeColor = Color.Red;
            }
        }
        private void AnswerManStart()
        {
            int numA = BetterRandomNumber.Between(10, 50);
            int numB = BetterRandomNumber.Between(1, 9);

            answerTxT.Text = null;
            //creates true random numbers, and empties anything previously in the text

            switch (Operators[BetterRandomNumber.Between(0, Operators.Length -1)])
            {
                case "Add":
                    total = numA + numB;
                    SymbolLblA.Text = "+";
                    SymbolLblA.ForeColor = Color.Green;
                    break;

                case "Subtract":
                    total = numA - numB;
                    SymbolLblA.Text = "-";
                    SymbolLblA.ForeColor = Color.Magenta;
                    break;
                case "Multiply":
                    total = numA * numB;
                    SymbolLblA.Text = "*";
                    SymbolLblA.ForeColor = Color.MediumPurple;
                    break;
            }
            NumberLblA.Text = numA.ToString();
            NumberLblB.Text = numB.ToString();


        }

    }
}
