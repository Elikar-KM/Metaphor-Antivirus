using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.VisualBasic;

namespace Metaphor_Antivirus
{
    public partial class LowBudgetTaskManager : Form
    {
        public LowBudgetTaskManager()
        {
            InitializeComponent();
        }

        private void LowBudgetTaskManager_Load(object sender, EventArgs e)
        {
            GetProcesses();
        }

        public void GetProcesses()
        {
            lstProcesses.Items.Clear(); // clear the list before updating it
            Process[] task = Process.GetProcesses();
            foreach(Process proc in task)
            {
                lstProcesses.Items.Add(proc.ProcessName);
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            GetProcesses();
        }

        private void EndBtn_Click(object sender, EventArgs e)
        {
            Process[] task = Process.GetProcesses();
            foreach (Process proc in task)
            {
                if (lstProcesses.SelectedItem.ToString() == proc.ProcessName)
                {
                    proc.Kill();
                    break;
                }
            }
        }

        private void RunBtn_Click(object sender, EventArgs e)
        {
            string path = Microsoft.VisualBasic.Interaction.InputBox("Enter Process path:", "Metaphor Antivirus", "", 200, 200);
            Process.Start(path);
        }

        private void PropBtn_Click(object sender, EventArgs e)
        {
            Process[] task = Process.GetProcesses();
            foreach (Process proc in task)
            {
                if (lstProcesses.SelectedItem.ToString() == proc.ProcessName)
                {
                    string temp = string.Empty;
                    temp += "Process ID : " + proc.Id.ToString();
                    temp += "\nUser Time  : " + proc.UserProcessorTime.ToString();
                    temp += "\nStart at   : " + proc.StartTime.ToString();
                    MessageBox.Show(temp);
                    break;
                }
            }
        }
    }
}
