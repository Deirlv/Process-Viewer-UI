namespace Process_Viewer_UI
{
    partial class TestInstancesForm
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
            buttonRunNotepad = new Button();
            buttonRunCalculator = new Button();
            buttonRunPaint = new Button();
            buttonRunExplorer = new Button();
            SuspendLayout();
            // 
            // buttonRunNotepad
            // 
            buttonRunNotepad.Location = new Point(26, 30);
            buttonRunNotepad.Name = "buttonRunNotepad";
            buttonRunNotepad.Size = new Size(75, 23);
            buttonRunNotepad.TabIndex = 0;
            buttonRunNotepad.Text = "Notepad";
            buttonRunNotepad.UseVisualStyleBackColor = true;
            buttonRunNotepad.Click += buttonRunNotepad_Click;
            // 
            // buttonRunCalculator
            // 
            buttonRunCalculator.Location = new Point(26, 75);
            buttonRunCalculator.Name = "buttonRunCalculator";
            buttonRunCalculator.Size = new Size(75, 23);
            buttonRunCalculator.TabIndex = 1;
            buttonRunCalculator.Text = "Calculator";
            buttonRunCalculator.UseVisualStyleBackColor = true;
            buttonRunCalculator.Click += buttonRunCalculator_Click;
            // 
            // buttonRunPaint
            // 
            buttonRunPaint.Location = new Point(26, 121);
            buttonRunPaint.Name = "buttonRunPaint";
            buttonRunPaint.Size = new Size(75, 23);
            buttonRunPaint.TabIndex = 2;
            buttonRunPaint.Text = "Paint";
            buttonRunPaint.UseVisualStyleBackColor = true;
            buttonRunPaint.Click += buttonRunPaint_Click;
            // 
            // buttonRunExplorer
            // 
            buttonRunExplorer.Location = new Point(26, 168);
            buttonRunExplorer.Name = "buttonRunExplorer";
            buttonRunExplorer.Size = new Size(75, 23);
            buttonRunExplorer.TabIndex = 3;
            buttonRunExplorer.Text = "Explorer";
            buttonRunExplorer.UseVisualStyleBackColor = true;
            buttonRunExplorer.Click += buttonRunEdge_Click;
            // 
            // TestInstancesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(132, 232);
            Controls.Add(buttonRunExplorer);
            Controls.Add(buttonRunPaint);
            Controls.Add(buttonRunCalculator);
            Controls.Add(buttonRunNotepad);
            Name = "TestInstancesForm";
            Text = "TestInstancesForm";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonRunNotepad;
        private Button buttonRunCalculator;
        private Button buttonRunPaint;
        private Button buttonRunExplorer;
    }
}