using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsKalkylator
{
    public partial class Calculator : Form
    {
        bool firstSum = true;
        bool secondSum = false;

        bool oneTimeUse = false;

        bool additionSums = false;
        bool subtraktSums = false;
        bool timesSums = false;
        bool divideSums = false;

        bool secondNumberNeeded = false;

        List<float> firstNumber = new List<float>();
        List<float> secondNumber = new List<float>();

        public Calculator()
        {
            InitializeComponent();
        }


        private void One_Click(object sender, EventArgs e)
        {
            if (firstSum)
            {
                oneTimeUse = true;
                firstNumber.Add(1);
                Display.Text += 1;
            } else if (secondSum)
            {
                secondNumberNeeded = true;
                secondNumber.Add(1);
                Display.Text += 1;
            } else
            {

            }
            
        }

        private void Two_Click(object sender, EventArgs e)
        {
            if (firstSum)
            {
                oneTimeUse = true;
                firstNumber.Add(2);
                Display.Text += 2;
            } else if(secondSum)
            {
                secondNumberNeeded = true;
                secondNumber.Add(2);
                Display.Text += 2;
            } else
            {

            }
            
        }

        private void Three_Click(object sender, EventArgs e)
        {
            if (firstSum)
            {
                oneTimeUse = true;
                firstNumber.Add(3);
                Display.Text += 3;
            }
            else if (secondSum)
            {
                secondNumberNeeded = true;
                secondNumber.Add(3);
                Display.Text += 3;
            } else
            {

            }
        }

        private void Four_Click(object sender, EventArgs e)
        {
            if (firstSum)
            {
                oneTimeUse = true;
                firstNumber.Add(4);
                Display.Text += 4;
            } else if (secondSum)
            {
                secondNumberNeeded = true;
                secondNumber.Add(4);
                Display.Text += 4;
            } else
            {

            }
        }

        private void Five_Click(object sender, EventArgs e)
        {
            if (firstSum)
            {
                oneTimeUse = true;
                firstNumber.Add(5);
                Display.Text += 5;
            } else if (secondSum)
            {
                secondNumberNeeded = true;
                secondNumber.Add(5);
                Display.Text += 5;
            } else
            {

            }
        }

        private void Six_Click(object sender, EventArgs e)
        {
            if (firstSum)
            {
                oneTimeUse = true;
                firstNumber.Add(6);
                Display.Text += 6;
            } else if (secondSum)
            {
                secondNumberNeeded = true;
                secondNumber.Add(6);
                Display.Text += 6;
            } else
            {

            }
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            if (firstSum)
            {
                oneTimeUse = true;
                firstNumber.Add(7);
                Display.Text += 7;
            } else if (secondSum)
            {
                secondNumber.Add(7);
                Display.Text += 7;
            } else
            {
                secondNumberNeeded = true;
                additionSums = false;
                subtraktSums = false;

            }
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            if (firstSum)
            {
                oneTimeUse = true;
                firstNumber.Add(8);
                Display.Text += 8;
            } else if (secondSum)
            {
                secondNumberNeeded = true;
                secondNumber.Add(8);
                Display.Text += 8;
            } else
            {

            }
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            if (firstSum)
            {
                oneTimeUse = true;
                firstNumber.Add(9);
                Display.Text += 9;
            } else if (secondSum)
            {
                secondNumberNeeded = true;
                secondNumber.Add(9);
                Display.Text += 9;
            } else
            {

            }
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            if (firstSum)
            {
                oneTimeUse = true;
                firstNumber.Add(0);
                Display.Text += 0;
            } else if (secondSum)
            {
                secondNumberNeeded = true;
                secondNumber.Add(0);
                Display.Text += 0;
            } else
            {

            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            firstSum = true;
            oneTimeUse = false;

            secondNumberNeeded = false;

            firstNumber.Clear();
            secondNumber.Clear();
            Display.Text = "";

            MakeOperationsFalse();
        }

        private void Backspace_Click(object sender, EventArgs e)
        {
            if (Display.TextLength > 0)
            {
                if (firstSum)
                {
                    firstNumber.Remove(1);
                    Display.Text = Display.Text.Substring(0, (Display.TextLength - 1));
                    Display.Text = "Hej";
                } else if (secondNumber.Count > 0)
                {
                    secondNumber.Remove(1);
                    Display.Text = Display.Text.Substring(0, (Display.TextLength - 1));
                } else
                {
                    Display.Text = Display.Text.Substring(0, (Display.TextLength - 3));
                    firstSum = true;
                    secondSum = false;
                    MakeOperationsFalse();
                }
            }
            else
            {
                
            }
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            if (oneTimeUse)
            {
                oneTimeUse = false;

                firstSum = false;
                secondSum = true;
                Display.Text += "+";

                additionSums = true;
            } else
            {

            }
            
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            if (oneTimeUse)
            {
                oneTimeUse = false;

                firstSum = false;
                secondSum = true;
                Display.Text += "-";

                subtraktSums = true;
            } else
            {

            }
        }

        private void Times_Click(object sender, EventArgs e)
        {
            if (oneTimeUse)
            {
                oneTimeUse = false;

                firstSum = false;
                secondSum = true;
                Display.Text += "*";

                timesSums = true;
            } else
            {

            }
        }

        private void Divided_Click(object sender, EventArgs e)
        {
            if (oneTimeUse)
            {
                oneTimeUse = false;

                firstSum = false;
                secondSum = true;
                Display.Text += "/";

                divideSums = true;
            } else
            {

            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if(!firstSum && secondSum && secondNumberNeeded)
            {
                string firstNumberString = string.Join("", firstNumber.ToArray());
                string secondNumberString = string.Join("", secondNumber.ToArray());

                float firstNumberParsed = float.Parse(firstNumberString);
                float secondNumberParsed = float.Parse(secondNumberString);

                secondSum = false;
                firstSum = true;
                oneTimeUse = true;

                if (additionSums)
                {
                    Display.Text = $"{firstNumberParsed + secondNumberParsed}";
                    float newNumberOne = (firstNumberParsed + secondNumberParsed);

                    firstNumber.Clear();
                    secondNumber.Clear();

                    firstNumber.Add(newNumberOne);
                    MakeOperationsFalse();
                }
                else if (subtraktSums)
                {
                    Display.Text = $"{firstNumberParsed - secondNumberParsed}";
                    float newNumberOne = (firstNumberParsed - secondNumberParsed);

                    firstNumber.Clear();
                    secondNumber.Clear();

                    firstNumber.Add(newNumberOne);
                    MakeOperationsFalse();
                }
                else
                {
                    if (timesSums)
                    {
                        Display.Text = $"{firstNumberParsed * secondNumberParsed}";
                        float newNumberOne = (firstNumberParsed * secondNumberParsed);

                        firstNumber.Clear();
                        secondNumber.Clear();

                        firstNumber.Add(newNumberOne);
                        MakeOperationsFalse();
                    }
                    else if (divideSums)
                    {
                        Display.Text = $"{firstNumberParsed / secondNumberParsed}";
                        float newNumberOne = (firstNumberParsed / secondNumberParsed);

                        firstNumber.Clear();
                        secondNumber.Clear();

                        firstNumber.Add(newNumberOne);
                        MakeOperationsFalse();
                    }
                    else
                    {

                    }
                }
            } else
            {

            }
        }
           
        void MakeOperationsFalse()
        {
            additionSums = false;
            subtraktSums = false;
            timesSums = false;
            divideSums = false;
        }

    }
}
