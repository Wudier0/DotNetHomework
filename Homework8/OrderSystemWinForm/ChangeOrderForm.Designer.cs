
namespace OrderSystemWinForm
{
    partial class ChangeOrderForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.updateDetailsButton = new System.Windows.Forms.Button();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.orderIdTextBox = new System.Windows.Forms.TextBox();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderIdLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.deleteDetailButton = new System.Windows.Forms.Button();
            this.changeDetailButton = new System.Windows.Forms.Button();
            this.addDetailButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsTotalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.updateDetailsButton);
            this.panel1.Controls.Add(this.customerNameTextBox);
            this.panel1.Controls.Add(this.customerNameLabel);
            this.panel1.Controls.Add(this.orderIdTextBox);
            this.panel1.Controls.Add(this.orderIdLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 148);
            this.panel1.TabIndex = 0;
            // 
            // updateDetailsButton
            // 
            this.updateDetailsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateDetailsButton.Location = new System.Drawing.Point(692, 85);
            this.updateDetailsButton.Name = "updateDetailsButton";
            this.updateDetailsButton.Size = new System.Drawing.Size(75, 25);
            this.updateDetailsButton.TabIndex = 4;
            this.updateDetailsButton.Text = "刷新";
            this.updateDetailsButton.UseVisualStyleBackColor = true;
            this.updateDetailsButton.Click += new System.EventHandler(this.updateDetailsButton_Click);
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Name", true));
            this.customerNameTextBox.Location = new System.Drawing.Point(191, 82);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(267, 25);
            this.customerNameTextBox.TabIndex = 3;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(OrderSystem.Customer);
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(70, 85);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(52, 15);
            this.customerNameLabel.TabIndex = 2;
            this.customerNameLabel.Text = "客户名";
            // 
            // orderIdTextBox
            // 
            this.orderIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Id", true));
            this.orderIdTextBox.Location = new System.Drawing.Point(191, 32);
            this.orderIdTextBox.Name = "orderIdTextBox";
            this.orderIdTextBox.Size = new System.Drawing.Size(267, 25);
            this.orderIdTextBox.TabIndex = 1;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(OrderSystem.Order);
            // 
            // orderIdLabel
            // 
            this.orderIdLabel.AutoSize = true;
            this.orderIdLabel.Location = new System.Drawing.Point(70, 35);
            this.orderIdLabel.Name = "orderIdLabel";
            this.orderIdLabel.Size = new System.Drawing.Size(52, 15);
            this.orderIdLabel.TabIndex = 0;
            this.orderIdLabel.Text = "订单号";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cancelButton);
            this.panel2.Controls.Add(this.confirmButton);
            this.panel2.Controls.Add(this.deleteDetailButton);
            this.panel2.Controls.Add(this.changeDetailButton);
            this.panel2.Controls.Add(this.addDetailButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 381);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 69);
            this.panel2.TabIndex = 1;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(692, 25);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 25);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "取消";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(581, 25);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 25);
            this.confirmButton.TabIndex = 3;
            this.confirmButton.Text = "确认";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // deleteDetailButton
            // 
            this.deleteDetailButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteDetailButton.Location = new System.Drawing.Point(263, 25);
            this.deleteDetailButton.Name = "deleteDetailButton";
            this.deleteDetailButton.Size = new System.Drawing.Size(75, 25);
            this.deleteDetailButton.TabIndex = 2;
            this.deleteDetailButton.Text = "删除明细";
            this.deleteDetailButton.UseVisualStyleBackColor = true;
            this.deleteDetailButton.Click += new System.EventHandler(this.deleteDetailButton_Click);
            // 
            // changeDetailButton
            // 
            this.changeDetailButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.changeDetailButton.Location = new System.Drawing.Point(153, 25);
            this.changeDetailButton.Name = "changeDetailButton";
            this.changeDetailButton.Size = new System.Drawing.Size(75, 25);
            this.changeDetailButton.TabIndex = 1;
            this.changeDetailButton.Text = "修改明细";
            this.changeDetailButton.UseVisualStyleBackColor = true;
            // 
            // addDetailButton
            // 
            this.addDetailButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addDetailButton.Location = new System.Drawing.Point(47, 25);
            this.addDetailButton.Name = "addDetailButton";
            this.addDetailButton.Size = new System.Drawing.Size(75, 25);
            this.addDetailButton.TabIndex = 0;
            this.addDetailButton.Text = "添加明细";
            this.addDetailButton.UseVisualStyleBackColor = true;
            this.addDetailButton.Click += new System.EventHandler(this.addDetailButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.goodsNameDataGridViewTextBoxColumn,
            this.goodsPriceDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.goodsTotalPriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.detailsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(800, 233);
            this.dataGridView1.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "序号";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // goodsNameDataGridViewTextBoxColumn
            // 
            this.goodsNameDataGridViewTextBoxColumn.DataPropertyName = "GoodsName";
            this.goodsNameDataGridViewTextBoxColumn.HeaderText = "货物名";
            this.goodsNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodsNameDataGridViewTextBoxColumn.Name = "goodsNameDataGridViewTextBoxColumn";
            this.goodsNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.goodsNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // goodsPriceDataGridViewTextBoxColumn
            // 
            this.goodsPriceDataGridViewTextBoxColumn.DataPropertyName = "GoodsPrice";
            this.goodsPriceDataGridViewTextBoxColumn.HeaderText = "单价";
            this.goodsPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodsPriceDataGridViewTextBoxColumn.Name = "goodsPriceDataGridViewTextBoxColumn";
            this.goodsPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.goodsPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "数目";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // goodsTotalPriceDataGridViewTextBoxColumn
            // 
            this.goodsTotalPriceDataGridViewTextBoxColumn.DataPropertyName = "GoodsTotalPrice";
            this.goodsTotalPriceDataGridViewTextBoxColumn.HeaderText = "货物总价";
            this.goodsTotalPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodsTotalPriceDataGridViewTextBoxColumn.Name = "goodsTotalPriceDataGridViewTextBoxColumn";
            this.goodsTotalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.goodsTotalPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // detailsBindingSource
            // 
            this.detailsBindingSource.DataMember = "Details";
            this.detailsBindingSource.DataSource = this.orderBindingSource;
            // 
            // ChangeOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ChangeOrderForm";
            this.Text = "ChangeOrderForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.TextBox orderIdTextBox;
        private System.Windows.Forms.Label orderIdLabel;
        private System.Windows.Forms.Button updateDetailsButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button deleteDetailButton;
        private System.Windows.Forms.Button changeDetailButton;
        private System.Windows.Forms.Button addDetailButton;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsTotalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource detailsBindingSource;
    }
}