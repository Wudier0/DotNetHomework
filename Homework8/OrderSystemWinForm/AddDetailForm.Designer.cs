
namespace OrderSystemWinForm
{
    partial class AddDetailForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.goodsNameTextBox = new System.Windows.Forms.TextBox();
            this.goodsNameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.amountTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.priceTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.goodsNameTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.goodsNameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.idLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.priceLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.amountLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.idTextBox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(847, 266);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.amountTextBox.Location = new System.Drawing.Point(383, 219);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(292, 25);
            this.amountTextBox.TabIndex = 7;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceTextBox.Location = new System.Drawing.Point(383, 152);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(292, 25);
            this.priceTextBox.TabIndex = 6;
            // 
            // goodsNameTextBox
            // 
            this.goodsNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.goodsNameTextBox.Location = new System.Drawing.Point(383, 86);
            this.goodsNameTextBox.Name = "goodsNameTextBox";
            this.goodsNameTextBox.Size = new System.Drawing.Size(292, 25);
            this.goodsNameTextBox.TabIndex = 5;
            // 
            // goodsNameLabel
            // 
            this.goodsNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.goodsNameLabel.AutoSize = true;
            this.goodsNameLabel.Location = new System.Drawing.Point(79, 91);
            this.goodsNameLabel.Name = "goodsNameLabel";
            this.goodsNameLabel.Size = new System.Drawing.Size(52, 15);
            this.goodsNameLabel.TabIndex = 2;
            this.goodsNameLabel.Text = "货物名";
            // 
            // idLabel
            // 
            this.idLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(87, 25);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(37, 15);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "序号";
            // 
            // priceLabel
            // 
            this.priceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(87, 157);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(37, 15);
            this.priceLabel.TabIndex = 1;
            this.priceLabel.Text = "单价";
            // 
            // amountLabel
            // 
            this.amountLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(87, 224);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(37, 15);
            this.amountLabel.TabIndex = 3;
            this.amountLabel.Text = "数目";
            // 
            // idTextBox
            // 
            this.idTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idTextBox.Location = new System.Drawing.Point(383, 20);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(292, 25);
            this.idTextBox.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.confirmButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 426);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 78);
            this.panel1.TabIndex = 1;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelButton.Location = new System.Drawing.Point(535, 24);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 25);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "取消";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmButton.Location = new System.Drawing.Point(212, 24);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(100, 25);
            this.confirmButton.TabIndex = 0;
            this.confirmButton.Text = "确认";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // AddDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 504);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddDetailForm";
            this.Text = "AddDetailForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label goodsNameLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox goodsNameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button confirmButton;
    }
}