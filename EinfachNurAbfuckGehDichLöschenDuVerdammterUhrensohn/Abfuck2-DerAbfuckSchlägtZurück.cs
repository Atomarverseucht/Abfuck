using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EinfachNurAbfuckGehDichLöschenDuVerdammterUhrensohn
{
    public partial class Abfuck2 : Form
    {
        int tick = 0;
        public Abfuck2()
        {
            InitializeComponent();
        }

        int progressbarModus = 0;
        private void Abfuck2_DerAbfuckSchlägtZurück_Load(object sender, EventArgs e)
        {

        }

        private void Abfuck2_DerAbfuckSchlägtZurück_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!Amogus.neustartBlock)
            {
                Abfuck2 abfuck = new Abfuck2();
                abfuck.Show();
            }
        }

        private void loop_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            tick++; (int d, int h, int min, int s) = TickToTime(tick);
            lbProgress.Text = "Nächstes Level zu " + progressBar.Value + "% geladen!";
            lbProgress.Text += $"\n\nVorrausichtliche Wartezeit = {(random.Next(s) + 2).ToString()} Minuten!";
            
            int value = 0;
            switch (progressbarModus)
            {
                case 0:  
                    int progress = 1;
                    if(progressBar.Value < 100) 
                    { 
                        
                        progress = random.Next(25)-11;
                    }
                    value = progressBar.Value + progress;
                    if (value > 90)
                    {
                        progressbarModus = 1;
                    }
                    break;
                case 1:
                    value = progressBar.Value - random.Next(10);

                    if (progressBar.Value <= 1)
                    {
                        progressbarModus++;
                    }
                    break;
                case 2:
                    value = random.Next(100); 
                    if(value == 99)
                    {
                        progressbarModus++;
                    } break;
                default: 
                    progressbarModus = 0; break;
            }
            if (value >= 0 && value <= 99)
            {
                progressBar.Value = value;
            }
        }

        private void Abfuck2_DerAbfuckSchlägtZurück_SizeChanged(object sender, EventArgs e)
        {
            progressBar.Width = this.Width;
        }
        public (int d, int h, int min, int s) TickToTime(int tick)
        {
            int min = 0;
            int h = 0;
            int d = 0;
            int s = tick / 10;
            if(s >= 60)
            {
                min = s / 60;
                s %= 60;
                if(min >= 60)
                {
                    h = min / 60;
                    min %= 60;
                    if (h >= 24) 
                    {
                        d = h / 24; 
                        h %= 24; 
                    }
                }
            }
            return ( d, min, h, s );
        }
    }
}
