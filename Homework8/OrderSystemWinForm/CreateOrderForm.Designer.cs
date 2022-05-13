
namespace OrderSystemWinForm
{
    partial class CreateOrderForm
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
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderIdTextBox = new System.Windows.Forms.TextBox();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderIdLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.orderDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsTotalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.changeDetailsButton = new System.Windows.Forms.Button();
            this.deleteDetailsButton = new System.Windows.Forms.Button();
            this.addDetailsButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.updateDetailsButton);
            this.panel1.Controls.Add(this.customerNameLabel);
            this.panel1.Controls.Add(this.customerNameTextBox);
            this.panel1.Controls.Add(this.orderIdTextBox);
            this.panel1.Controls.Add(this.orderIdLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 128);
            this.panel1.TabIndex = 0;
            // 
            // updateDetailsButton
            // 
            this.updateDetailsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateDetailsButton.Location = new System.Drawing.Point(855, 90);
            this.updateDetailsButton.Name = "updateDetailsButton";
            this.updateDetailsButton.Size = new System.Drawing.Size(75, 25);
            this.updateDetailsButton.TabIndex = 6;
            this.updateDetailsButton.Text = "刷新";
            this.updateDetailsButton.UseVisualStyleBackColor = true;
            this.updateDetailsButton.Click += new System.EventHandler(this.updateDetailsButton_Click);
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(57, 68);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(52, 15);
            this.customerNameLabel.TabIndex = 5;
            this.customerNameLabel.Text = "客户名";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Name", true));
            this.customerNameTextBox.Location = new System.Drawing.Point(135, 65);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(289, 25);
            this.customerNameTextBox.TabIndex = 3;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(OrderSystem.Customer);
            // 
            // orderIdTextBox
            // 
            this.orderIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Id", true));
            this.orderIdTextBox.Location = new System.Drawing.Point(135, 18);
            this.orderIdTextBox.Name = "orderIdTextBox";
            this.orderIdTextBox.Size = new System.Drawing.Size(289, 25);
            this.orderIdTextBox.TabIndex = 1;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(OrderSystem.Order);
            // 
            // orderIdLabel
            // 
            this.orderIdLabel.AutoSize = true;
            this.orderIdLabel.Location = new System.Drawing.Point(57, 21);
            this.orderIdLabel.Name = "orderIdLabel";
            this.orderIdLabel.Size = new System.Drawing.Size(52, 15);
            this.orderIdLabel.TabIndex = 0;
            this.orderIdLabel.Text = "订单号";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.orderDetailsDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 355);
            this.panel2.TabIndex = 1;
            // 
            // orderDetailsDataGridView
            // 
            this.orderDetailsDataGridView.AllowUserToAddRows = false;
            this.orderDetailsDataGridView.AutoGenerateColumns = false;
            this.orderDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.goodsNameDataGridViewTextBoxColumn,
            this.goodsPriceDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.goodsTotalPriceDataGridViewTextBoxColumn});
            this.orderDetailsDataGridView.DataSource = this.detailsBindingSource;
            this.orderDetailsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderDetailsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.orderDetailsDataGridView.Name = "orderDetailsDataGridView";
            this.orderDetailsDataGridView.RowHeadersWidth = 51;
            this.orderDetailsDataGridView.RowTemplate.Height = 27;
            this.orderDetailsDataGridView.Size = new System.Drawing.Size(984, 355);
            this.orderDetailsDataGridView.TabIndex = 0;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.confirmButton);
            this.panel3.Controls.Add(this.cancelButton);
            this.panel3.Controls.Add(this.changeDetailsButton);
            this.panel3.Controls.Add(this.deleteDetailsButton);
            this.panel3.Controls.Add(this.addDetailsButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 409);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(984, 74);
            this.panel3.TabIndex = 2;
            // 
            // confirmButton
            // 
            this.confirmButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmButton.Location = new System.Drawing.Point(689, 25);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(98, 28);
            this.confirmButton.TabIndex = 4;
            this.confirmButton.Text = "确认";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelButton.Location = new System.Drawing.Point(843, 25);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(98, 28);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "取消";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // changeDetailsButton
            // 
            this.changeDetailsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.changeDetailsButton.Location = new System.Drawing.Point(189, 25);
            this.changeDetailsButton.Name = "changeDetailsButton";
            this.changeDetailsButton.Size = new System.Drawing.Size(98, 28);
            this.changeDetailsButton.TabIndex = 2;
            this.changeDetailsButton.Text = "修改明细";
            this.changeDetailsButton.UseVisualStyleBackColor = true;
            this.changeDetailsButton.Click += new System.EventHandler(this.changeDetailsButton_Click);
            // 
            // deleteDetailsButton
            // 
            this.deleteDetailsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteDetailsButton.Location = new System.Drawing.Point(344, 25);
            this.deleteDetailsButton.Name = "deleteDetailsButton";
            this.deleteDetailsButton.Size = new System.Drawing.Size(98, 28);
            this.deleteDetailsButton.TabIndex = 1;
            this.deleteDetailsButton.Text = "删除明细";
            this.deleteDetailsButton.UseVisualStyleBackColor = true;
            this.deleteDetailsButton.Click += new System.EventHandler(this.deleteDetailsButton_Click);
            // 
            // addDetailsButton
            // 
            this.addDetailsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addDetailsButton.Location = new System.Drawing.Point(42, 25);
            this.addDetailsButton.Name = "addDetailsButton";
            this.addDetailsButton.Size = new System.Drawing.Size(98, 28);
            this.addDetailsButton.TabIndex = 0;
            this.addDetailsButton.Text = "添加明细";
            this.addDetailsButton.UseVisualStyleBackColor = true;
            this.addDetailsButton.Click += new System.EventHandler(this.addDetailsButton_Click);
            // 
            // CreateOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 483);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CreateOrderForm";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView orderDetailsDataGridView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label orderIdLabel;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox orderIdTextBox;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button changeDetailsButton;
        private System.Windows.Forms.Button deleteDetailsButton;
        private System.Windows.Forms.Button addDetailsButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsTotalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.BindingSource detailsBindingSource;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.Button updateDetailsButton;
    }
}