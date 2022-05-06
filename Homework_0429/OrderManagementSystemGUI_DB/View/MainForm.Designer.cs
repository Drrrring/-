
namespace OrderManagementSystemGUI_DB
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtQueryInput = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnModifyOrder = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnExportOrder = new System.Windows.Forms.Button();
            this.btnImportOrder = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvOrderDetails = new System.Windows.Forms.DataGridView();
            this.goodsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1333, 593);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.btnQuery, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtQueryInput, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBox1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1327, 54);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnQuery.Location = new System.Drawing.Point(553, 8);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(125, 38);
            this.btnQuery.TabIndex = 0;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtQueryInput
            // 
            this.txtQueryInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtQueryInput.Location = new System.Drawing.Point(153, 14);
            this.txtQueryInput.Name = "txtQueryInput";
            this.txtQueryInput.Size = new System.Drawing.Size(295, 25);
            this.txtQueryInput.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 745F));
            this.tableLayoutPanel3.Controls.Add(this.btnAddOrder, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnModifyOrder, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnDeleteOrder, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnExportOrder, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnImportOrder, 4, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 63);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1145, 39);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddOrder.Location = new System.Drawing.Point(3, 3);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(94, 33);
            this.btnAddOrder.TabIndex = 0;
            this.btnAddOrder.Text = "添加订单";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnModifyOrder
            // 
            this.btnModifyOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModifyOrder.Location = new System.Drawing.Point(103, 3);
            this.btnModifyOrder.Name = "btnModifyOrder";
            this.btnModifyOrder.Size = new System.Drawing.Size(94, 33);
            this.btnModifyOrder.TabIndex = 1;
            this.btnModifyOrder.Text = "修改订单";
            this.btnModifyOrder.UseVisualStyleBackColor = true;
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteOrder.Location = new System.Drawing.Point(203, 3);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(94, 33);
            this.btnDeleteOrder.TabIndex = 2;
            this.btnDeleteOrder.Text = "删除订单";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // btnExportOrder
            // 
            this.btnExportOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExportOrder.Location = new System.Drawing.Point(303, 3);
            this.btnExportOrder.Name = "btnExportOrder";
            this.btnExportOrder.Size = new System.Drawing.Size(94, 33);
            this.btnExportOrder.TabIndex = 3;
            this.btnExportOrder.Text = "导出订单";
            this.btnExportOrder.UseVisualStyleBackColor = true;
            this.btnExportOrder.Click += new System.EventHandler(this.btnExportOrder_Click);
            // 
            // btnImportOrder
            // 
            this.btnImportOrder.Location = new System.Drawing.Point(403, 3);
            this.btnImportOrder.Name = "btnImportOrder";
            this.btnImportOrder.Size = new System.Drawing.Size(94, 33);
            this.btnImportOrder.TabIndex = 4;
            this.btnImportOrder.Text = "导入订单";
            this.btnImportOrder.UseVisualStyleBackColor = true;
            this.btnImportOrder.Click += new System.EventHandler(this.btnImportOrder_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 108);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvOrders);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvOrderDetails);
            this.splitContainer1.Size = new System.Drawing.Size(1327, 482);
            this.splitContainer1.SplitterDistance = 681;
            this.splitContainer1.TabIndex = 2;
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AutoGenerateColumns = false;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvOrders.DataSource = this.orderBindingSource;
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.Location = new System.Drawing.Point(0, 0);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.RowTemplate.Height = 27;
            this.dgvOrders.Size = new System.Drawing.Size(681, 482);
            this.dgvOrders.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Client";
            this.dataGridViewTextBoxColumn2.HeaderText = "Client";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn3.HeaderText = "Price";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(OrderManagementSystemGUI_DB.Order);
            // 
            // dgvOrderDetails
            // 
            this.dgvOrderDetails.AllowUserToAddRows = false;
            this.dgvOrderDetails.AllowUserToDeleteRows = false;
            this.dgvOrderDetails.AutoGenerateColumns = false;
            this.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodsDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.Discount});
            this.dgvOrderDetails.DataSource = this.orderDetailsBindingSource;
            this.dgvOrderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvOrderDetails.Name = "dgvOrderDetails";
            this.dgvOrderDetails.RowHeadersWidth = 51;
            this.dgvOrderDetails.RowTemplate.Height = 27;
            this.dgvOrderDetails.Size = new System.Drawing.Size(642, 482);
            this.dgvOrderDetails.TabIndex = 0;
            // 
            // goodsDataGridViewTextBoxColumn
            // 
            this.goodsDataGridViewTextBoxColumn.DataPropertyName = "Goods";
            this.goodsDataGridViewTextBoxColumn.HeaderText = "Goods";
            this.goodsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodsDataGridViewTextBoxColumn.Name = "goodsDataGridViewTextBoxColumn";
            this.goodsDataGridViewTextBoxColumn.Width = 350;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Count";
            this.countDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.Width = 125;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            this.Discount.HeaderText = "Discount";
            this.Discount.MinimumWidth = 6;
            this.Discount.Name = "Discount";
            this.Discount.Width = 125;
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataMember = "OrderDetails";
            this.orderDetailsBindingSource.DataSource = this.orderBindingSource;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "orders";
            this.saveFileDialog1.Filter = "xml文件|*.xml|所有文件|*.*";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 593);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "订单管理系统";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtQueryInput;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnModifyOrder;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnExportOrder;
        private System.Windows.Forms.Button btnImportOrder;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.DataGridView dgvOrderDetails;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        public System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}

