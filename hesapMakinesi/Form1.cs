using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapMakinesi
{
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //değişkenler
        string operation = "default";
        double geçiciT = 0;
        double geçiciÇ = 1;
        double sayı1, sonuc;
        string sürekli;
        bool engel = false;
        bool afterEqual = false;

        private void btn0_Click(object sender, EventArgs e)
        {
            if (afterEqual)
            {
                textBox.Text = "";
                geçiciT = 0;
                geçiciÇ = 1;
                sürekli = "0";
                operation = "default";
            }
            textBox.Text = textBox.Text + "0";
            sürekli += '0';
            engel = false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (afterEqual)
            {
                textBox.Text = "";
                geçiciT = 0;
                geçiciÇ = 1;
                sürekli = "0";
                operation = "default";
            }
            textBox.Text = textBox.Text + "1";
            sürekli += '1';
            engel = false;

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (afterEqual)
            {
                textBox.Text = "";
                geçiciT = 0;
                geçiciÇ = 1;
                sürekli = "0";
                operation = "default";
            }
            textBox.Text = textBox.Text + "2";
            sürekli += '2';
            engel = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (afterEqual)
            {
                textBox.Text = "";
                geçiciT = 0;
                geçiciÇ = 1;
                sürekli = "0";
                operation = "default";
            }
            textBox.Text = textBox.Text + "3";
            sürekli += '3';
            engel = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (afterEqual)
            {
                textBox.Text = "";
                geçiciT = 0;
                geçiciÇ = 1;
                sürekli = "0";
                operation = "default";
            }
            textBox.Text = textBox.Text + "4";
            sürekli += '4';
            engel = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (afterEqual)
            {
                textBox.Text = "";
                geçiciT = 0;
                geçiciÇ = 1;
                sürekli = "0";
                operation = "default";
            }
            textBox.Text = textBox.Text + "5";
            sürekli += '5';
            engel = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (afterEqual)
            {
                textBox.Text = "";
                geçiciT = 0;
                geçiciÇ = 1;
                sürekli = "0";
                operation = "default";
            }
            textBox.Text = textBox.Text + "6";
            sürekli += '6';
            engel = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (afterEqual)
            {
                textBox.Text = "";
                geçiciT = 0;
                geçiciÇ = 1;
                sürekli = "0";
                operation = "default";
            }
            textBox.Text = textBox.Text + "7";
            sürekli += '7';
            engel = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (afterEqual)
            {
                textBox.Text = "";
                geçiciT = 0;
                geçiciÇ = 1;
                sürekli = "0";
                operation = "default";
            }
            textBox.Text = textBox.Text + "8";
            sürekli += '8';
            engel = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (afterEqual)
            {
                textBox.Text = "";
                geçiciT = 0;
                geçiciÇ = 1;
                sürekli = "0";
                operation = "default";
            }
            textBox.Text = textBox.Text + "9";
            sürekli += '9';
            engel = false;
        }


        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (engel == false)
            {
                sayı1 = double.Parse(textBox.Text);
                if (operation == "plus" || operation == "default")
                {
                    geçiciT += sayı1;
                    textBox.Text = "";
                    sürekli = "0";
                }
                else if (operation == "minus")
                {
                    if (geçiciT == 0)
                    {
                        sayı1 = double.Parse(textBox.Text);
                        geçiciT += sayı1;
                        textBox.Text = "";
                        sürekli = "0";
                    }
                    else
                    {
                        sayı1 = double.Parse(textBox.Text);
                        geçiciT -= sayı1;
                        textBox.Text = "";
                        sürekli = "0";
                    }
                }
                else if (operation == "multiply")
                {
                    sayı1 = double.Parse(textBox.Text);
                    geçiciÇ *= sayı1;
                    textBox.Text = "";
                    sürekli = "0";
                    geçiciT = geçiciÇ;
                }
                else if (operation == "divide")
                {
                    if (geçiciÇ == 1)
                    {
                        sayı1 = double.Parse(textBox.Text);
                        geçiciÇ *= sayı1;
                        textBox.Text = "";
                        sürekli = "0";
                    }
                    else
                    {
                        sayı1 = double.Parse(textBox.Text);
                        geçiciÇ /= sayı1;
                        textBox.Text = "";
                        sürekli = "0";
                    }
                    geçiciT = geçiciÇ;
                }
                geçiciÇ = geçiciT;
                operation = "plus";
                afterEqual = false;
            }
            engel = true;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (engel == false)
            {
                if (operation == "minus" || operation == "default")
                {
                    if (geçiciT == 0)
                    {
                        sayı1 = double.Parse(textBox.Text);
                        geçiciT += sayı1;
                        textBox.Text = "";
                        sürekli = "0";
                    }
                    else
                    {
                        sayı1 = double.Parse(textBox.Text);
                        geçiciT -= sayı1;
                        textBox.Text = "";
                        sürekli = "0";
                    }
                }
                else if (operation == "plus")
                {
                    sayı1 = double.Parse(textBox.Text);
                    geçiciT += sayı1;
                    textBox.Text = "";
                    sürekli = "0";
                }
                else if (operation == "multiply")
                {
                    sayı1 = double.Parse(textBox.Text);
                    geçiciT *= sayı1;
                    textBox.Text = "";
                    sürekli = "0";
                    geçiciÇ = geçiciT;
                }
                else if (operation == "divide")
                {
                    if (geçiciÇ == 1)
                    {
                        sayı1 = double.Parse(textBox.Text);
                        geçiciÇ *= sayı1;
                        textBox.Text = "";
                        sürekli = "0";
                    }
                    else
                    {
                        sayı1 = double.Parse(textBox.Text);
                        geçiciÇ /= sayı1;
                        textBox.Text = "";
                        sürekli = "0";
                    }
                    geçiciÇ = geçiciT;
                }
                geçiciÇ = geçiciT;
                operation = "minus";
                afterEqual = false;
            }
            engel = true;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (engel == false)
            {
                if (operation == "multiply" || operation == "default")
                {
                    sayı1 = double.Parse(textBox.Text);
                    geçiciÇ *= sayı1;
                    textBox.Text = "";
                    sürekli = "0";
                }
                else if (operation == "plus")
                {
                    sayı1 = double.Parse(textBox.Text);
                    geçiciT += sayı1;
                    textBox.Text = "";
                    sürekli = "0";
                    geçiciÇ = geçiciT;
                }
                else if (operation == "minus")
                {
                    if (geçiciT == 0)
                    {
                        sayı1 = double.Parse(textBox.Text);
                        geçiciT += sayı1;
                        textBox.Text = "";
                        sürekli = "0";
                    }
                    else
                    {
                        sayı1 = double.Parse(textBox.Text);
                        geçiciT -= sayı1;
                        textBox.Text = "";
                        sürekli = "0";
                    }
                    geçiciÇ = geçiciT;
                }
                else if (operation == "divide")
                {
                    if (geçiciÇ == 1)
                    {
                        sayı1 = double.Parse(textBox.Text);
                        geçiciÇ *= sayı1;
                        textBox.Text = "";
                        sürekli = "0";
                    }
                    else
                    {
                        sayı1 = double.Parse(textBox.Text);
                        geçiciÇ /= sayı1;
                        textBox.Text = "";
                        sürekli = "0";
                    }
                }
                geçiciT = geçiciÇ;
                operation = "multiply";
                afterEqual = false;
            }
            engel = true;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (engel == false)
            {
                if (operation == "divide" || operation == "default")
                {
                    if (geçiciÇ == 1)
                    {
                        sayı1 = double.Parse(textBox.Text);
                        geçiciÇ *= sayı1;
                        textBox.Text = "";
                        sürekli = "0";
                    }
                    else
                    {
                        sayı1 = double.Parse(textBox.Text);
                        geçiciÇ /= sayı1;
                        textBox.Text = "";
                        sürekli = "0";
                    }
                }
                else if (operation == "plus")
                {
                    sayı1 = double.Parse(textBox.Text);
                    geçiciT += sayı1;
                    textBox.Text = "";
                    sürekli = "0";
                    geçiciÇ = geçiciT;
                }
                else if (operation == "minus")
                {
                    if (geçiciT == 0)
                    {
                        sayı1 = double.Parse(textBox.Text);
                        geçiciT += sayı1;
                        textBox.Text = "";
                        sürekli = "0";
                    }
                    else
                    {
                        sayı1 = double.Parse(textBox.Text);
                        geçiciT -= sayı1;
                        textBox.Text = "";
                        sürekli = "0";
                    }
                    geçiciÇ = geçiciT;
                }
                else if (operation == "multiply")
                {
                    sayı1 = double.Parse(textBox.Text);
                    geçiciÇ *= sayı1;
                    textBox.Text = "";
                    sürekli = "0";
                }
                geçiciT = geçiciÇ;
                operation = "divide";
                afterEqual = false;
            }
            engel = true;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (operation == "plus")
            {
                if (geçiciT == 0)
                {
                    sonuc += double.Parse(sürekli);
                }
                else
                {
                    sonuc = geçiciT + double.Parse(sürekli);
                }
                textBox.Text = sonuc.ToString();
                geçiciT = 0;
                geçiciÇ = 1;
            }
            if (operation == "minus")
            {
                if (geçiciT == 0)
                {
                    sonuc -= double.Parse(sürekli);
                }
                else
                {
                    sonuc = geçiciT - double.Parse(sürekli);
                }
                textBox.Text = sonuc.ToString();
                geçiciT = 0;
                geçiciÇ = 1;
            }
            if (operation == "multiply")
            {
                if (geçiciÇ == 1)
                {
                    sonuc *= double.Parse(sürekli);
                }
                else
                {
                    sonuc = geçiciÇ * double.Parse(sürekli);
                }
                textBox.Text = sonuc.ToString();
                geçiciÇ = 1;
                geçiciT = 0;
            }
            if (operation == "divide")
            {
                if (geçiciÇ == 1)
                {
                    sonuc /= double.Parse(sürekli);
                }
                else
                {
                    sonuc = geçiciÇ / double.Parse(sürekli);
                }
                textBox.Text = sonuc.ToString();
                geçiciÇ = 1;
                geçiciT = 0;
            }
            afterEqual = true;
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Length != 0)
            {
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1, 1);
            }
            if (sürekli.Length != 0)
            {
                sürekli = sürekli.Remove(sürekli.Length - 1, 1);
            }
            if (geçiciT.ToString().Length != 0)
            {
                string geçiciTtoString = geçiciT.ToString();
                geçiciTtoString = geçiciTtoString.Remove(geçiciTtoString.Length - 1, 1);
            }
            if (geçiciÇ.ToString().Length != 0)
            {
                string geçiciÇtoString = geçiciÇ.ToString();
                geçiciÇtoString = geçiciÇtoString.Remove(geçiciÇtoString.Length - 1, 1);
            }
            afterEqual = false;
            engel = false;
        }

        private void btnAllClear_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            geçiciT = 0;
            geçiciÇ = 1;
            sürekli = "0";
            operation = "default";
            afterEqual = false;
            engel = true;
        }


        private void btnComma_Click(object sender, EventArgs e)
        {
            if (afterEqual)
            {
                textBox.Text = "";
                geçiciT = 0;
                geçiciÇ = 1;
                sürekli = "0";
                operation = "default";
                textBox.Text = "0,";
            }
            else
            {
                if (textBox.Text.Length >0){
                    textBox.Text = textBox.Text + ",";
                    sürekli += ',';
                }
                else
                {
                    textBox.Text = textBox.Text + "0,";
                    sürekli += "0,";
                }
            }
            afterEqual = false;
            engel = true;
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "" && textBox.Text != null)
            {
                if (double.Parse(textBox.Text) != 0)
                {
                    if (textBox.Text[0] == '-')
                    {
                        textBox.Text = textBox.Text.Remove(0, 1);
                    }
                    else if (textBox.Text[0] != '-')
                    {
                        textBox.Text = "-" + textBox.Text;
                    }
                }
            }
            afterEqual = false;
        }
    }
}
