using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace AutoSimulator
{
    public partial class Form1 : Form
    {
        Autos auto = null;
        public Form1()
        {
            InitializeComponent();
            comboBox1.DisplayMember = "CarName";

        }
        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            auto = comboBox1.SelectedItem as Autos;
            update();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(new Autos(200, "Traktor"));
            comboBox1.Items.Add(new Autos(400, "Porsche 911"));
            comboBox1.Items.Add(new Autos(700, "Alpha Romero"));
        }


        public void update()
        {
            if(auto.istMotorGestartet == 0)
            {
                lbl_Status.Text = "Off";
            }
            lbl_speed.Text = auto.aktuelleGeschwindikeit.ToString();
            label3.Text = auto.akutellerGang.ToString();
            label2.Text = auto.Ps.ToString();
        }
        private void btn_on_Click_1(object sender, EventArgs e)
        {
            if(auto != null) { 
            SoundPlayer soundPlayer = new SoundPlayer("Car_engine_start_sound_effect.wav");
            soundPlayer.Play();
            lbl_Status.Text = "On";
            auto.istMotorGestartet = 1;
            }
        }
        private void btn_Honk_Click(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer("Hupen_Autohupe_horn_car_Sound_Gerausche_noise_Audio.wav");
            soundPlayer.Play();
        }
        private void button2_MouseHover(object sender, EventArgs e)
        {
            if (auto != null)
            {
                auto.speed();

                lbl_speed.Text = auto.aktuelleGeschwindikeit.ToString();
                auto.gaenge();
                label3.Text = auto.akutellerGang.ToString();
                button2.Visible = false;
                button2.Visible = true;
            }
        }
        private void btn_off_Click(object sender, EventArgs e)
        {
            lbl_Status.Text = "Off";
            auto.istMotorGestartet = 0;

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            if (auto != null)
            {
                auto.bremsen();
                lbl_speed.Text = auto.aktuelleGeschwindikeit.ToString();
                auto.gaenge();
                label3.Text = auto.akutellerGang.ToString();
                button1.Visible = false;
                button1.Visible = true;
            }
        }
    }
}
