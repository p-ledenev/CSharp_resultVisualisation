using ZedGraph;

namespace resultVisualisation
{
    partial class ApplicationForm
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
            this.components = new System.ComponentModel.Container();
            this.controlZedGraph = new ZedGraph.ZedGraphControl();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dataGridSummary = new System.Windows.Forms.DataGridView();
            this.labelSettings = new System.Windows.Forms.Label();
            this.comboTicket = new System.Windows.Forms.ComboBox();
            this.labelTicket = new System.Windows.Forms.Label();
            this.comboYear = new System.Windows.Forms.ComboBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.comboTimeFrame = new System.Windows.Forms.ComboBox();
            this.labelTimeFrame = new System.Windows.Forms.Label();
            this.buttonZoom = new System.Windows.Forms.Button();
            this.buttonView = new System.Windows.Forms.Button();
            this.comboStrategy = new System.Windows.Forms.ComboBox();
            this.labelStrategy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // controlZedGraph
            // 
            this.controlZedGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlZedGraph.AutoSize = true;
            this.controlZedGraph.Location = new System.Drawing.Point(0, 171);
            this.controlZedGraph.Name = "controlZedGraph";
            this.controlZedGraph.ScrollGrace = 0D;
            this.controlZedGraph.ScrollMaxX = 0D;
            this.controlZedGraph.ScrollMaxY = 0D;
            this.controlZedGraph.ScrollMaxY2 = 0D;
            this.controlZedGraph.ScrollMinX = 0D;
            this.controlZedGraph.ScrollMinY = 0D;
            this.controlZedGraph.ScrollMinY2 = 0D;
            this.controlZedGraph.Size = new System.Drawing.Size(1220, 493);
            this.controlZedGraph.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1220, 165);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // dataGridSummary
            // 
            this.dataGridSummary.AllowUserToOrderColumns = true;
            this.dataGridSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSummary.Location = new System.Drawing.Point(196, 0);
            this.dataGridSummary.Name = "dataGridSummary";
            this.dataGridSummary.Size = new System.Drawing.Size(1024, 158);
            this.dataGridSummary.TabIndex = 2;
            // 
            // labelSettings
            // 
            this.labelSettings.AutoSize = true;
            this.labelSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelSettings.Location = new System.Drawing.Point(29, 9);
            this.labelSettings.Name = "labelSettings";
            this.labelSettings.Size = new System.Drawing.Size(76, 24);
            this.labelSettings.TabIndex = 3;
            this.labelSettings.Text = "Settings";
            // 
            // comboTicket
            // 
            this.comboTicket.FormattingEnabled = true;
            this.comboTicket.Items.AddRange(new object[] {
            "usd"});
            this.comboTicket.Location = new System.Drawing.Point(12, 57);
            this.comboTicket.Name = "comboTicket";
            this.comboTicket.Size = new System.Drawing.Size(66, 21);
            this.comboTicket.TabIndex = 4;
            this.comboTicket.SelectedIndexChanged += new System.EventHandler(this.comboTicketSelectedIndexChanged);
            // 
            // labelTicket
            // 
            this.labelTicket.AutoSize = true;
            this.labelTicket.Location = new System.Drawing.Point(13, 41);
            this.labelTicket.Name = "labelTicket";
            this.labelTicket.Size = new System.Drawing.Size(37, 13);
            this.labelTicket.TabIndex = 5;
            this.labelTicket.Text = "Ticket";
            // 
            // comboYear
            // 
            this.comboYear.FormattingEnabled = true;
            this.comboYear.Items.AddRange(new object[] {
            "2015"});
            this.comboYear.Location = new System.Drawing.Point(11, 137);
            this.comboYear.Name = "comboYear";
            this.comboYear.Size = new System.Drawing.Size(67, 21);
            this.comboYear.TabIndex = 6;
            this.comboYear.SelectedIndexChanged += new System.EventHandler(this.comboYearSelectedIndexChanged);
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(12, 121);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(29, 13);
            this.labelYear.TabIndex = 7;
            this.labelYear.Text = "Year";
            // 
            // comboTimeFrame
            // 
            this.comboTimeFrame.FormattingEnabled = true;
            this.comboTimeFrame.Items.AddRange(new object[] {
            "1min"});
            this.comboTimeFrame.Location = new System.Drawing.Point(12, 97);
            this.comboTimeFrame.Name = "comboTimeFrame";
            this.comboTimeFrame.Size = new System.Drawing.Size(66, 21);
            this.comboTimeFrame.TabIndex = 8;
            this.comboTimeFrame.SelectedIndexChanged += new System.EventHandler(this.comboTimeFrameSelectedIndexChanged);
            // 
            // labelTimeFrame
            // 
            this.labelTimeFrame.AutoSize = true;
            this.labelTimeFrame.Location = new System.Drawing.Point(13, 81);
            this.labelTimeFrame.Name = "labelTimeFrame";
            this.labelTimeFrame.Size = new System.Drawing.Size(59, 13);
            this.labelTimeFrame.TabIndex = 9;
            this.labelTimeFrame.Text = "Time frame";
            // 
            // buttonZoom
            // 
            this.buttonZoom.Location = new System.Drawing.Point(96, 135);
            this.buttonZoom.Name = "buttonZoom";
            this.buttonZoom.Size = new System.Drawing.Size(90, 23);
            this.buttonZoom.TabIndex = 10;
            this.buttonZoom.Text = "zoom out";
            this.buttonZoom.UseVisualStyleBackColor = true;
            this.buttonZoom.Click += new System.EventHandler(this.buttonZoomClick);
            // 
            // buttonView
            // 
            this.buttonView.Location = new System.Drawing.Point(98, 95);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(88, 23);
            this.buttonView.TabIndex = 11;
            this.buttonView.Text = "view";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonViewClick);
            // 
            // comboStrategy
            // 
            this.comboStrategy.FormattingEnabled = true;
            this.comboStrategy.Items.AddRange(new object[] {
            "approximation",
            "averagining"});
            this.comboStrategy.Location = new System.Drawing.Point(95, 56);
            this.comboStrategy.Name = "comboStrategy";
            this.comboStrategy.Size = new System.Drawing.Size(95, 21);
            this.comboStrategy.TabIndex = 12;
            this.comboStrategy.SelectedIndexChanged += new System.EventHandler(this.comboStrategySelectedIndexChanged);
            // 
            // labelStrategy
            // 
            this.labelStrategy.AutoSize = true;
            this.labelStrategy.Location = new System.Drawing.Point(95, 41);
            this.labelStrategy.Name = "labelStrategy";
            this.labelStrategy.Size = new System.Drawing.Size(46, 13);
            this.labelStrategy.TabIndex = 13;
            this.labelStrategy.Text = "Strategy";
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 664);
            this.Controls.Add(this.labelStrategy);
            this.Controls.Add(this.comboStrategy);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.buttonZoom);
            this.Controls.Add(this.labelTimeFrame);
            this.Controls.Add(this.comboTimeFrame);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.comboYear);
            this.Controls.Add(this.labelTicket);
            this.Controls.Add(this.comboTicket);
            this.Controls.Add(this.labelSettings);
            this.Controls.Add(this.dataGridSummary);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.controlZedGraph);
            this.Name = "ApplicationForm";
            this.Text = "resultVisualisation";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSummary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private ZedGraphControl controlZedGraph;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView dataGridSummary;
        private System.Windows.Forms.Label labelSettings;
        private System.Windows.Forms.ComboBox comboTicket;
        private System.Windows.Forms.Label labelTicket;
        private System.Windows.Forms.ComboBox comboYear;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.ComboBox comboTimeFrame;
        private System.Windows.Forms.Label labelTimeFrame;
        private System.Windows.Forms.Button buttonZoom;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.ComboBox comboStrategy;
        private System.Windows.Forms.Label labelStrategy;
    }
}

