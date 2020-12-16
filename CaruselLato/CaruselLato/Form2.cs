using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaruselLato
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            MaximizeBox = false;
            ControlBox = false;
        }
        Form1 f1 = new Form1();
        bool musicIsOn = true;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            f1.Show();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Суриков Александр Сергеевич, БПМ-20-2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Data.playerMusic.SoundLocation = "Cowboy Bebop.wav";
            if (musicIsOn == true) { Data.playerMusic.Stop(); musicIsOn = false; } else { Data.playerMusic.Play(); musicIsOn = true; }
        }
    }
}
