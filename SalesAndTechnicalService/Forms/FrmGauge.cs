using SalesAndTechnicalService.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesAndTechnicalService.Forms
{
    public partial class FrmGauge : Form
    {
        public FrmGauge()
        {
            InitializeComponent();
        }

        Db_TechnicalServiceEntities entities = new Db_TechnicalServiceEntities();

        private void gaugeControl1_Click(object sender, EventArgs e)
        {

        }

        private void FrmGauge_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            arcScaleComponent1.Value += 1;
            if (arcScaleComponent1.Value == 50)
            {
                timer1.Stop();
                timer2.Start();
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            arcScaleComponent1.Value -= 5;
            if (arcScaleComponent1.Value == 0)
            {
                timer2.Stop();
                timer1.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

            arcScaleComponent2.Value += 3;
            if (arcScaleComponent2.Value == 90)
            {
                timer3.Stop();
                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            arcScaleComponent2.Value -= 2;
            if (arcScaleComponent2.Value == 0)
            {
                timer4.Stop();
                timer3.Start();
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            arcScaleComponent3.Value += 10;
            if (arcScaleComponent3.Value == 330)
            {
                timer5.Stop();
                timer6.Start();
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            arcScaleComponent3.Value -= 10;
            if (arcScaleComponent3.Value == 0)
            {
                timer6.Stop();
                timer5.Start();
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            arcScaleComponent4.Value += 12;
            if (arcScaleComponent4.Value == 330)
            {
                timer7.Stop();
                timer8.Start();
            }
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            arcScaleComponent4.Value -= 15;
            if (arcScaleComponent4.Value == 0)
            {
                timer8.Stop();
                timer7.Start();
            }
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            arcScaleComponent5.Value += 10;
            if (arcScaleComponent5.Value == 90)
            {
                timer9.Stop();
                timer10.Start();
            }
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            arcScaleComponent5.Value -= 3;
            if (arcScaleComponent5.Value == 0)
            {
                timer10.Stop();
                timer9.Start();
            }
        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            arcScaleComponent6.Value += 8;
            if (arcScaleComponent6.Value == 180)
            {
                timer11.Stop();
                timer12.Start();
            }
        }

        private void timer12_Tick(object sender, EventArgs e)
        {
            arcScaleComponent6.Value -= 9;
            if (arcScaleComponent6.Value == 0)
            {
                timer12.Stop();
                timer11.Start();
            }
        }
    }
}
