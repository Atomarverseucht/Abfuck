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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DeFormIschGelade(object sender, EventArgs e)
        {
            Abfuck abfuck = new Abfuck();
            abfuck.Show();
        }

        private void amogusTimer_Tick(object sender, EventArgs e)
        {
            amogusTimer.Enabled = false;
            Form1.ActiveForm.Hide();
        }
    }
}
