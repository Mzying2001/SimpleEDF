
namespace SimpleEDF
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openEdfButton = new System.Windows.Forms.Button();
            this.stateLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.edfHeaderPanel = new System.Windows.Forms.Panel();
            this.edfHeaderContentLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.edfSignalChartPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            this.edfHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openEdfButton
            // 
            this.openEdfButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.openEdfButton.Location = new System.Drawing.Point(0, 0);
            this.openEdfButton.Name = "openEdfButton";
            this.openEdfButton.Size = new System.Drawing.Size(75, 25);
            this.openEdfButton.TabIndex = 0;
            this.openEdfButton.Text = "Open EDF";
            this.openEdfButton.UseVisualStyleBackColor = true;
            this.openEdfButton.Click += new System.EventHandler(this.OpenEdfButtonClick);
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(81, 6);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(161, 12);
            this.stateLabel.TabIndex = 2;
            this.stateLabel.Text = "Select an EDF file to open";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.edfHeaderPanel);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(768, 156);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Header";
            // 
            // edfHeaderPanel
            // 
            this.edfHeaderPanel.AutoScroll = true;
            this.edfHeaderPanel.Controls.Add(this.edfHeaderContentLabel);
            this.edfHeaderPanel.Controls.Add(this.label1);
            this.edfHeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edfHeaderPanel.Location = new System.Drawing.Point(3, 17);
            this.edfHeaderPanel.Name = "edfHeaderPanel";
            this.edfHeaderPanel.Size = new System.Drawing.Size(762, 136);
            this.edfHeaderPanel.TabIndex = 0;
            // 
            // edfHeaderContentLabel
            // 
            this.edfHeaderContentLabel.AutoSize = true;
            this.edfHeaderContentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edfHeaderContentLabel.Location = new System.Drawing.Point(155, 0);
            this.edfHeaderContentLabel.Name = "edfHeaderContentLabel";
            this.edfHeaderContentLabel.Size = new System.Drawing.Size(11, 12);
            this.edfHeaderContentLabel.TabIndex = 1;
            this.edfHeaderContentLabel.Text = "?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 252);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Enabled = false;
            this.splitContainer1.Location = new System.Drawing.Point(8, 33);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(768, 520);
            this.splitContainer1.SplitterDistance = 156;
            this.splitContainer1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.edfSignalChartPanel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 360);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Signals";
            // 
            // edfSignalChartPanel
            // 
            this.edfSignalChartPanel.AutoScroll = true;
            this.edfSignalChartPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edfSignalChartPanel.Location = new System.Drawing.Point(3, 17);
            this.edfSignalChartPanel.Name = "edfSignalChartPanel";
            this.edfSignalChartPanel.Size = new System.Drawing.Size(762, 340);
            this.edfSignalChartPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.stateLabel);
            this.panel1.Controls.Add(this.openEdfButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 25);
            this.panel1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Text = "Sinple EDF Viewer";
            this.groupBox2.ResumeLayout(false);
            this.edfHeaderPanel.ResumeLayout(false);
            this.edfHeaderPanel.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openEdfButton;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel edfHeaderPanel;
        private System.Windows.Forms.Label edfHeaderContentLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel edfSignalChartPanel;
        private System.Windows.Forms.Panel panel1;
    }
}