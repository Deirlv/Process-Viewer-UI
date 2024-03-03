using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace Process_Viewer_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridViewProcesses.Rows.Clear();
            DisplayProcesses();
        }

        private void updateTick_Tick(object sender, EventArgs e)
        {
            dataGridViewProcesses.Rows.Clear();
            DisplayProcesses();
        }

        private void DisplayProcesses()
        {
            foreach (var process in Process.GetProcesses())
            {
                try
                {
                    Process[] processes = Process.GetProcessesByName(process.ProcessName);
                    dataGridViewProcesses.Rows.Add(
                                process.Id,
                                process.ProcessName,
                                Path.GetFileName(process.MainModule.FileName),
                                process.StartTime.ToLongTimeString(),
                                process.TotalProcessorTime,
                                process.Threads.Count,
                                processes.Length
                            );
                }
                catch (Win32Exception exeption)
                {
                    Process[] processes = Process.GetProcessesByName(process.ProcessName);
                    dataGridViewProcesses.Rows.Add(
                                process.Id,
                                process.ProcessName,
                                "Error",
                                "Error",
                                "Error",
                                process.Threads.Count,
                                processes.Length
                            );
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewProcesses.SelectedCells.Count != 0)
            {
                int selectedRowIndex = dataGridViewProcesses.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewProcesses.Rows[selectedRowIndex];
                string processFileName = selectedRow.Cells["processFileName"].Value.ToString();

                DialogResult result = MessageBox.Show($"Are you sure you want to end {processFileName}", "Ending the process", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Process process = new Process();
                    process.StartInfo.FileName = processFileName;
                    process.Kill();
                }
            }
            else
            {
                MessageBox.Show("The process was not chosen");
            }
        }

        private void tickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TickSettings tickSettings = new TickSettings();
            tickSettings.ShowDialog();
            if (tickSettings.DialogResult != DialogResult.Cancel)
            {
                updateTick.Interval = Convert.ToInt32(tickSettings.Ticks);
            }
        }

        private void buttonInstance_Click(object sender, EventArgs e)
        {
            TestInstancesForm testInstancesForm = new TestInstancesForm();
            testInstancesForm.ShowDialog();
        }
    }
}
