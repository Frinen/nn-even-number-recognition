using pr1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr1
{
    public partial class Form1 : Form
    {
        
        List<Sensor> sensors;
        Net nNet;
        int teta;
        Random rnd;
        public Form1()
        {
            rnd = new Random();
            InitializeComponent();
            sensors = new List<Sensor>();
            for (int i=0;i<15;i++)
            {
                sensors.Add(new Sensor());
                
            }
            nNet = new Net();
            teta = rnd.Next(3000);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            TrainModel TM = new TrainModel();
            nNet.Train(TM.Numbers);
         /*   int S = 0;
            foreach (var sensor in sensors)
            {
                S += sensor.Weight * Convert.ToInt32(sensor.Input);
            }
            bool y = S >= teta;
            while (y!=IsEven) 
            {
                string s="";
                label1.Text= $"{teta} {S}";
                foreach (var sensor in sensors)
                {
                    s+=($"[{sensor.Input} {sensor.Weight}]");
                }
                label2.Text=s;
                if (Convert.ToInt32(y) < Convert.ToInt32(IsEven))
                {
                    S = 0;
                    foreach (var sensor in sensors)
                    {
                        sensor.Weight+=Convert.ToInt32(sensor.Input);
                        S += sensor.Weight * Convert.ToInt32(sensor.Input);
                    }
                }
                if (Convert.ToInt32(y) > Convert.ToInt32(IsEven))
                {
                    S = 0;
                    foreach (var sensor in sensors)
                    {
                        sensor.Weight -= Convert.ToInt32(sensor.Input);
                        S += sensor.Weight * Convert.ToInt32(sensor.Input);
                    }
                }
                y = S >= teta;

            };*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sensors[0].Input == 0)
            {
                button1.BackColor = Color.DarkBlue;
                sensors[0].Input = 1;
            }
            else
            {
                button1.BackColor = Color.White;
                sensors[0].Input = 0;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sensors[1].Input == 0)
            {
                button2.BackColor = Color.DarkBlue;
                sensors[1].Input = 1;
            }
            else
            {
                button2.BackColor = Color.White;
                sensors[1].Input = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (sensors[2].Input == 0)
            {
                button3.BackColor = Color.DarkBlue;
                sensors[2].Input = 1;
            }
            else
            {
                button3.BackColor = Color.White;
                sensors[2].Input = 0;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (sensors[3].Input == 0)
            {
                button4.BackColor = Color.DarkBlue;
                sensors[3].Input = 1;
            }
            else
            {
                button4.BackColor = Color.White;
                sensors[3].Input = 0;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (sensors[4].Input == 0)
            {
                button5.BackColor = Color.DarkBlue;
                sensors[4].Input = 1;
            }
            else
            {
                button5.BackColor = Color.White;
                sensors[4].Input = 0;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (sensors[5].Input == 0)
            {
                button6.BackColor = Color.DarkBlue;
                sensors[5].Input = 1;
            }
            else
            {
                button6.BackColor = Color.White;
                sensors[5].Input = 0;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (sensors[6].Input == 0)
            {
                button7.BackColor = Color.DarkBlue;
                sensors[6].Input = 1;
            }
            else
            {
                button7.BackColor = Color.White;
                sensors[6].Input = 0;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (sensors[7].Input == 0)
            {
                button8.BackColor = Color.DarkBlue;
                sensors[7].Input = 1;
            }
            else
            {
                button8.BackColor = Color.White;
                sensors[7].Input = 0;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (sensors[8].Input == 0)
            {
                button9.BackColor = Color.DarkBlue;
                sensors[8].Input = 1;
            }
            else
            {
                button9.BackColor = Color.White;
                sensors[8].Input = 0;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (sensors[9].Input == 0)
            {
                button10.BackColor = Color.DarkBlue;
                sensors[9].Input = 1;
            }
            else
            {
                button10.BackColor = Color.White;
                sensors[9].Input = 0;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (sensors[10].Input == 0)
            {
                button11.BackColor = Color.DarkBlue;
                sensors[10].Input = 1;
            }
            else
            {
                button11.BackColor = Color.White;
                sensors[10].Input = 0;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (sensors[11].Input == 0)
            {
                button12.BackColor = Color.DarkBlue;
                sensors[11].Input = 1;
            }
            else
            {
                button12.BackColor = Color.White;
                sensors[11].Input = 0;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (sensors[12].Input == 0)
            {
                button13.BackColor = Color.DarkBlue;
                sensors[12].Input = 1;
            }
            else
            {
                button13.BackColor = Color.White;
                sensors[12].Input = 0;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (sensors[13].Input == 0)
            {
                button14.BackColor = Color.DarkBlue;
                sensors[13].Input = 1;
            }
            else
            {
                button14.BackColor = Color.White;
                sensors[13].Input = 0;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (sensors[14].Input == 0)
            {
                button15.BackColor = Color.DarkBlue;
                sensors[14].Input = 1;
            }
            else
            {
                button15.BackColor = Color.White;
                sensors[14].Input = 0;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            /* int S = 0;
             foreach (var sensor in sensors)
             {
                 S += sensor.Weight * Convert.ToInt32(sensor.Input);
             }
             bool y = S >= teta;
             checkBox2.Checked = y;*/
            checkBox2.Checked = nNet.Check(sensors);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            teta = rnd.Next(1000);
        }
    }
}
