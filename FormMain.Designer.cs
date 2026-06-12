namespace AppSeparadorMMs
{
    partial class FormMain
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
            tabControl_Main = new TabControl();
            tabPage_Counter = new TabPage();
            label_Timer = new Label();
            button_Start = new Button();
            splitContainer_Counter = new SplitContainer();
            panel_Light = new Panel();
            numericUpDown_LightCounter = new NumericUpDown();
            label_LightCounter = new Label();
            label_LightTitle = new Label();
            panel_Dark = new Panel();
            numericUpDown_DarkCounter = new NumericUpDown();
            label_DarkCounter = new Label();
            label_darkTitle = new Label();
            tabPage_Controller = new TabPage();
            groupBox_Configs = new GroupBox();
            label_ActualInterval = new Label();
            label_ActualThreshold = new Label();
            button_SaveChanges = new Button();
            label_Interval = new Label();
            trackBar_Interval = new TrackBar();
            label_Threshold = new Label();
            trackBar_Threshold = new TrackBar();
            button_Connect = new Button();
            button_Disconnect = new Button();
            toolStrip_Ports = new ToolStrip();
            toolStripComboBox_Ports = new ToolStripComboBox();
            toolStripButton_RefreshPort = new ToolStripButton();
            toolStripLabel_Status = new ToolStripLabel();
            timer_Timer = new System.Windows.Forms.Timer(components);
            tabControl_Main.SuspendLayout();
            tabPage_Counter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer_Counter).BeginInit();
            splitContainer_Counter.Panel1.SuspendLayout();
            splitContainer_Counter.Panel2.SuspendLayout();
            splitContainer_Counter.SuspendLayout();
            panel_Light.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_LightCounter).BeginInit();
            panel_Dark.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_DarkCounter).BeginInit();
            tabPage_Controller.SuspendLayout();
            groupBox_Configs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar_Interval).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_Threshold).BeginInit();
            toolStrip_Ports.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl_Main
            // 
            tabControl_Main.Controls.Add(tabPage_Counter);
            tabControl_Main.Controls.Add(tabPage_Controller);
            tabControl_Main.Dock = DockStyle.Fill;
            tabControl_Main.Location = new Point(0, 0);
            tabControl_Main.Name = "tabControl_Main";
            tabControl_Main.SelectedIndex = 0;
            tabControl_Main.Size = new Size(384, 261);
            tabControl_Main.SizeMode = TabSizeMode.FillToRight;
            tabControl_Main.TabIndex = 0;
            // 
            // tabPage_Counter
            // 
            tabPage_Counter.BackColor = Color.LightGray;
            tabPage_Counter.Controls.Add(label_Timer);
            tabPage_Counter.Controls.Add(button_Start);
            tabPage_Counter.Controls.Add(splitContainer_Counter);
            tabPage_Counter.Location = new Point(4, 24);
            tabPage_Counter.Name = "tabPage_Counter";
            tabPage_Counter.Padding = new Padding(3);
            tabPage_Counter.Size = new Size(376, 233);
            tabPage_Counter.TabIndex = 0;
            tabPage_Counter.Text = "Contador";
            // 
            // label_Timer
            // 
            label_Timer.AutoSize = true;
            label_Timer.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label_Timer.Location = new Point(336, 179);
            label_Timer.Name = "label_Timer";
            label_Timer.Size = new Size(32, 16);
            label_Timer.TabIndex = 3;
            label_Timer.Text = "-- : --";
            // 
            // button_Start
            // 
            button_Start.BackColor = Color.DarkGray;
            button_Start.Dock = DockStyle.Bottom;
            button_Start.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Start.Location = new Point(3, 198);
            button_Start.Name = "button_Start";
            button_Start.Size = new Size(370, 32);
            button_Start.TabIndex = 1;
            button_Start.Text = "Iniciar";
            button_Start.UseVisualStyleBackColor = false;
            button_Start.Click += button_Start_Click;
            // 
            // splitContainer_Counter
            // 
            splitContainer_Counter.Dock = DockStyle.Top;
            splitContainer_Counter.Location = new Point(3, 3);
            splitContainer_Counter.Name = "splitContainer_Counter";
            // 
            // splitContainer_Counter.Panel1
            // 
            splitContainer_Counter.Panel1.Controls.Add(panel_Light);
            splitContainer_Counter.Panel1.Controls.Add(label_LightTitle);
            // 
            // splitContainer_Counter.Panel2
            // 
            splitContainer_Counter.Panel2.Controls.Add(panel_Dark);
            splitContainer_Counter.Panel2.Controls.Add(label_darkTitle);
            splitContainer_Counter.Size = new Size(370, 173);
            splitContainer_Counter.SplitterDistance = 182;
            splitContainer_Counter.SplitterWidth = 2;
            splitContainer_Counter.TabIndex = 0;
            // 
            // panel_Light
            // 
            panel_Light.Controls.Add(numericUpDown_LightCounter);
            panel_Light.Controls.Add(label_LightCounter);
            panel_Light.Dock = DockStyle.Fill;
            panel_Light.Location = new Point(0, 23);
            panel_Light.Name = "panel_Light";
            panel_Light.Padding = new Padding(18);
            panel_Light.Size = new Size(182, 150);
            panel_Light.TabIndex = 2;
            // 
            // numericUpDown_LightCounter
            // 
            numericUpDown_LightCounter.Dock = DockStyle.Top;
            numericUpDown_LightCounter.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown_LightCounter.Increment = new decimal(new int[] { 0, 0, 0, 0 });
            numericUpDown_LightCounter.InterceptArrowKeys = false;
            numericUpDown_LightCounter.Location = new Point(18, 65);
            numericUpDown_LightCounter.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            numericUpDown_LightCounter.Name = "numericUpDown_LightCounter";
            numericUpDown_LightCounter.ReadOnly = false;
            numericUpDown_LightCounter.Size = new Size(146, 23);
            numericUpDown_LightCounter.TabIndex = 1;
            // 
            // label_LightCounter
            // 
            label_LightCounter.Dock = DockStyle.Top;
            label_LightCounter.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label_LightCounter.Location = new Point(18, 18);
            label_LightCounter.Name = "label_LightCounter";
            label_LightCounter.Size = new Size(146, 47);
            label_LightCounter.TabIndex = 0;
            label_LightCounter.Text = "Quantidade de M&Ms Claros";
            label_LightCounter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_LightTitle
            // 
            label_LightTitle.BackColor = Color.White;
            label_LightTitle.Dock = DockStyle.Top;
            label_LightTitle.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_LightTitle.ForeColor = Color.Black;
            label_LightTitle.Location = new Point(0, 0);
            label_LightTitle.Margin = new Padding(0);
            label_LightTitle.Name = "label_LightTitle";
            label_LightTitle.Size = new Size(182, 23);
            label_LightTitle.TabIndex = 1;
            label_LightTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel_Dark
            // 
            panel_Dark.Controls.Add(numericUpDown_DarkCounter);
            panel_Dark.Controls.Add(label_DarkCounter);
            panel_Dark.Dock = DockStyle.Fill;
            panel_Dark.Location = new Point(0, 23);
            panel_Dark.Name = "panel_Dark";
            panel_Dark.Padding = new Padding(18);
            panel_Dark.Size = new Size(186, 150);
            panel_Dark.TabIndex = 3;
            // 
            // numericUpDown_DarkCounter
            // 
            numericUpDown_DarkCounter.Dock = DockStyle.Top;
            numericUpDown_DarkCounter.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown_DarkCounter.Increment = new decimal(new int[] { 0, 0, 0, 0 });
            numericUpDown_DarkCounter.InterceptArrowKeys = false;
            numericUpDown_DarkCounter.Location = new Point(18, 65);
            numericUpDown_DarkCounter.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            numericUpDown_DarkCounter.Name = "numericUpDown_DarkCounter";
            numericUpDown_DarkCounter.ReadOnly = false;
            numericUpDown_DarkCounter.Size = new Size(150, 23);
            numericUpDown_DarkCounter.TabIndex = 1;
            // 
            // label_DarkCounter
            // 
            label_DarkCounter.Dock = DockStyle.Top;
            label_DarkCounter.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label_DarkCounter.Location = new Point(18, 18);
            label_DarkCounter.Name = "label_DarkCounter";
            label_DarkCounter.Size = new Size(150, 47);
            label_DarkCounter.TabIndex = 0;
            label_DarkCounter.Text = "Quantidade de M&Ms Escuros";
            label_DarkCounter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_darkTitle
            // 
            label_darkTitle.BackColor = Color.Black;
            label_darkTitle.Dock = DockStyle.Top;
            label_darkTitle.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_darkTitle.ForeColor = Color.White;
            label_darkTitle.Location = new Point(0, 0);
            label_darkTitle.Margin = new Padding(0);
            label_darkTitle.Name = "label_darkTitle";
            label_darkTitle.Size = new Size(186, 23);
            label_darkTitle.TabIndex = 1;
            label_darkTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tabPage_Controller
            // 
            tabPage_Controller.BackColor = Color.LightGray;
            tabPage_Controller.Controls.Add(groupBox_Configs);
            tabPage_Controller.Controls.Add(button_Connect);
            tabPage_Controller.Controls.Add(button_Disconnect);
            tabPage_Controller.Controls.Add(toolStrip_Ports);
            tabPage_Controller.Location = new Point(4, 24);
            tabPage_Controller.Name = "tabPage_Controller";
            tabPage_Controller.Padding = new Padding(3);
            tabPage_Controller.Size = new Size(376, 233);
            tabPage_Controller.TabIndex = 1;
            tabPage_Controller.Text = "Controlador";
            // 
            // groupBox_Configs
            // 
            groupBox_Configs.Controls.Add(label_ActualInterval);
            groupBox_Configs.Controls.Add(label_ActualThreshold);
            groupBox_Configs.Controls.Add(button_SaveChanges);
            groupBox_Configs.Controls.Add(label_Interval);
            groupBox_Configs.Controls.Add(trackBar_Interval);
            groupBox_Configs.Controls.Add(label_Threshold);
            groupBox_Configs.Controls.Add(trackBar_Threshold);
            groupBox_Configs.Font = new Font("Century Gothic", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox_Configs.Location = new Point(3, 67);
            groupBox_Configs.Name = "groupBox_Configs";
            groupBox_Configs.Size = new Size(370, 163);
            groupBox_Configs.TabIndex = 4;
            groupBox_Configs.TabStop = false;
            groupBox_Configs.Text = "Configurações";
            // 
            // label_ActualInterval
            // 
            label_ActualInterval.AutoSize = true;
            label_ActualInterval.Font = new Font("Century Gothic", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label_ActualInterval.Location = new Point(131, 72);
            label_ActualInterval.Name = "label_ActualInterval";
            label_ActualInterval.Size = new Size(27, 15);
            label_ActualInterval.TabIndex = 6;
            label_ActualInterval.Text = "(50)";
            // 
            // label_ActualThreshold
            // 
            label_ActualThreshold.AutoSize = true;
            label_ActualThreshold.Font = new Font("Century Gothic", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label_ActualThreshold.Location = new Point(156, 20);
            label_ActualThreshold.Name = "label_ActualThreshold";
            label_ActualThreshold.Size = new Size(33, 15);
            label_ActualThreshold.TabIndex = 5;
            label_ActualThreshold.Text = "(720)";
            // 
            // button_SaveChanges
            // 
            button_SaveChanges.BackColor = Color.WhiteSmoke;
            button_SaveChanges.Dock = DockStyle.Bottom;
            button_SaveChanges.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_SaveChanges.Location = new Point(3, 128);
            button_SaveChanges.Name = "button_SaveChanges";
            button_SaveChanges.Size = new Size(364, 32);
            button_SaveChanges.TabIndex = 4;
            button_SaveChanges.Text = "Salvar";
            button_SaveChanges.UseVisualStyleBackColor = false;
            button_SaveChanges.Click += button_SaveChanges_Click;
            // 
            // label_Interval
            // 
            label_Interval.AutoSize = true;
            label_Interval.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Interval.Location = new Point(6, 71);
            label_Interval.Name = "label_Interval";
            label_Interval.Size = new Size(119, 16);
            label_Interval.TabIndex = 3;
            label_Interval.Text = "Intervalo de Leitura";
            // 
            // trackBar_Interval
            // 
            trackBar_Interval.Location = new Point(6, 94);
            trackBar_Interval.Maximum = 5000;
            trackBar_Interval.Minimum = 50;
            trackBar_Interval.Name = "trackBar_Interval";
            trackBar_Interval.Size = new Size(358, 45);
            trackBar_Interval.TabIndex = 2;
            trackBar_Interval.TickFrequency = 100;
            trackBar_Interval.Value = 50;
            // 
            // label_Threshold
            // 
            label_Threshold.AutoSize = true;
            label_Threshold.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Threshold.Location = new Point(6, 19);
            label_Threshold.Name = "label_Threshold";
            label_Threshold.Size = new Size(144, 16);
            label_Threshold.TabIndex = 1;
            label_Threshold.Text = "Limiar de Luminosidade";
            // 
            // trackBar_Threshold
            // 
            trackBar_Threshold.Location = new Point(6, 42);
            trackBar_Threshold.Maximum = 825;
            trackBar_Threshold.Minimum = 505;
            trackBar_Threshold.Name = "trackBar_Threshold";
            trackBar_Threshold.Size = new Size(361, 45);
            trackBar_Threshold.TabIndex = 0;
            trackBar_Threshold.TickFrequency = 100;
            trackBar_Threshold.Value = 720;
            // 
            // button_Connect
            // 
            button_Connect.BackColor = Color.WhiteSmoke;
            button_Connect.Font = new Font("Century Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Connect.Location = new Point(3, 38);
            button_Connect.Name = "button_Connect";
            button_Connect.Size = new Size(69, 23);
            button_Connect.TabIndex = 3;
            button_Connect.Text = "Conectar";
            button_Connect.UseVisualStyleBackColor = false;
            button_Connect.Click += button_Connect_Click;
            // 
            // button_Disconnect
            // 
            button_Disconnect.BackColor = Color.WhiteSmoke;
            button_Disconnect.Font = new Font("Century Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Disconnect.Location = new Point(78, 38);
            button_Disconnect.Name = "button_Disconnect";
            button_Disconnect.Size = new Size(92, 23);
            button_Disconnect.TabIndex = 2;
            button_Disconnect.Text = "Desconectar";
            button_Disconnect.UseVisualStyleBackColor = false;
            button_Disconnect.Click += button_Disconnect_Click;
            // 
            // toolStrip_Ports
            // 
            toolStrip_Ports.AutoSize = false;
            toolStrip_Ports.BackColor = Color.DarkGray;
            toolStrip_Ports.Items.AddRange(new ToolStripItem[] { toolStripComboBox_Ports, toolStripButton_RefreshPort, toolStripLabel_Status });
            toolStrip_Ports.Location = new Point(3, 3);
            toolStrip_Ports.Name = "toolStrip_Ports";
            toolStrip_Ports.Size = new Size(370, 32);
            toolStrip_Ports.TabIndex = 0;
            // 
            // toolStripComboBox_Ports
            // 
            toolStripComboBox_Ports.AutoSize = false;
            toolStripComboBox_Ports.BackColor = Color.WhiteSmoke;
            toolStripComboBox_Ports.Name = "toolStripComboBox_Ports";
            toolStripComboBox_Ports.Size = new Size(115, 23);
            toolStripComboBox_Ports.Sorted = true;
            // 
            // toolStripButton_RefreshPort
            // 
            toolStripButton_RefreshPort.AutoSize = false;
            toolStripButton_RefreshPort.BackColor = Color.WhiteSmoke;
            toolStripButton_RefreshPort.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton_RefreshPort.Image = Properties.Resources.Refresh;
            toolStripButton_RefreshPort.ImageTransparentColor = Color.Magenta;
            toolStripButton_RefreshPort.Name = "toolStripButton_RefreshPort";
            toolStripButton_RefreshPort.Size = new Size(23, 23);
            toolStripButton_RefreshPort.Click += toolStripButton_RefreshPort_Click;
            // 
            // toolStripLabel_Status
            // 
            toolStripLabel_Status.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripLabel_Status.Name = "toolStripLabel_Status";
            toolStripLabel_Status.Size = new Size(89, 29);
            toolStripLabel_Status.Text = "Carregando...";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(384, 261);
            Controls.Add(tabControl_Main);
            Name = "FormMain";
            Text = "Separador de M&Ms";
            FormClosing += FormMain_FormClosing;
            tabControl_Main.ResumeLayout(false);
            tabPage_Counter.ResumeLayout(false);
            tabPage_Counter.PerformLayout();
            splitContainer_Counter.Panel1.ResumeLayout(false);
            splitContainer_Counter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer_Counter).EndInit();
            splitContainer_Counter.ResumeLayout(false);
            panel_Light.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown_LightCounter).EndInit();
            panel_Dark.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown_DarkCounter).EndInit();
            tabPage_Controller.ResumeLayout(false);
            groupBox_Configs.ResumeLayout(false);
            groupBox_Configs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar_Interval).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_Threshold).EndInit();
            toolStrip_Ports.ResumeLayout(false);
            toolStrip_Ports.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl_Main;
        private TabPage tabPage_Controller;
        private TabPage tabPage_Counter;
        private SplitContainer splitContainer_Counter;
        private Label label_LightTitle;
        private Label label_darkTitle;
        private Panel panel_Light;
        private Label label_LightCounter;
        private NumericUpDown numericUpDown_LightCounter;
        private Panel panel_Dark;
        private NumericUpDown numericUpDown_DarkCounter;
        private Label label_DarkCounter;
        private Button button_Start;
        private System.Windows.Forms.Timer timer_Timer;
        private Label label_Timer;
        private ToolStrip toolStrip_Ports;
        private ToolStripComboBox toolStripComboBox_Ports;
        private ToolStripButton toolStripButton_RefreshPort;
        private Button button_Disconnect;
        private Button button_Connect;
        private GroupBox groupBox_Configs;
        private TrackBar trackBar_Threshold;
        private Label label_Threshold;
        private Label label_Interval;
        private TrackBar trackBar_Interval;
        private Button button_SaveChanges;
        private ToolStripLabel toolStripLabel_Status;
        private Label label_ActualThreshold;
        private Label label_ActualInterval;
    }
}
