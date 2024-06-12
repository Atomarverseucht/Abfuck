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
    public partial class Abfuck : Form
    {
        public Abfuck()
        {
            InitializeComponent();
        }

        private void VergissEsEinfachDuVerdammterHurensohn_Click(object sender, EventArgs e)
        {

        }

        private void Abfuck_Load(object sender, EventArgs e)
        {
            //hoverArea.FlatStyle = FlatStyle.Flat;
            //hoverArea.FlatAppearance.BorderSize = 0;
            //hoverArea.UseVisualStyleBackColor = false;
            randomButton();

        }

        private void Abfuck_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!Amogus.neustartBlock)
            {
            Abfuck abfuck = new Abfuck();
            abfuck.Show();
            }
        }

        private void randomButton()
        {
            Random rand = new Random();
            int boundary = 75;
            int randSX = rand.Next(150, this.Size.Width - 1) / 5;
            int randSY = rand.Next(100, this.Size.Height) / 5;
            int randPX = rand.Next(1, this.Size.Width - randSX);
            int randPY = rand.Next(1,this.Size.Height - randSY);

            trollButton.Width = randSX;
            trollButton.Height = randSY;
            trollButton.Location = new Point(randPX, randPY);
            //hoverArea.Location = new Point(randPX - boundary, randPY - boundary);
            //hoverArea.Width = randSX + 2 * boundary;
            //hoverArea.Height = randSY + 2*boundary;
            trollButton.Show();
            Amogus.anzahlButtonTeleports++;
        }

        private void trollButton_Click(object sender, EventArgs e)
        {
            Abfuck2 abfuck2 = new Abfuck2();
            abfuck2.Show();
            Amogus.neustartBlock = true;
            this.Close();
            Amogus.neustartBlock = false;
        }

        private void trollButton_MouseMove(object sender, MouseEventArgs e)
        {
            if (new Random().Next(25) != 0)
            {
                trollButton.Hide();
                randomButton();
            }
            
        }
    }
}
