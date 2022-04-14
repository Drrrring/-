
namespace OrderManagementSystemGUI
{
    partial class SubForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddDetial = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbClientName = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.lbClinetID = new System.Windows.Forms.Label();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.lbAddDetail = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbGoodsName = new System.Windows.Forms.Label();
            this.txtGoodName = new System.Windows.Forms.TextBox();
            this.lbSinglePrice = new System.Windows.Forms.Label();
            this.txtSinglePrice = new System.Windows.Forms.TextBox();
            this.lbAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.goodsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbAddDetail, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvDetails, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 224F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 360);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btnAddDetial);
            this.flowLayoutPanel3.Controls.Add(this.btnConfirm);
            this.flowLayoutPanel3.Controls.Add(this.btnCancel);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(2, 322);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(596, 44);
            this.flowLayoutPanel3.TabIndex = 4;
            // 
            // btnAddDetial
            // 
            this.btnAddDetial.Location = new System.Drawing.Point(2, 2);
            this.btnAddDetial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddDetial.Name = "btnAddDetial";
            this.btnAddDetial.Size = new System.Drawing.Size(74, 26);
            this.btnAddDetial.TabIndex = 4;
            this.btnAddDetial.Text = "添加详情";
            this.btnAddDetial.UseVisualStyleBackColor = true;
            this.btnAddDetial.Click += new System.EventHandler(this.btnAddDetial_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(80, 2);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(64, 26);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(148, 2);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(69, 26);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lbClientName);
            this.flowLayoutPanel1.Controls.Add(this.txtClientName);
            this.flowLayoutPanel1.Controls.Add(this.lbClinetID);
            this.flowLayoutPanel1.Controls.Add(this.txtClientID);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(596, 28);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lbClientName
            // 
            this.lbClientName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbClientName.AutoSize = true;
            this.lbClientName.Location = new System.Drawing.Point(2, 6);
            this.lbClientName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbClientName.Name = "lbClientName";
            this.lbClientName.Size = new System.Drawing.Size(53, 12);
            this.lbClientName.TabIndex = 0;
            this.lbClientName.Text = "客户名：";
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(59, 2);
            this.txtClientName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(96, 21);
            this.txtClientName.TabIndex = 1;
            // 
            // lbClinetID
            // 
            this.lbClinetID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbClinetID.AutoSize = true;
            this.lbClinetID.Location = new System.Drawing.Point(159, 6);
            this.lbClinetID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbClinetID.Name = "lbClinetID";
            this.lbClinetID.Size = new System.Drawing.Size(53, 12);
            this.lbClinetID.TabIndex = 2;
            this.lbClinetID.Text = "客户ID：";
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(216, 2);
            this.txtClientID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(104, 21);
            this.txtClientID.TabIndex = 3;
            // 
            // lbAddDetail
            // 
            this.lbAddDetail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbAddDetail.AutoSize = true;
            this.lbAddDetail.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbAddDetail.Location = new System.Drawing.Point(2, 40);
            this.lbAddDetail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAddDetail.Name = "lbAddDetail";
            this.lbAddDetail.Size = new System.Drawing.Size(110, 16);
            this.lbAddDetail.TabIndex = 1;
            this.lbAddDetail.Text = "添加订单详情";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lbGoodsName);
            this.flowLayoutPanel2.Controls.Add(this.txtGoodName);
            this.flowLayoutPanel2.Controls.Add(this.lbSinglePrice);
            this.flowLayoutPanel2.Controls.Add(this.txtSinglePrice);
            this.flowLayoutPanel2.Controls.Add(this.lbAmount);
            this.flowLayoutPanel2.Controls.Add(this.txtAmount);
            this.flowLayoutPanel2.Controls.Add(this.lbDiscount);
            this.flowLayoutPanel2.Controls.Add(this.txtDiscount);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(2, 66);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(596, 28);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // lbGoodsName
            // 
            this.lbGoodsName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbGoodsName.AutoSize = true;
            this.lbGoodsName.Location = new System.Drawing.Point(2, 6);
            this.lbGoodsName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGoodsName.Name = "lbGoodsName";
            this.lbGoodsName.Size = new System.Drawing.Size(53, 12);
            this.lbGoodsName.TabIndex = 3;
            this.lbGoodsName.Text = "货物名：";
            // 
            // txtGoodName
            // 
            this.txtGoodName.Location = new System.Drawing.Point(59, 2);
            this.txtGoodName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGoodName.Name = "txtGoodName";
            this.txtGoodName.Size = new System.Drawing.Size(76, 21);
            this.txtGoodName.TabIndex = 4;
            // 
            // lbSinglePrice
            // 
            this.lbSinglePrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbSinglePrice.AutoSize = true;
            this.lbSinglePrice.Location = new System.Drawing.Point(139, 6);
            this.lbSinglePrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSinglePrice.Name = "lbSinglePrice";
            this.lbSinglePrice.Size = new System.Drawing.Size(41, 12);
            this.lbSinglePrice.TabIndex = 5;
            this.lbSinglePrice.Text = "单价：";
            // 
            // txtSinglePrice
            // 
            this.txtSinglePrice.Location = new System.Drawing.Point(184, 2);
            this.txtSinglePrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSinglePrice.Name = "txtSinglePrice";
            this.txtSinglePrice.Size = new System.Drawing.Size(76, 21);
            this.txtSinglePrice.TabIndex = 6;
            // 
            // lbAmount
            // 
            this.lbAmount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbAmount.AutoSize = true;
            this.lbAmount.Location = new System.Drawing.Point(264, 6);
            this.lbAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(41, 12);
            this.lbAmount.TabIndex = 7;
            this.lbAmount.Text = "数量：";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(309, 2);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(76, 21);
            this.txtAmount.TabIndex = 8;
            // 
            // lbDiscount
            // 
            this.lbDiscount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Location = new System.Drawing.Point(389, 6);
            this.lbDiscount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(41, 12);
            this.lbDiscount.TabIndex = 9;
            this.lbDiscount.Text = "折扣：";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(434, 2);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(76, 21);
            this.txtDiscount.TabIndex = 10;
            // 
            // dgvDetails
            // 
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.AllowUserToDeleteRows = false;
            this.dgvDetails.AutoGenerateColumns = false;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodsDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn});
            this.dgvDetails.DataSource = this.detailsBindingSource;
            this.dgvDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetails.Location = new System.Drawing.Point(2, 98);
            this.dgvDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.RowHeadersWidth = 51;
            this.dgvDetails.RowTemplate.Height = 27;
            this.dgvDetails.Size = new System.Drawing.Size(596, 220);
            this.dgvDetails.TabIndex = 5;
            // 
            // goodsDataGridViewTextBoxColumn
            // 
            this.goodsDataGridViewTextBoxColumn.DataPropertyName = "Goods";
            this.goodsDataGridViewTextBoxColumn.HeaderText = "Goods";
            this.goodsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodsDataGridViewTextBoxColumn.Name = "goodsDataGridViewTextBoxColumn";
            this.goodsDataGridViewTextBoxColumn.Width = 125;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Count";
            this.countDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.Width = 125;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "Discount";
            this.discountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            this.discountDataGridViewTextBoxColumn.Width = 125;
            // 
            // detailsBindingSource
            // 
            this.detailsBindingSource.DataSource = typeof(OrderManagementSystem.OrderDetail);
            // 
            // SubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SubForm";
            this.Text = "SubForm";
            this.Load += new System.EventHandler(this.SubForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbClientName;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label lbClinetID;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Label lbAddDetail;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lbGoodsName;
        private System.Windows.Forms.TextBox txtGoodName;
        private System.Windows.Forms.Label lbSinglePrice;
        private System.Windows.Forms.TextBox txtSinglePrice;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button btnAddDetial;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.BindingSource detailsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
    }
}