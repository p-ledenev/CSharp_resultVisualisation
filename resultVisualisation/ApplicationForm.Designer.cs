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
            this.comboTicket = new System.Windows.Forms.ComboBox();
            this.labelTicket = new System.Windows.Forms.Label();
            this.comboYear = new System.Windows.Forms.ComboBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.comboSieveParam = new System.Windows.Forms.ComboBox();
            this.labelSieveParam = new System.Windows.Forms.Label();
            this.buttonZoom = new System.Windows.Forms.Button();
            this.buttonView = new System.Windows.Forms.Button();
            this.comboStrategy = new System.Windows.Forms.ComboBox();
            this.labelStrategy = new System.Windows.Forms.Label();
            this.comboFillingGapsNumber = new System.Windows.Forms.ComboBox();
            this.labelFillingGapsNumber = new System.Windows.Forms.Label();
            this.dataFileInfo = new System.Windows.Forms.Label();
            this.averageCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // controlZedGraph
            // 
            this.controlZedGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlZedGraph.AutoSize = true;
            this.controlZedGraph.Location = new System.Drawing.Point(0, 149);
            this.controlZedGraph.Name = "controlZedGraph";
            this.controlZedGraph.ScrollGrace = 0D;
            this.controlZedGraph.ScrollMaxX = 0D;
            this.controlZedGraph.ScrollMaxY = 0D;
            this.controlZedGraph.ScrollMaxY2 = 0D;
            this.controlZedGraph.ScrollMinX = 0D;
            this.controlZedGraph.ScrollMinY = 0D;
            this.controlZedGraph.ScrollMinY2 = 0D;
            this.controlZedGraph.Size = new System.Drawing.Size(1352, 515);
            this.controlZedGraph.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1352, 143);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // dataGridSummary
            // 
            this.dataGridSummary.AllowUserToOrderColumns = true;
            this.dataGridSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSummary.Location = new System.Drawing.Point(305, 0);
            this.dataGridSummary.Name = "dataGridSummary";
            this.dataGridSummary.Size = new System.Drawing.Size(1047, 143);
            this.dataGridSummary.TabIndex = 2;
            // 
            // comboTicket
            // 
            this.comboTicket.FormattingEnabled = true;
            this.comboTicket.Location = new System.Drawing.Point(11, 25);
            this.comboTicket.Name = "comboTicket";
            this.comboTicket.Size = new System.Drawing.Size(66, 21);
            this.comboTicket.TabIndex = 4;
            this.comboTicket.SelectedIndexChanged += new System.EventHandler(this.comboTicketSelectedIndexChanged);
            // 
            // labelTicket
            // 
            this.labelTicket.AutoSize = true;
            this.labelTicket.Location = new System.Drawing.Point(12, 9);
            this.labelTicket.Name = "labelTicket";
            this.labelTicket.Size = new System.Drawing.Size(37, 13);
            this.labelTicket.TabIndex = 5;
            this.labelTicket.Text = "Ticket";
            // 
            // comboYear
            // 
            this.comboYear.FormattingEnabled = true;
            this.comboYear.Location = new System.Drawing.Point(10, 76);
            this.comboYear.Name = "comboYear";
            this.comboYear.Size = new System.Drawing.Size(67, 21);
            this.comboYear.TabIndex = 6;
            this.comboYear.SelectedIndexChanged += new System.EventHandler(this.comboYearSelectedIndexChanged);
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(12, 60);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(29, 13);
            this.labelYear.TabIndex = 7;
            this.labelYear.Text = "Year";
            // 
            // comboSieveParam
            // 
            this.comboSieveParam.FormattingEnabled = true;
            this.comboSieveParam.Location = new System.Drawing.Point(94, 76);
            this.comboSieveParam.Name = "comboSieveParam";
            this.comboSieveParam.Size = new System.Drawing.Size(88, 21);
            this.comboSieveParam.TabIndex = 8;
            this.comboSieveParam.SelectedIndexChanged += new System.EventHandler(this.comboSieveParamSelectedIndexChanged);
            // 
            // labelSieveParam
            // 
            this.labelSieveParam.AutoSize = true;
            this.labelSieveParam.Location = new System.Drawing.Point(94, 60);
            this.labelSieveParam.Name = "labelSieveParam";
            this.labelSieveParam.Size = new System.Drawing.Size(84, 13);
            this.labelSieveParam.TabIndex = 9;
            this.labelSieveParam.Text = "Sieve Param (%)";
            // 
            // buttonZoom
            // 
            this.buttonZoom.Location = new System.Drawing.Point(30, 120);
            this.buttonZoom.Name = "buttonZoom";
            this.buttonZoom.Size = new System.Drawing.Size(90, 23);
            this.buttonZoom.TabIndex = 10;
            this.buttonZoom.Text = "zoom out";
            this.buttonZoom.UseVisualStyleBackColor = true;
            this.buttonZoom.Click += new System.EventHandler(this.buttonZoomClick);
            // 
            // buttonView
            // 
            this.buttonView.Location = new System.Drawing.Point(146, 120);
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
            this.comboStrategy.Location = new System.Drawing.Point(94, 25);
            this.comboStrategy.Name = "comboStrategy";
            this.comboStrategy.Size = new System.Drawing.Size(195, 21);
            this.comboStrategy.TabIndex = 12;
            this.comboStrategy.SelectedIndexChanged += new System.EventHandler(this.comboStrategySelectedIndexChanged);
            // 
            // labelStrategy
            // 
            this.labelStrategy.AutoSize = true;
            this.labelStrategy.Location = new System.Drawing.Point(94, 9);
            this.labelStrategy.Name = "labelStrategy";
            this.labelStrategy.Size = new System.Drawing.Size(46, 13);
            this.labelStrategy.TabIndex = 13;
            this.labelStrategy.Text = "Strategy";
            // 
            // comboFillingGapsNumber
            // 
            this.comboFillingGapsNumber.FormattingEnabled = true;
            this.comboFillingGapsNumber.Location = new System.Drawing.Point(201, 76);
            this.comboFillingGapsNumber.Name = "comboFillingGapsNumber";
            this.comboFillingGapsNumber.Size = new System.Drawing.Size(88, 21);
            this.comboFillingGapsNumber.TabIndex = 14;
            this.comboFillingGapsNumber.SelectedIndexChanged += new System.EventHandler(this.comboFillingGapsNumberIndexChanged);
            // 
            // labelFillingGapsNumber
            // 
            this.labelFillingGapsNumber.AutoSize = true;
            this.labelFillingGapsNumber.Location = new System.Drawing.Point(198, 60);
            this.labelFillingGapsNumber.Name = "labelFillingGapsNumber";
            this.labelFillingGapsNumber.Size = new System.Drawing.Size(101, 13);
            this.labelFillingGapsNumber.TabIndex = 15;
            this.labelFillingGapsNumber.Text = "Filling Gaps Number";
            // 
            // dataFileInfo
            // 
            this.dataFileInfo.AutoSize = true;
            this.dataFileInfo.ForeColor = System.Drawing.Color.Red;
            this.dataFileInfo.Location = new System.Drawing.Point(91, 104);
            this.dataFileInfo.Name = "dataFileInfo";
            this.dataFileInfo.Size = new System.Drawing.Size(0, 13);
            this.dataFileInfo.TabIndex = 16;
            // 
            // averageCheckBox
            // 
            this.averageCheckBox.AutoSize = true;
            this.averageCheckBox.Location = new System.Drawing.Point(260, 125);
            this.averageCheckBox.Name = "averageCheckBox";
            this.averageCheckBox.Size = new System.Drawing.Size(15, 14);
            this.averageCheckBox.TabIndex = 17;
            this.averageCheckBox.UseVisualStyleBackColor = true;
            this.averageCheckBox.CheckedChanged += new System.EventHandler(this.averageCheckBox_CheckedChanged);
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 664);
            this.Controls.Add(this.averageCheckBox);
            this.Controls.Add(this.dataFileInfo);
            this.Controls.Add(this.labelFillingGapsNumber);
            this.Controls.Add(this.comboFillingGapsNumber);
            this.Controls.Add(this.labelStrategy);
            this.Controls.Add(this.comboStrategy);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.buttonZoom);
            this.Controls.Add(this.labelSieveParam);
            this.Controls.Add(this.comboSieveParam);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.comboYear);
            this.Controls.Add(this.labelTicket);
            this.Controls.Add(this.comboTicket);
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
        private System.Windows.Forms.ComboBox comboTicket;
        private System.Windows.Forms.Label labelTicket;
        private System.Windows.Forms.ComboBox comboYear;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.ComboBox comboSieveParam;
        private System.Windows.Forms.Label labelSieveParam;
        private System.Windows.Forms.Button buttonZoom;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.ComboBox comboStrategy;
        private System.Windows.Forms.Label labelStrategy;
        private System.Windows.Forms.ComboBox comboFillingGapsNumber;
        private System.Windows.Forms.Label labelFillingGapsNumber;
        private System.Windows.Forms.Label dataFileInfo;
        private System.Windows.Forms.CheckBox averageCheckBox;
    }
}

