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
            mainLayoutPanel = new TableLayoutPanel();
            commandFlowLayoutPanel = new FlowLayoutPanel();
            initializeButton = new Button();
            startAutoButton = new Button();
            stopButton = new Button();
            resetButton = new Button();
            clearAlarmButton = new Button();
            statusTableLayoutPanel = new TableLayoutPanel();
            machineStatusTitleLabel = new Label();
            machineStatusValueLabel = new Label();
            deviceStatusTitleLabel = new Label();
            deviceStatusValueLabel = new Label();
            alarmMessageTitleLabel = new Label();
            alarmMessageValueLabel = new Label();
            detailTableLayoutPanel = new TableLayoutPanel();
            recipeGroupBox = new GroupBox();
            recipeLayoutPanel = new TableLayoutPanel();
            recipeTextBox = new TextBox();
            saveRecipeButton = new Button();
            logGroupBox = new GroupBox();
            logTextBox = new RichTextBox();
            resultGroupBox = new GroupBox();
            resultDataGridView = new DataGridView();
            mainLayoutPanel.SuspendLayout();
            commandFlowLayoutPanel.SuspendLayout();
            statusTableLayoutPanel.SuspendLayout();
            detailTableLayoutPanel.SuspendLayout();
            recipeGroupBox.SuspendLayout();
            recipeLayoutPanel.SuspendLayout();
            logGroupBox.SuspendLayout();
            resultGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)resultDataGridView).BeginInit();
            SuspendLayout();
            // 
            // mainLayoutPanel
            // 
            mainLayoutPanel.ColumnCount = 1;
            mainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayoutPanel.Controls.Add(commandFlowLayoutPanel, 0, 0);
            mainLayoutPanel.Controls.Add(statusTableLayoutPanel, 0, 1);
            mainLayoutPanel.Controls.Add(detailTableLayoutPanel, 0, 2);
            mainLayoutPanel.Controls.Add(resultGroupBox, 0, 3);
            mainLayoutPanel.Dock = DockStyle.Fill;
            mainLayoutPanel.Location = new Point(0, 0);
            mainLayoutPanel.Name = "mainLayoutPanel";
            mainLayoutPanel.Padding = new Padding(16);
            mainLayoutPanel.RowCount = 4;
            mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
            mainLayoutPanel.Size = new Size(1844, 964);
            mainLayoutPanel.TabIndex = 0;
            // 
            // commandFlowLayoutPanel
            // 
            commandFlowLayoutPanel.Controls.Add(initializeButton);
            commandFlowLayoutPanel.Controls.Add(startAutoButton);
            commandFlowLayoutPanel.Controls.Add(stopButton);
            commandFlowLayoutPanel.Controls.Add(resetButton);
            commandFlowLayoutPanel.Controls.Add(clearAlarmButton);
            commandFlowLayoutPanel.Dock = DockStyle.Fill;
            commandFlowLayoutPanel.Location = new Point(16, 16);
            commandFlowLayoutPanel.Margin = new Padding(0, 0, 0, 8);
            commandFlowLayoutPanel.Name = "commandFlowLayoutPanel";
            commandFlowLayoutPanel.Size = new Size(1812, 42);
            commandFlowLayoutPanel.TabIndex = 0;
            commandFlowLayoutPanel.WrapContents = false;
            // 
            // initializeButton
            // 
            initializeButton.Location = new Point(0, 0);
            initializeButton.Margin = new Padding(0, 0, 8, 0);
            initializeButton.Name = "initializeButton";
            initializeButton.Size = new Size(120, 36);
            initializeButton.TabIndex = 0;
            initializeButton.Text = "Initialize";
            initializeButton.UseVisualStyleBackColor = true;
            initializeButton.Click += InitializeButton_Click;
            // 
            // startAutoButton
            // 
            startAutoButton.Location = new Point(128, 0);
            startAutoButton.Margin = new Padding(0, 0, 8, 0);
            startAutoButton.Name = "startAutoButton";
            startAutoButton.Size = new Size(120, 36);
            startAutoButton.TabIndex = 1;
            startAutoButton.Text = "Start Auto";
            startAutoButton.UseVisualStyleBackColor = true;
            startAutoButton.Click += StartAutoButton_Click;
            // 
            // stopButton
            // 
            stopButton.Location = new Point(256, 0);
            stopButton.Margin = new Padding(0, 0, 8, 0);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(120, 36);
            stopButton.TabIndex = 2;
            stopButton.Text = "Stop";
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += StopButton_Click;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(384, 0);
            resetButton.Margin = new Padding(0, 0, 8, 0);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(120, 36);
            resetButton.TabIndex = 3;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += ResetButton_Click;
            // 
            // clearAlarmButton
            // 
            clearAlarmButton.Location = new Point(512, 0);
            clearAlarmButton.Margin = new Padding(0);
            clearAlarmButton.Name = "clearAlarmButton";
            clearAlarmButton.Size = new Size(120, 36);
            clearAlarmButton.TabIndex = 4;
            clearAlarmButton.Text = "Clear Alarm";
            clearAlarmButton.UseVisualStyleBackColor = true;
            clearAlarmButton.Click += ClearAlarmButton_Click;
            // 
            // statusTableLayoutPanel
            // 
            statusTableLayoutPanel.ColumnCount = 4;
            statusTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            statusTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            statusTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            statusTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            statusTableLayoutPanel.Controls.Add(machineStatusTitleLabel, 0, 0);
            statusTableLayoutPanel.Controls.Add(machineStatusValueLabel, 1, 0);
            statusTableLayoutPanel.Controls.Add(deviceStatusTitleLabel, 2, 0);
            statusTableLayoutPanel.Controls.Add(deviceStatusValueLabel, 3, 0);
            statusTableLayoutPanel.Controls.Add(alarmMessageTitleLabel, 0, 1);
            statusTableLayoutPanel.Controls.Add(alarmMessageValueLabel, 1, 1);
            statusTableLayoutPanel.Dock = DockStyle.Fill;
            statusTableLayoutPanel.Location = new Point(16, 66);
            statusTableLayoutPanel.Margin = new Padding(0, 0, 0, 8);
            statusTableLayoutPanel.Name = "statusTableLayoutPanel";
            statusTableLayoutPanel.RowCount = 2;
            statusTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            statusTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            statusTableLayoutPanel.SetColumnSpan(alarmMessageValueLabel, 3);
            statusTableLayoutPanel.Size = new Size(1812, 74);
            statusTableLayoutPanel.TabIndex = 1;
            // 
            // machineStatusTitleLabel
            // 
            machineStatusTitleLabel.Anchor = AnchorStyles.Left;
            machineStatusTitleLabel.AutoSize = true;
            machineStatusTitleLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            machineStatusTitleLabel.Location = new Point(0, 0);
            machineStatusTitleLabel.Margin = new Padding(0, 0, 8, 0);
            machineStatusTitleLabel.Name = "machineStatusTitleLabel";
            machineStatusTitleLabel.Size = new Size(219, 34);
            machineStatusTitleLabel.TabIndex = 5;
            machineStatusTitleLabel.Text = "Machine Status:";
            // 
            // machineStatusValueLabel
            // 
            machineStatusValueLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            machineStatusValueLabel.BorderStyle = BorderStyle.FixedSingle;
            machineStatusValueLabel.Location = new Point(227, 3);
            machineStatusValueLabel.Margin = new Padding(0, 0, 24, 0);
            machineStatusValueLabel.Name = "machineStatusValueLabel";
            machineStatusValueLabel.Size = new Size(633, 28);
            machineStatusValueLabel.TabIndex = 6;
            machineStatusValueLabel.Text = "Idle";
            machineStatusValueLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // deviceStatusTitleLabel
            // 
            deviceStatusTitleLabel.Anchor = AnchorStyles.Left;
            deviceStatusTitleLabel.AutoSize = true;
            deviceStatusTitleLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            deviceStatusTitleLabel.Location = new Point(884, 0);
            deviceStatusTitleLabel.Margin = new Padding(0, 0, 8, 0);
            deviceStatusTitleLabel.Name = "deviceStatusTitleLabel";
            deviceStatusTitleLabel.Size = new Size(263, 34);
            deviceStatusTitleLabel.TabIndex = 7;
            deviceStatusTitleLabel.Text = "Device Connection:";
            // 
            // deviceStatusValueLabel
            // 
            deviceStatusValueLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            deviceStatusValueLabel.BorderStyle = BorderStyle.FixedSingle;
            deviceStatusValueLabel.Location = new Point(1155, 3);
            deviceStatusValueLabel.Margin = new Padding(0);
            deviceStatusValueLabel.Name = "deviceStatusValueLabel";
            deviceStatusValueLabel.Size = new Size(657, 28);
            deviceStatusValueLabel.TabIndex = 8;
            deviceStatusValueLabel.Text = "Disconnected";
            deviceStatusValueLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // alarmMessageTitleLabel
            // 
            alarmMessageTitleLabel.Anchor = AnchorStyles.Left;
            alarmMessageTitleLabel.AutoSize = true;
            alarmMessageTitleLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            alarmMessageTitleLabel.Location = new Point(0, 37);
            alarmMessageTitleLabel.Margin = new Padding(0, 0, 8, 0);
            alarmMessageTitleLabel.Name = "alarmMessageTitleLabel";
            alarmMessageTitleLabel.Size = new Size(212, 34);
            alarmMessageTitleLabel.TabIndex = 9;
            alarmMessageTitleLabel.Text = "Alarm Message:";
            // 
            // alarmMessageValueLabel
            // 
            alarmMessageValueLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            alarmMessageValueLabel.BorderStyle = BorderStyle.FixedSingle;
            alarmMessageValueLabel.Location = new Point(227, 41);
            alarmMessageValueLabel.Margin = new Padding(0);
            alarmMessageValueLabel.Name = "alarmMessageValueLabel";
            alarmMessageValueLabel.Size = new Size(1585, 28);
            alarmMessageValueLabel.TabIndex = 10;
            alarmMessageValueLabel.Text = "None";
            alarmMessageValueLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // detailTableLayoutPanel
            // 
            detailTableLayoutPanel.ColumnCount = 2;
            detailTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            detailTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            detailTableLayoutPanel.Controls.Add(recipeGroupBox, 0, 0);
            detailTableLayoutPanel.Controls.Add(logGroupBox, 1, 0);
            detailTableLayoutPanel.Dock = DockStyle.Fill;
            detailTableLayoutPanel.Location = new Point(16, 148);
            detailTableLayoutPanel.Margin = new Padding(0, 0, 0, 12);
            detailTableLayoutPanel.Name = "detailTableLayoutPanel";
            detailTableLayoutPanel.RowCount = 1;
            detailTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            detailTableLayoutPanel.Size = new Size(1812, 357);
            detailTableLayoutPanel.TabIndex = 2;
            // 
            // recipeGroupBox
            // 
            recipeGroupBox.Controls.Add(recipeLayoutPanel);
            recipeGroupBox.Dock = DockStyle.Fill;
            recipeGroupBox.Location = new Point(0, 0);
            recipeGroupBox.Margin = new Padding(0, 0, 8, 0);
            recipeGroupBox.Name = "recipeGroupBox";
            recipeGroupBox.Padding = new Padding(12);
            recipeGroupBox.Size = new Size(716, 357);
            recipeGroupBox.TabIndex = 9;
            recipeGroupBox.TabStop = false;
            recipeGroupBox.Text = "Recipe Parameters";
            // 
            // recipeLayoutPanel
            // 
            recipeLayoutPanel.ColumnCount = 1;
            recipeLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            recipeLayoutPanel.Controls.Add(recipeTextBox, 0, 0);
            recipeLayoutPanel.Controls.Add(saveRecipeButton, 0, 1);
            recipeLayoutPanel.Dock = DockStyle.Fill;
            recipeLayoutPanel.Location = new Point(12, 43);
            recipeLayoutPanel.Margin = new Padding(0);
            recipeLayoutPanel.Name = "recipeLayoutPanel";
            recipeLayoutPanel.RowCount = 2;
            recipeLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            recipeLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            recipeLayoutPanel.Size = new Size(692, 302);
            recipeLayoutPanel.TabIndex = 0;
            // 
            // recipeTextBox
            // 
            recipeTextBox.Dock = DockStyle.Fill;
            recipeTextBox.Location = new Point(0, 0);
            recipeTextBox.Margin = new Padding(0);
            recipeTextBox.Multiline = true;
            recipeTextBox.Name = "recipeTextBox";
            recipeTextBox.ScrollBars = ScrollBars.Vertical;
            recipeTextBox.Size = new Size(692, 258);
            recipeTextBox.TabIndex = 0;
            // 
            // saveRecipeButton
            // 
            saveRecipeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            saveRecipeButton.Location = new Point(542, 264);
            saveRecipeButton.Margin = new Padding(0, 6, 0, 0);
            saveRecipeButton.Name = "saveRecipeButton";
            saveRecipeButton.Size = new Size(150, 34);
            saveRecipeButton.TabIndex = 1;
            saveRecipeButton.Text = "Save Recipe";
            saveRecipeButton.UseVisualStyleBackColor = true;
            saveRecipeButton.Click += SaveRecipeButton_Click;
            // 
            // logGroupBox
            // 
            logGroupBox.Controls.Add(logTextBox);
            logGroupBox.Dock = DockStyle.Fill;
            logGroupBox.Location = new Point(732, 0);
            logGroupBox.Margin = new Padding(8, 0, 0, 0);
            logGroupBox.Name = "logGroupBox";
            logGroupBox.Padding = new Padding(12);
            logGroupBox.Size = new Size(1080, 357);
            logGroupBox.TabIndex = 10;
            logGroupBox.TabStop = false;
            logGroupBox.Text = "Machine Log";
            // 
            // logTextBox
            // 
            logTextBox.Dock = DockStyle.Fill;
            logTextBox.Location = new Point(12, 43);
            logTextBox.Margin = new Padding(0);
            logTextBox.Name = "logTextBox";
            logTextBox.ReadOnly = true;
            logTextBox.Size = new Size(1056, 302);
            logTextBox.TabIndex = 0;
            // 
            // resultGroupBox
            // 
            resultGroupBox.Controls.Add(resultDataGridView);
            resultGroupBox.Dock = DockStyle.Fill;
            resultGroupBox.Location = new Point(16, 517);
            resultGroupBox.Margin = new Padding(0);
            resultGroupBox.Name = "resultGroupBox";
            resultGroupBox.Padding = new Padding(12);
            resultGroupBox.Size = new Size(1812, 431);
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
            resultDataGridView.Dock = DockStyle.Fill;
            resultDataGridView.Location = new Point(12, 43);
            resultDataGridView.Margin = new Padding(0);
            resultDataGridView.Name = "resultDataGridView";
            resultDataGridView.ReadOnly = true;
            resultDataGridView.RowHeadersWidth = 82;
            resultDataGridView.Size = new Size(1788, 376);
            resultDataGridView.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1844, 964);
            Controls.Add(mainLayoutPanel);
            MinimumSize = new Size(760, 560);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AOI Equipment Control System Demo";
            mainLayoutPanel.ResumeLayout(false);
            commandFlowLayoutPanel.ResumeLayout(false);
            statusTableLayoutPanel.ResumeLayout(false);
            statusTableLayoutPanel.PerformLayout();
            detailTableLayoutPanel.ResumeLayout(false);
            recipeGroupBox.ResumeLayout(false);
            recipeLayoutPanel.ResumeLayout(false);
            recipeLayoutPanel.PerformLayout();
            logGroupBox.ResumeLayout(false);
            logGroupBox.PerformLayout();
            resultGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)resultDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainLayoutPanel;
        private FlowLayoutPanel commandFlowLayoutPanel;
        private TableLayoutPanel statusTableLayoutPanel;
        private TableLayoutPanel detailTableLayoutPanel;
        private Button initializeButton;
        private Button startAutoButton;
        private Button stopButton;
        private Button resetButton;
        private Button clearAlarmButton;
        private Label machineStatusTitleLabel;
        private Label machineStatusValueLabel;
        private Label deviceStatusTitleLabel;
        private Label deviceStatusValueLabel;
        private Label alarmMessageTitleLabel;
        private Label alarmMessageValueLabel;
        private GroupBox recipeGroupBox;
        private TableLayoutPanel recipeLayoutPanel;
        private TextBox recipeTextBox;
        private Button saveRecipeButton;
        private GroupBox logGroupBox;
        private RichTextBox logTextBox;
        private GroupBox resultGroupBox;
        private DataGridView resultDataGridView;
    }
}
