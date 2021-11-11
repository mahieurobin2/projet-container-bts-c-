using containers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{

    public partial class Form1 : Form
    {
        private BDD bdd;
        public Form1()
        {
            InitializeComponent();
            bdd = new BDD();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object Textbox, EventArgs e)
        {
            try
            {
                int value = Convert.ToInt32(textBox1.Text);
                if (!(value <= 9 && value > 0))
                {
                    Console.WriteLine("Vous devez saisir un une valeur entre 0 et 9");
                }
            }
            catch (Exception ex)
            {
                label13.Text = "Vous devez saisir un chiffre";
            }
        }


        private void TextBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int value = Convert.ToInt32(textBox1.Text);
                if (!(value <= 9 && value > 0))
                {
                    Console.WriteLine("Vous devez saisir un une valeur entre 0 et 9");
                }
            }
            catch (Exception ex)
            {
                label13.Text = "Vous devez saisir un chiffre";
            }
        }
        public int valu { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string Dimension = "";
                string BIC_CODE = "";
                int Zone = 0;
                int X = 0;
                int Y = 0;
                int Z = 0;

                if (radioButton1.Checked)
                {
                    Dimension = radioButton1.Text;
                }

                else if (radioButton2.Checked)
                {
                    Dimension = radioButton2.Text;
                }
                BIC_CODE = this.textBox1.Text;
                X = int.Parse(this.textBox4.Text);
                Y = int.Parse(this.textBox5.Text);
                Z = int.Parse(this.textBox3.Text);
                Zone = int.Parse(this.textBox2.Text);
                {
                    if (Zone >= 0 && Zone <= 9)
                    {
                        if (X >= 0 && X <= 5)
                        {
                            if (Y >= 0 && Y <= 9)
                            {
                                if (Z >= 0 && Z <= 5)
                                {
                                    bdd.ADD_N(Dimension, BIC_CODE);
                                    label15.Text = "le container a ete placé";
                                }
                                else label15.Text = "erreur sur Z";
                            }
                            else label15.Text = "erreur sur Y";
                        }
                        else label15.Text = "erreur sur X";
                    }
                    else label15.Text = "erreur sur Zone";

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                string Dimension = "";
                string BIC_CODE = "";
                int Zone = 0;
                int X = 0;
                int Y = 0;
                int Z = 0;

                if (radioButton1.Checked)
                {
                    Dimension = radioButton1.Text;
                }

                else if (radioButton2.Checked)
                {
                    Dimension = radioButton2.Text;
                }
                BIC_CODE = this.textBox1.Text;
                X = int.Parse(this.textBox4.Text);
                Y = int.Parse(this.textBox5.Text);
                Z = int.Parse(this.textBox3.Text);
                Zone = int.Parse(this.textBox2.Text);
                {
                    if (Zone >= 0 && Zone <= 9)
                    {
                        if (X >= 0 && X <= 5)
                        {
                            if (Y >= 0 && Y <= 9)
                            {
                                if (Z >= 0 && Z <= 5)
                                {
                                   bdd.ADD_N(Dimension, BIC_CODE);
                                   label15.Text = "le container a ete retiré";
                                }
                                else label15.Text = "erreur sur Z";
                            }
                            else label15.Text = "erreur sur Y";
                        }
                        else label15.Text = "erreur sur X";
                    }
                    else label15.Text = "erreur sur Zone";
                                          
                }
            }


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

}
    }







