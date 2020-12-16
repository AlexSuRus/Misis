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
    public partial class Form1 : Form
    {

     

        public Form1()
        {
            InitializeComponent();
            MaximizeBox = false;
            ControlBox = false;
    //        Data.playerMusic.SoundLocation = "Cowboy Bebop.wav";
   //         Data.playerMusic.Play();
        }

        private void exitB_Click(object sender, EventArgs e)
        {
           
                DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите закрыть игру?",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
                Application.Exit();
            
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }
       
        private void Settingsb_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }

        private void Startb_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
        }
    }
}
