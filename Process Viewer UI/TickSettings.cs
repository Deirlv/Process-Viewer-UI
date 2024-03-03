using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Process_Viewer_UI
{
    public partial class TickSettings : Form
    {
        public decimal Ticks { get; set; } // Milliseconds
        public TickSettings()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(numericUpDownTicks.Value > 0)
            {
                Ticks = numericUpDownTicks.Value;
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("The field is empty or zero! Please write something.");
            }
            
        }
    }
}
