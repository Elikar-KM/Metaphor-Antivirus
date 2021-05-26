using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metaphor_Antivirus
{
    public partial class RamAndCpuUsage : Form
    {
        public RamAndCpuUsage()
        {
            InitializeComponent();
        }

        private void RamAndCpuUsage_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            float cpu = pCPU.NextValue();
            float ram = pRAM.NextValue();
            ProgressBarCpu.Value = (int)cpu;
            ProgressBarRam.Value = (int)ram;
            chart1.Series["CPU"].Points.AddY(cpu);
            chart1.Series["RAM"].Points.AddY(ram);
        }
    }
}
