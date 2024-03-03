using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Process_Viewer_UI
{
    public partial class TestInstancesForm : Form
    {
        public TestInstancesForm()
        {
            InitializeComponent();
        }

        private void buttonRunNotepad_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe");
        }

        private void buttonRunCalculator_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void buttonRunPaint_Click(object sender, EventArgs e)
        {
            Process.Start("mspaint.exe");
        }

        private void buttonRunEdge_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe");
        }
    }
}
