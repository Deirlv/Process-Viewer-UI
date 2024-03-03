namespace Process_Viewer_UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridViewProcesses = new DataGridView();
            processId = new DataGridViewTextBoxColumn();
            processName = new DataGridViewTextBoxColumn();
            processFileName = new DataGridViewTextBoxColumn();
            processTimeStart = new DataGridViewTextBoxColumn();
            processCPUTime = new DataGridViewTextBoxColumn();
            processThreads = new DataGridViewTextBoxColumn();
            processCopies = new DataGridViewTextBoxColumn();
            button1 = new Button();
            updateTick = new System.Windows.Forms.Timer(components);
            menuStrip1 = new MenuStrip();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            tickToolStripMenuItem = new ToolStripMenuItem();
            buttonInstance = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProcesses).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewProcesses
            // 
            dataGridViewProcesses.AllowUserToAddRows = false;
            dataGridViewProcesses.AllowUserToDeleteRows = false;
            dataGridViewProcesses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProcesses.Columns.AddRange(new DataGridViewColumn[] { processId, processName, processFileName, processTimeStart, processCPUTime, processThreads, processCopies });
            dataGridViewProcesses.Location = new Point(0, 27);
            dataGridViewProcesses.MultiSelect = false;
            dataGridViewProcesses.Name = "dataGridViewProcesses";
            dataGridViewProcesses.ReadOnly = true;
            dataGridViewProcesses.RowTemplate.Height = 25;
            dataGridViewProcesses.Size = new Size(744, 442);
            dataGridViewProcesses.TabIndex = 0;
            // 
            // processId
            // 
            processId.HeaderText = "ID";
            processId.Name = "processId";
            processId.ReadOnly = true;
            // 
            // processName
            // 
            processName.HeaderText = "Name";
            processName.Name = "processName";
            processName.ReadOnly = true;
            // 
            // processFileName
            // 
            processFileName.HeaderText = "File Name";
            processFileName.Name = "processFileName";
            processFileName.ReadOnly = true;
            // 
            // processTimeStart
            // 
            processTimeStart.HeaderText = "Time Start";
            processTimeStart.Name = "processTimeStart";
            processTimeStart.ReadOnly = true;
            // 
            // processCPUTime
            // 
            processCPUTime.HeaderText = "CPU Time";
            processCPUTime.Name = "processCPUTime";
            processCPUTime.ReadOnly = true;
            // 
            // processThreads
            // 
            processThreads.HeaderText = "Number of threads";
            processThreads.Name = "processThreads";
            processThreads.ReadOnly = true;
            // 
            // processCopies
            // 
            processCopies.HeaderText = "Number of copies";
            processCopies.Name = "processCopies";
            processCopies.ReadOnly = true;
            // 
            // button1
            // 
            button1.Location = new Point(650, 477);
            button1.Name = "button1";
            button1.Size = new Size(82, 28);
            button1.TabIndex = 1;
            button1.Text = "End Task";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // updateTick
            // 
            updateTick.Enabled = true;
            updateTick.Interval = 10000;
            updateTick.Tick += updateTick_Tick;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { settingsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(746, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tickToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(61, 20);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // tickToolStripMenuItem
            // 
            tickToolStripMenuItem.Name = "tickToolStripMenuItem";
            tickToolStripMenuItem.Size = new Size(136, 22);
            tickToolStripMenuItem.Text = "Update Tick";
            tickToolStripMenuItem.Click += tickToolStripMenuItem_Click;
            // 
            // buttonInstance
            // 
            buttonInstance.Location = new Point(12, 477);
            buttonInstance.Name = "buttonInstance";
            buttonInstance.Size = new Size(123, 28);
            buttonInstance.TabIndex = 3;
            buttonInstance.Text = "Run Test Instance";
            buttonInstance.UseVisualStyleBackColor = true;
            buttonInstance.Click += buttonInstance_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 515);
            Controls.Add(buttonInstance);
            Controls.Add(button1);
            Controls.Add(dataGridViewProcesses);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Process Viewer";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProcesses).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewProcesses;
        private Button button1;
        private System.Windows.Forms.Timer updateTick;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem tickToolStripMenuItem;
        private DataGridViewTextBoxColumn processId;
        private DataGridViewTextBoxColumn processName;
        private DataGridViewTextBoxColumn processFileName;
        private DataGridViewTextBoxColumn processTimeStart;
        private DataGridViewTextBoxColumn processCPUTime;
        private DataGridViewTextBoxColumn processThreads;
        private DataGridViewTextBoxColumn processCopies;
        private Button buttonInstance;
    }
}
