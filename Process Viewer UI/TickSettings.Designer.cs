namespace Process_Viewer_UI
{
    partial class TickSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonSave = new Button();
            numericUpDownTicks = new NumericUpDown();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTicks).BeginInit();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(126, 114);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // numericUpDownTicks
            // 
            numericUpDownTicks.Location = new Point(68, 62);
            numericUpDownTicks.Maximum = new decimal(new int[] { 60000, 0, 0, 0 });
            numericUpDownTicks.Name = "numericUpDownTicks";
            numericUpDownTicks.Size = new Size(186, 23);
            numericUpDownTicks.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 24);
            label1.Name = "label1";
            label1.Size = new Size(170, 15);
            label1.TabIndex = 2;
            label1.Text = "Ticks per update (Milliseconds)";
            // 
            // TickSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 173);
            Controls.Add(label1);
            Controls.Add(numericUpDownTicks);
            Controls.Add(buttonSave);
            Name = "TickSettings";
            Text = "TickSettings";
            ((System.ComponentModel.ISupportInitialize)numericUpDownTicks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private NumericUpDown numericUpDownTicks;
        private Label label1;
    }
}