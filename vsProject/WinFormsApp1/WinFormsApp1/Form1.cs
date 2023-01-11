using CalculatorLibrary;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int ringStatus = 0;

        Dictionary<string, Color> resistorColors = new Dictionary<string, Color>()
        {
            { "Обрати", SystemColors.ActiveCaption},
            { "Чорний", Color.Black},
            { "Коричневий", Color.Brown},
            { "Червоний", Color.Red},
            { "Помаранчевий", Color.Orange},
            { "Жовтий", Color.Yellow},
            { "Зелений", Color.Green},
            { "Синій", Color.Blue},
            { "Сірий", Color.Gray},
            { "Білий", Color.White},
            { "Фіолетовий", Color.Purple},
            { "Золотий", Color.Gold},
            { "Срібний", Color.Silver},
        };

        public Form1()
        {
            InitializeComponent();
        }


        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ringStatus = 3;

            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox2.BackColor = SystemColors.ActiveCaption;
            pictureBox3.BackColor = SystemColors.ActiveCaption;
            pictureBox4.BackColor = SystemColors.ButtonFace;
            pictureBox5.BackColor = SystemColors.ButtonFace;
            pictureBox6.BackColor = SystemColors.ButtonFace;

            comboBox1.Enabled = true;
            comboBox1.Text = "Обрати";
            comboBox2.Enabled = true;
            comboBox2.Text = "Обрати";
            comboBox3.Enabled = true;
            comboBox3.Text = "Обрати";
            comboBox4.Enabled = false;
            comboBox4.Text = "Обрати";
            comboBox5.Enabled = false;
            comboBox5.Text = "Обрати";
            comboBox6.Enabled = false;
            comboBox6.Text = "Обрати";

            label4.Text = "-";
            label5.Text = "-";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            ringStatus= 4;

            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox2.BackColor = SystemColors.ActiveCaption;
            pictureBox3.BackColor = SystemColors.ActiveCaption;
            pictureBox4.BackColor = SystemColors.ActiveCaption;
            pictureBox5.BackColor = SystemColors.ButtonFace;
            pictureBox6.BackColor = SystemColors.ButtonFace;

            comboBox1.Enabled = true;
            comboBox1.Text = "Обрати";
            comboBox2.Enabled = true;
            comboBox2.Text = "Обрати";
            comboBox3.Enabled = true;
            comboBox3.Text = "Обрати";
            comboBox4.Enabled = true;
            comboBox4.Text = "Обрати";
            comboBox5.Enabled = false;
            comboBox5.Text = "Обрати";
            comboBox6.Enabled = false;
            comboBox6.Text = "Обрати";

            label4.Text = "-";
            label5.Text = "-";
        }


        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            ringStatus= 5;

            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox2.BackColor = SystemColors.ActiveCaption;
            pictureBox3.BackColor = SystemColors.ActiveCaption;
            pictureBox4.BackColor = SystemColors.ActiveCaption;
            pictureBox5.BackColor = SystemColors.ActiveCaption;
            pictureBox6.BackColor = SystemColors.ButtonFace;

            comboBox1.Enabled = true;
            comboBox1.Text = "Обрати";
            comboBox2.Enabled = true;
            comboBox2.Text = "Обрати";
            comboBox3.Enabled = true;
            comboBox3.Text = "Обрати";
            comboBox4.Enabled = true;
            comboBox4.Text = "Обрати";
            comboBox5.Enabled = true;
            comboBox5.Text = "Обрати";
            comboBox6.Enabled = false;
            comboBox6.Text = "Обрати";

            label4.Text = "-";
            label5.Text = "-";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            ringStatus= 6;

            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox2.BackColor = SystemColors.ActiveCaption;
            pictureBox3.BackColor = SystemColors.ActiveCaption;
            pictureBox4.BackColor = SystemColors.ActiveCaption;
            pictureBox5.BackColor = SystemColors.ActiveCaption;
            pictureBox6.BackColor = SystemColors.ActiveCaption;


            comboBox1.Enabled = true;
            comboBox1.Text = "Обрати";
            comboBox2.Enabled = true;
            comboBox2.Text = "Обрати";
            comboBox3.Enabled = true;
            comboBox3.Text = "Обрати";
            comboBox4.Enabled = true;
            comboBox4.Text = "Обрати";
            comboBox5.Enabled = true;
            comboBox5.Text = "Обрати";
            comboBox6.Enabled = true;
            comboBox6.Text = "Обрати";

            label4.Text = "-";
            label5.Text = "-";
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.BackColor = resistorColors[comboBox1.Text];

            if (ringStatus == 3)
            {
                if (comboBox1.Text != "Обрати" && comboBox2.Text != "Обрати" && comboBox3.Text != "Обрати")
                {
                    calculate();
                }
            }
            else if (ringStatus == 4)
            {
                if (comboBox1.Text != "Обрати" && comboBox2.Text != "Обрати" && comboBox3.Text != "Обрати" && comboBox4.Text != "Обрати")
                {
                    calculate();
                }
            }
            else if (ringStatus == 5)
            {
                if (comboBox1.Text != "Обрати" && comboBox2.Text != "Обрати" && comboBox3.Text != "Обрати" && comboBox4.Text != "Обрати" && comboBox5.Text != "Обрати")
                {
                    calculate();
                }
            }
            else if (ringStatus == 6)
            {
                if (comboBox1.Text != "Обрати" && comboBox2.Text != "Обрати" && comboBox3.Text != "Обрати" && comboBox4.Text != "Обрати" && comboBox5.Text != "Обрати" && comboBox6.Text != "Обрати")
                {
                    calculate();
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox2.BackColor = resistorColors[comboBox2.Text];
            if (ringStatus == 3)
            {
                if (comboBox1.Text != "Обрати" && comboBox2.Text != "Обрати" && comboBox3.Text != "Обрати")
                {
                    calculate();
                }
            }
            else if (ringStatus == 4)
            {
                if (comboBox1.Text != "Обрати" && comboBox2.Text != "Обрати" && comboBox3.Text != "Обрати" && comboBox4.Text != "Обрати")
                {
                    calculate();
                }
            }
            else if (ringStatus == 5)
            {
                if (comboBox1.Text != "Обрати" && comboBox2.Text != "Обрати" && comboBox3.Text != "Обрати" && comboBox4.Text != "Обрати" && comboBox5.Text != "Обрати")
                {
                    calculate();
                }
            }
            else if (ringStatus == 6)
            {
                if (comboBox1.Text != "Обрати" && comboBox2.Text != "Обрати" && comboBox3.Text != "Обрати" && comboBox4.Text != "Обрати" && comboBox5.Text != "Обрати" && comboBox6.Text != "Обрати")
                {
                    calculate();
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox3.BackColor = resistorColors[comboBox3.Text];
            if (ringStatus == 3)
            {
                if (comboBox1.Text != "Обрати" && comboBox2.Text != "Обрати" && comboBox3.Text != "Обрати")
                {
                    calculate();
                }
            }
            else if (ringStatus == 4)
            {
                if (comboBox1.Text != "Обрати" && comboBox2.Text != "Обрати" && comboBox3.Text != "Обрати" && comboBox4.Text != "Обрати")
                {
                    calculate();
                }
            }
            else if (ringStatus == 5)
            {
                if (comboBox1.Text != "Обрати" && comboBox2.Text != "Обрати" && comboBox3.Text != "Обрати" && comboBox4.Text != "Обрати" && comboBox5.Text != "Обрати")
                {
                    calculate();
                }
            }
            else if (ringStatus == 6)
            {
                if (comboBox1.Text != "Обрати" && comboBox2.Text != "Обрати" && comboBox3.Text != "Обрати" && comboBox4.Text != "Обрати" && comboBox5.Text != "Обрати" && comboBox6.Text != "Обрати")
                {
                    calculate();
                }
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox4.BackColor = resistorColors[comboBox4.Text];
            if (ringStatus == 3)
            {
                if (comboBox1.Text != "Обрати" && comboBox2.Text != "Обрати" && comboBox3.Text != "Обрати")
                {
                    calculate();
                }
            }
            else if (ringStatus == 4)
            {
                if (comboBox1.Text != "Обрати" && comboBox2.Text != "Обрати" && comboBox3.Text != "Обрати" && comboBox4.Text != "Обрати")
                {
                    calculate();
                }
            }
            else if (ringStatus == 5)
            {
                if (comboBox1.Text != "Обрати" && comboBox2.Text != "Обрати" && comboBox3.Text != "Обрати" && comboBox4.Text != "Обрати" && comboBox5.Text != "Обрати")
                {
                    calculate();
                }
            }
            else if (ringStatus == 6)
            {
                if (comboBox1.Text != "Обрати" && comboBox2.Text != "Обрати" && comboBox3.Text != "Обрати" && comboBox4.Text != "Обрати" && comboBox5.Text != "Обрати" && comboBox6.Text != "Обрати")
                {
                    calculate();
                }
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox5.BackColor = resistorColors[comboBox5.Text];
            if (ringStatus == 3)
            {
                if (comboBox1.Text != "Обрати" && comboBox2.Text != "Обрати" && comboBox3.Text != "Обрати")
                {
                    calculate();
                }
            }
            else if (ringStatus == 4)
            {
                if (comboBox1.Text != "Обрати" && comboBox2.Text != "Обрати" && comboBox3.Text != "Обрати" && comboBox4.Text != "Обрати")
                {
                    calculate();
                }
            }
            else if (ringStatus == 5)
            {
                if (comboBox1.Text != "Обрати" && comboBox2.Text != "Обрати" && comboBox3.Text != "Обрати" && comboBox4.Text != "Обрати" && comboBox5.Text != "Обрати")
                {
                    calculate();
                }
            }
            else if (ringStatus == 6)
            {
                if (comboBox1.Text != "Обрати" && comboBox2.Text != "Обрати" && comboBox3.Text != "Обрати" && comboBox4.Text != "Обрати" && comboBox5.Text != "Обрати" && comboBox6.Text != "Обрати")
                {
                    calculate();
                }
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox6.BackColor = resistorColors[comboBox6.Text];
            if (ringStatus == 3)
            {
                if (comboBox1.Text != "Обрати" && comboBox2.Text != "Обрати" && comboBox3.Text != "Обрати")
                {
                    calculate();
                }
            }
            else if (ringStatus == 4)
            {
                if (comboBox1.Text != "Обрати" && comboBox2.Text != "Обрати" && comboBox3.Text != "Обрати" && comboBox4.Text != "Обрати")
                {
                    calculate();
                }
            }
            else if (ringStatus == 5)
            {
                if (comboBox1.Text != "Обрати" && comboBox2.Text != "Обрати" && comboBox3.Text != "Обрати" && comboBox4.Text != "Обрати" && comboBox5.Text != "Обрати")
                {
                    calculate();
                }
            }
            else if (ringStatus == 6)
            {
                if (comboBox1.Text != "Обрати" && comboBox2.Text != "Обрати" && comboBox3.Text != "Обрати" && comboBox4.Text != "Обрати" && comboBox5.Text != "Обрати" && comboBox6.Text != "Обрати")
                {
                    calculate();
                }
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(label4.Text + "    Om");
        }

        public void calculate()
        {
            string[][] colors = {
                new string[] { comboBox1.Text, comboBox2.Text, comboBox3.Text },
                new string[]{ comboBox1.Text, comboBox2.Text, comboBox3.Text, comboBox4.Text },
                new string[]{ comboBox1.Text, comboBox2.Text, comboBox3.Text, comboBox4.Text, comboBox5.Text },
                new string[]{ comboBox1.Text, comboBox2.Text, comboBox3.Text, comboBox4.Text, comboBox5.Text, comboBox6.Text },
            };

            Resistor resistor = new(ringStatus, colors[ringStatus - 3]);
            resistor.CalculateResistance();

            label4.Text = Convert.ToString(resistor.GetResistance()) + "Ом +- " + Convert.ToString(resistor.GetTolerance()) + "%";
            if (ringStatus == 6)
            {
                label5.Text = Convert.ToString(resistor.GetTempK());
            }
        }

        
    }
}