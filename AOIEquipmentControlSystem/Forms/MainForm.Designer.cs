namespace AOIEquipmentControlSystem
{
    partial class MainForm
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
            initializeButton = new Button();
            startAutoButton = new Button();
            stopButton = new Button();
            resetButton = new Button();
            clearAlarmButton = new Button();
            machineStatusTitleLabel = new Label();
            machineStatusValueLabel = new Label();
            deviceStatusTitleLabel = new Label();
            deviceStatusValueLabel = new Label();
            recipeGroupBox = new GroupBox();
            recipeTextBox = new TextBox();
            logGroupBox = new GroupBox();
            logTextBox = new TextBox();
            resultGroupBox = new GroupBox();
            resultDataGridView = new DataGridView();
            recipeGroupBox.SuspendLayout();
            logGroupBox.SuspendLayout();
            resultGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)resultDataGridView).BeginInit();
            SuspendLayout();
            // 
            // initializeButton
            // 
            initializeButton.Location = new Point(20, 20);
            initializeButton.Name = "initializeButton";
            initializeButton.Size = new Size(120, 36);
            initializeButton.TabIndex = 0;
            initializeButton.Text = "Initialize";
            initializeButton.UseVisualStyleBackColor = true;
            initializeButton.Click += InitializeButton_Click;
            // 
            // startAutoButton
            // 
            startAutoButton.Location = new Point(150, 20);
            startAutoButton.Name = "startAutoButton";
            startAutoButton.Size = new Size(120, 36);
            startAutoButton.TabIndex = 1;
            startAutoButton.Text = "Start Auto";
            startAutoButton.UseVisualStyleBackColor = true;
            startAutoButton.Click += StartAutoButton_Click;
            // 
            // stopButton
            // 
            stopButton.Location = new Point(280, 20);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(120, 36);
            stopButton.TabIndex = 2;
            stopButton.Text = "Stop";
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += StopButton_Click;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(410, 20);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(120, 36);
            resetButton.TabIndex = 3;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += ResetButton_Click;
            // 
            // clearAlarmButton
            // 
            clearAlarmButton.Location = new Point(540, 20);
            clearAlarmButton.Name = "clearAlarmButton";
            clearAlarmButton.Size = new Size(120, 36);
            clearAlarmButton.TabIndex = 4;
            clearAlarmButton.Text = "Clear Alarm";
            clearAlarmButton.UseVisualStyleBackColor = true;
            clearAlarmButton.Click += ClearAlarmButton_Click;
            // 
            // machineStatusTitleLabel
            // 
            machineStatusTitleLabel.AutoSize = true;
            machineStatusTitleLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            machineStatusTitleLabel.Location = new Point(20, 78);
            machineStatusTitleLabel.Name = "machineStatusTitleLabel";
            machineStatusTitleLabel.Size = new Size(117, 19);
            machineStatusTitleLabel.TabIndex = 5;
            machineStatusTitleLabel.Text = "Machine Status:";
            // 
            // machineStatusValueLabel
            // 
            machineStatusValueLabel.BorderStyle = BorderStyle.FixedSingle;
            machineStatusValueLabel.Location = new Point(150, 74);
            machineStatusValueLabel.Name = "machineStatusValueLabel";
            machineStatusValueLabel.Size = new Size(160, 28);
            machineStatusValueLabel.TabIndex = 6;
            machineStatusValueLabel.Text = "Idle";
            machineStatusValueLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // deviceStatusTitleLabel
            // 
            deviceStatusTitleLabel.AutoSize = true;
            deviceStatusTitleLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            deviceStatusTitleLabel.Location = new Point(340, 78);
            deviceStatusTitleLabel.Name = "deviceStatusTitleLabel";
            deviceStatusTitleLabel.Size = new Size(137, 19);
            deviceStatusTitleLabel.TabIndex = 7;
            deviceStatusTitleLabel.Text = "Device Connection:";
            // 
            // deviceStatusValueLabel
            // 
            deviceStatusValueLabel.BorderStyle = BorderStyle.FixedSingle;
            deviceStatusValueLabel.Location = new Point(490, 74);
            deviceStatusValueLabel.Name = "deviceStatusValueLabel";
            deviceStatusValueLabel.Size = new Size(170, 28);
            deviceStatusValueLabel.TabIndex = 8;
            deviceStatusValueLabel.Text = "Disconnected";
            deviceStatusValueLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // recipeGroupBox
            // 
            recipeGroupBox.Controls.Add(recipeTextBox);
            recipeGroupBox.Location = new Point(20, 120);
            recipeGroupBox.Name = "recipeGroupBox";
            recipeGroupBox.Size = new Size(300, 170);
            recipeGroupBox.TabIndex = 9;
            recipeGroupBox.TabStop = false;
            recipeGroupBox.Text = "Recipe Parameters";
            // 
            // recipeTextBox
            // 
            recipeTextBox.Location = new Point(12, 26);
            recipeTextBox.Multiline = true;
            recipeTextBox.Name = "recipeTextBox";
            recipeTextBox.ReadOnly = true;
            recipeTextBox.ScrollBars = ScrollBars.Vertical;
            recipeTextBox.Size = new Size(270, 128);
            recipeTextBox.TabIndex = 0;
            // 
            // logGroupBox
            // 
            logGroupBox.Controls.Add(logTextBox);
            logGroupBox.Location = new Point(340, 120);
            logGroupBox.Name = "logGroupBox";
            logGroupBox.Size = new Size(420, 170);
            logGroupBox.TabIndex = 10;
            logGroupBox.TabStop = false;
            logGroupBox.Text = "Machine Log";
            // 
            // logTextBox
            // 
            logTextBox.Location = new Point(12, 26);
            logTextBox.Multiline = true;
            logTextBox.Name = "logTextBox";
            logTextBox.ReadOnly = true;
            logTextBox.ScrollBars = ScrollBars.Vertical;
            logTextBox.Size = new Size(390, 128);
            logTextBox.TabIndex = 0;
            // 
            // resultGroupBox
            // 
            resultGroupBox.Controls.Add(resultDataGridView);
            resultGroupBox.Location = new Point(20, 310);
            resultGroupBox.Name = "resultGroupBox";
            resultGroupBox.Size = new Size(740, 190);
            resultGroupBox.TabIndex = 11;
            resultGroupBox.TabStop = false;
            resultGroupBox.Text = "Inspection Result";
            // 
            // resultDataGridView
            // 
            resultDataGridView.AllowUserToAddRows = false;
            resultDataGridView.AllowUserToDeleteRows = false;
            resultDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            resultDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultDataGridView.Location = new Point(12, 26);
            resultDataGridView.Name = "resultDataGridView";
            resultDataGridView.ReadOnly = true;
            resultDataGridView.Size = new Size(710, 145);
            resultDataGridView.TabIndex = 0;
            // 
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 521);
            Controls.Add(resultGroupBox);
            Controls.Add(logGroupBox);
            Controls.Add(recipeGroupBox);
            Controls.Add(deviceStatusValueLabel);
            Controls.Add(deviceStatusTitleLabel);
            Controls.Add(machineStatusValueLabel);
            Controls.Add(machineStatusTitleLabel);
            Controls.Add(clearAlarmButton);
            Controls.Add(resetButton);
            Controls.Add(stopButton);
            Controls.Add(startAutoButton);
            Controls.Add(initializeButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AOI Equipment Control System Demo";
            recipeGroupBox.ResumeLayout(false);
            recipeGroupBox.PerformLayout();
            logGroupBox.ResumeLayout(false);
            logGroupBox.PerformLayout();
            resultGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)resultDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button initializeButton;
        private Button startAutoButton;
        private Button stopButton;
        private Button resetButton;
        private Button clearAlarmButton;
        private Label machineStatusTitleLabel;
        private Label machineStatusValueLabel;
        private Label deviceStatusTitleLabel;
        private Label deviceStatusValueLabel;
        private GroupBox recipeGroupBox;
        private TextBox recipeTextBox;
        private GroupBox logGroupBox;
        private TextBox logTextBox;
        private GroupBox resultGroupBox;
        private DataGridView resultDataGridView;
    }
}
