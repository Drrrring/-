
namespace SimpleCrawlerGUI
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSpecifiedUrl = new System.Windows.Forms.TextBox();
            this.cbSpecified = new System.Windows.Forms.CheckBox();
            this.lbUrl = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnStart, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtOutput, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.4438F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.5562F));
            this.tableLayoutPanel2.Controls.Add(this.txtSpecifiedUrl, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbSpecified, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbUrl, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 54);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // txtSpecifiedUrl
            // 
            this.txtSpecifiedUrl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSpecifiedUrl.Location = new System.Drawing.Point(122, 13);
            this.txtSpecifiedUrl.Name = "txtSpecifiedUrl";
            this.txtSpecifiedUrl.Size = new System.Drawing.Size(455, 27);
            this.txtSpecifiedUrl.TabIndex = 1;
            // 
            // cbSpecified
            // 
            this.cbSpecified.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbSpecified.AutoSize = true;
            this.cbSpecified.Location = new System.Drawing.Point(583, 15);
            this.cbSpecified.Name = "cbSpecified";
            this.cbSpecified.Size = new System.Drawing.Size(136, 24);
            this.cbSpecified.TabIndex = 2;
            this.cbSpecified.Text = "只在本站内爬取";
            this.cbSpecified.UseVisualStyleBackColor = true;
            // 
            // lbUrl
            // 
            this.lbUrl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbUrl.AutoSize = true;
            this.lbUrl.Location = new System.Drawing.Point(3, 17);
            this.lbUrl.Name = "lbUrl";
            this.lbUrl.Size = new System.Drawing.Size(99, 20);
            this.lbUrl.TabIndex = 3;
            this.lbUrl.Text = "爬取网站地址";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStart.Location = new System.Drawing.Point(353, 405);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(94, 29);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "开始爬取";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Location = new System.Drawing.Point(3, 63);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(794, 324);
            this.txtOutput.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtSpecifiedUrl;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.CheckBox cbSpecified;
        private System.Windows.Forms.Label lbUrl;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

