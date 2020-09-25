using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Crimson;
            button1.ForeColor = Color.White;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = SystemColors.Control;
            button1.ForeColor = Color.Black;
            button2.BackColor = SystemColors.Control;
            button2.ForeColor = Color.Black;
            button3.BackColor = SystemColors.Control;
            button3.ForeColor = Color.Black;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.BackColor = Color.Crimson;
            button2.ForeColor = Color.White;
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.BackColor = Color.Crimson;
            button3.ForeColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dateTimePicker1.Value = dateTimePicker1.Value.AddMonths(1);
            //textBox3.Text = dateTimePicker1.Text;
            try
            {
                double summa = Convert.ToDouble(textBox1.Text);
                double pervVznos = Convert.ToDouble(textBox2.Text);
                double ostalos = summa - pervVznos;
                double procent = Convert.ToDouble(textBox4.Text);
                procent = procent / 1200;
                double srok = Convert.ToDouble(comboBox1.SelectedIndex);

                

                double rezult;
                double rezult_dif;
                double Pereplata;

                if (srok >= 0 && srok <= 4 && summa!=null && pervVznos!=null)
                {
                    double istSrok = (srok + 1) * 12;
                    if (radioButton1.Checked)
                    {
                        rezult = summa*(procent * Math.Pow(1 + procent, istSrok)) / (Math.Pow(1 + procent, istSrok) - 1);
                        Pereplata = Math.Round(istSrok * rezult - summa, 2);

                        textBox3.Text = Math.Round(rezult, 2).ToString();
                        textBox5.Text = Pereplata.ToString();
                    }
                    else
                    {
                        rezult = ostalos;
                        rezult_dif = rezult;
                        double ezemPlat = ostalos / istSrok;
                        for (int i = 1; i<=Convert.ToInt64(istSrok); i++)
                        {
                            dateTimePicker1.Value = dateTimePicker1.Value.AddMonths(1);
                            rezult_dif = rezult_dif - ezemPlat;
                            double platez = rezult_dif * procent + ezemPlat;
                            dataGridView1.Rows.Add(dateTimePicker1.Text, platez, rezult - platez);

                        }
                    }
                }
                else
                {

                }
            }
            catch(Exception q)
            {

            }         
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            label5.Visible = true;
            label7.Visible = true;
            textBox3.Visible = true;
            textBox5.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            label5.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
            textBox3.Visible = false;
            textBox5.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                double summa = Convert.ToDouble(textBox1.Text);
                double pervVznos = Convert.ToDouble(textBox2.Text);
                double ostalos = summa - pervVznos;
                double procent = Convert.ToDouble(textBox4.Text);
                procent = procent / 1200;
                double srok = Convert.ToDouble(comboBox1.SelectedIndex);



                double rezult;
                double rezult_dif;
                double Pereplata;

                if (srok >= 0 && srok <= 4 && summa != null && pervVznos != null)
                {
                    double istSrok = (srok + 1) * 12;
                    if (radioButton1.Checked)
                    {
                        rezult = summa * (procent * Math.Pow(1 + procent, istSrok)) / (Math.Pow(1 + procent, istSrok) - 1);
                        Pereplata = Math.Round(istSrok * rezult - summa, 2);

                        textBox3.Text = Math.Round(rezult, 2).ToString();
                        textBox5.Text = Pereplata.ToString();
                    }
                    else
                    {
                        rezult = ostalos;
                        rezult_dif = rezult;
                        double ezemPlat = ostalos / istSrok;
                        for (int i = 1; i <= Convert.ToInt64(istSrok); i++)
                        {
                            dateTimePicker1.Value = dateTimePicker1.Value.AddMonths(1);
                            rezult_dif = rezult_dif - ezemPlat;
                            double platez = Math.Round(rezult_dif * procent + ezemPlat, 2);
                            rezult -= Math.Round(platez, 2);
                            dataGridView1.Rows.Add(dateTimePicker1.Text, platez, rezult);
                        }

                    }
                }
                else
                {

                }
            }
            catch (Exception q)
            {

            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox1.Text = "";
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
