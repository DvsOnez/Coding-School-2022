using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_06
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }
        private double firstNum = 0;
        private double secondNum = 0;
        private double result = 0;
        private int operatorType = (int)MathOperations.NoOperator;

        public enum MathOperations
        {

            NoOperator = 0,
            add = 1,
            Minus = 2,
            Divide = 3,
            Multiply = 4,
            Percentage = 5,
            Sqrt = 6,
            Power = 7
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DigitBtn_Click(object sender, EventArgs e)
        {
                      {
                Button btn = (Button)sender;
                if (DisplayTextBox.Text == "0")
                {

                    DisplayTextBox.Clear();

                }

                DisplayTextBox.Text = DisplayTextBox.Text + btn.Text;
            }

        }

        private void DotButton_Click(object sender, EventArgs e)
        {
            if (!DisplayTextBox.Text.Contains('.'))
            {
                DisplayTextBox.Text += ".";

            }    
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (!DisplayTextBox.Text.Contains('-'))
            {
                DisplayTextBox.Text = "-" + DisplayTextBox.Text;
            }
            else
            {
                DisplayTextBox.Text = DisplayTextBox.Text.Trim('-');

            }
            
        }

        private void DiversionButton_Click(object sender, EventArgs e)
        {
            SaveValueAndOperatorType((int)MathOperations.Divide);
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            SaveValueAndOperatorType((int)MathOperations.add);
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            SaveValueAndOperatorType((int)MathOperations.Minus);
        }
       

        private void MultiplicationButton_Click(object sender, EventArgs e)
        {
            SaveValueAndOperatorType((int)MathOperations.Multiply);
        }
        

        private void PercentageButton_Click(object sender, EventArgs e)
        {
            SaveValueAndOperatorType((int)MathOperations.Percentage);
        }
        private void SaveValueAndOperatorType(int operation)
        {

            operatorType = operation;
            firstNum = Convert.ToDouble(DisplayTextBox.Text);
            DisplayTextBox.Text = "0";
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            secondNum = Convert.ToDouble(DisplayTextBox.Text);
            switch (operatorType)
            {
                case 1:
                    result = firstNum + secondNum;
                    break;
                case 2:
                    result = firstNum - secondNum;
                    break;
                case 3:
                    result = firstNum / secondNum;
                    break;
                case 4:
                    result = firstNum * secondNum;
                    break;
                case 5:
                    result = (firstNum / secondNum) *100;
                    break;
                case 6:
                    result = Math.Sqrt(firstNum);
                    break;
                case 7:
                    result = Math.Pow(firstNum , secondNum);
                    break;
            }
            DisplayTextBox.Text = result.ToString();
        }

        private void CEButton_Click(object sender, EventArgs e)
        {
            DisplayTextBox.Text = "0";
        }

        private void CButton_Click(object sender, EventArgs e)
        {
            DisplayTextBox.Text = "0";
            firstNum = 0;
            secondNum = 0;
            result = 0;
            operatorType = (int)MathOperations.NoOperator;
        }

        private void SqrtButton_Click(object sender, EventArgs e)
        {
            SaveValueAndOperatorType((int)MathOperations.Sqrt);
        }

        private void PowerButton_Click(object sender, EventArgs e)
        {
            SaveValueAndOperatorType((int)MathOperations.Power);
        }
    }
    }

