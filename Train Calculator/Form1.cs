using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Train_Calculator
{
    public partial class Form1 : Form
    {
        int temp1 = 0;
        int temp2 = 0;
        int op = 0;
        int result = 0;
        bool resultFlag = false;
        public Form1()
        {
            InitializeComponent();

            //Makes the textbox focused on startup
            this.ActiveControl = numberOne;
            results.Text = null;
            numberOne.Focus();
        }

        private void addition_Click(object sender, EventArgs e)
        {
            if(numberOne != null)
            {
                temp1 = Int32.Parse(numberOne.Text);
                op = 1;
                numberOne.Text = null;
                numberOne.Focus();
            }
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            if (numberOne != null)
            {
                temp1 = Int32.Parse(numberOne.Text);
                op = 2;
                numberOne.Text = null;
                numberOne.Focus();
            }
        }

        private void division_Click(object sender, EventArgs e)
        {
            if (numberOne != null)
            {
                temp1 = Int32.Parse(numberOne.Text);
                op = 3;
                numberOne.Text = null;
                numberOne.Focus();
            }
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            if (numberOne != null)
            {
                temp1 = Int32.Parse(numberOne.Text);
                op = 4;
                numberOne.Text = null;
                numberOne.Focus();
            }
        }

        private void equals_Click(object sender, EventArgs e)
        {
            temp2 = Int32.Parse(numberOne.Text);
            switch(op)
            {
                case 1:
                    numberOne.Text = (temp1 + temp2).ToString();
                    break;
                case 2:
                    numberOne.Text = (temp1 - temp2).ToString();
                    break;
                case 3:
                    if(temp2 > 0)
                    {
                        numberOne.Text = (temp1 / temp2).ToString();
                    }
                    break;
                case 4:
                    numberOne.Text = (temp1 * temp2).ToString();
                    break;
                default:
                    break;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            temp1 = 0;
            temp2 = 0;
            numberOne.Text = null;
            result = 0;
            results.Text = null;
            numberOne.Focus();
            resultFlag = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Allows for using keyboard input for calculator tools.
        private void numberOne_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    {
                        temp2 = Int32.Parse(numberOne.Text);
                        switch (op)
                        {
                            case 1:
                                result = (temp1 + temp2);
                                temp1 = result;
                                setResults();
                                break;
                            case 2:
                                result = (temp1 - temp2);
                                temp1 = result;
                                setResults();
                                break;
                            case 3:
                                if (temp2 > 0)
                                {
                                    result = (temp1 / temp2);
                                    temp1 = result;
                                    setResults();
                                } else
                                {
                                    MessageBox.Show("Cannot Divide by zero.");
                                }
                                break;
                            case 4:
                                result = (temp1 * temp2);
                                temp1 = result;
                                setResults();
                                break;
                            default:
                                break;
                        }
                        numberOne.Select(numberOne.Text.Length, 0);
                        resultFlag = true;
                    }
                    break;
                case Keys.Add:
                    if (numberOne != null)
                    {
                        if(!resultFlag) { temp1 = Int32.Parse(numberOne.Text); }
                        op = 1;
                        numberOne.Text = null;
                        numberOne.Focus();
                    }
                    break;
                case Keys.Subtract:
                    if (numberOne != null)
                    {
                        if (!resultFlag) { temp1 = Int32.Parse(numberOne.Text); }
                        op = 2;
                        numberOne.Text = null;
                        numberOne.Focus();
                    }
                    break;
                case Keys.Divide:
                    if (numberOne != null)
                    {
                        if (!resultFlag) { temp1 = Int32.Parse(numberOne.Text); }
                        op = 3;
                        numberOne.Text = null;
                        numberOne.Focus();
                    }
                    break;
                case Keys.Multiply:
                    if (numberOne != null)
                    {
                        if (!resultFlag) { temp1 = Int32.Parse(numberOne.Text); }
                        op = 4;
                        numberOne.Text = null;
                        numberOne.Focus();
                    }
                    break;
                default:
                    break;

            }
        }

        //Maintains that only numbers can be typed into the textbox of the calculator
        private void numberOne_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(numberOne.Text, "[^0-9]"))
            {
                numberOne.Text = numberOne.Text.Remove(numberOne.Text.Length - 1);

                //Moves the cursor to the end of the text in the textbox
                numberOne.Select(numberOne.Text.Length, 0);
            }
        }

        private void setResults()
        {
            results.Text = result.ToString() + Environment.NewLine + results.Text;
        }
    }
}
