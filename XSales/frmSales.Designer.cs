namespace XSales
{
    partial class frmSales
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
            System.Windows.Forms.Label billAmuntLabel;
            System.Windows.Forms.Label userIDLabel;
            System.Windows.Forms.Label itemBarCodeLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.billAmuntLabel1 = new System.Windows.Forms.Label();
            this.userIDLabel1 = new System.Windows.Forms.Label();
            this.itemBarCodeRadTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.storesDataGridViewX = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColExpirdDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            billAmuntLabel = new System.Windows.Forms.Label();
            userIDLabel = new System.Windows.Forms.Label();
            itemBarCodeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemBarCodeRadTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesDataGridViewX)).BeginInit();
            this.SuspendLayout();
            // 
            // billAmuntLabel
            // 
            billAmuntLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            billAmuntLabel.AutoSize = true;
            billAmuntLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            billAmuntLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            billAmuntLabel.Location = new System.Drawing.Point(28, 26);
            billAmuntLabel.Name = "billAmuntLabel";
            billAmuntLabel.Size = new System.Drawing.Size(80, 23);
            billAmuntLabel.TabIndex = 1;
            billAmuntLabel.Text = "المبلغ الكلي";
            // 
            // userIDLabel
            // 
            userIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            userIDLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            userIDLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            userIDLabel.Location = new System.Drawing.Point(28, 59);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new System.Drawing.Size(78, 23);
            userIDLabel.TabIndex = 2;
            userIDLabel.Text = "الموظف";
            // 
            // itemBarCodeLabel
            // 
            itemBarCodeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            itemBarCodeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            itemBarCodeLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            itemBarCodeLabel.Location = new System.Drawing.Point(27, 88);
            itemBarCodeLabel.Name = "itemBarCodeLabel";
            itemBarCodeLabel.Size = new System.Drawing.Size(106, 27);
            itemBarCodeLabel.TabIndex = 4;
            itemBarCodeLabel.Text = "الباركود";
            // 
            // billAmuntLabel1
            // 
            this.billAmuntLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.billAmuntLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.billAmuntLabel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.billAmuntLabel1.Location = new System.Drawing.Point(112, 26);
            this.billAmuntLabel1.Name = "billAmuntLabel1";
            this.billAmuntLabel1.Size = new System.Drawing.Size(524, 23);
            this.billAmuntLabel1.TabIndex = 2;
            this.billAmuntLabel1.Text = "label1";
            // 
            // userIDLabel1
            // 
            this.userIDLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userIDLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userIDLabel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.userIDLabel1.Location = new System.Drawing.Point(112, 59);
            this.userIDLabel1.Name = "userIDLabel1";
            this.userIDLabel1.Size = new System.Drawing.Size(524, 23);
            this.userIDLabel1.TabIndex = 3;
            this.userIDLabel1.Text = "label1";
            // 
            // itemBarCodeRadTextBox
            // 
            this.itemBarCodeRadTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.itemBarCodeRadTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.itemBarCodeRadTextBox.Location = new System.Drawing.Point(139, 87);
            this.itemBarCodeRadTextBox.Name = "itemBarCodeRadTextBox";
            this.itemBarCodeRadTextBox.Size = new System.Drawing.Size(497, 27);
            this.itemBarCodeRadTextBox.TabIndex = 5;
            this.itemBarCodeRadTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.itemBarCodeRadTextBox_KeyDown);
            // 
            // storesDataGridViewX
            // 
            this.storesDataGridViewX.AllowUserToAddRows = false;
            this.storesDataGridViewX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.storesDataGridViewX.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.storesDataGridViewX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storesDataGridViewX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ColItem,
            this.ColPrice,
            this.ColQty,
            this.ColExpirdDate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.storesDataGridViewX.DefaultCellStyle = dataGridViewCellStyle2;
            this.storesDataGridViewX.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.storesDataGridViewX.Location = new System.Drawing.Point(27, 120);
            this.storesDataGridViewX.Name = "storesDataGridViewX";
            this.storesDataGridViewX.Size = new System.Drawing.Size(1013, 388);
            this.storesDataGridViewX.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 31.58165F;
            this.Column1.HeaderText = "@";
            this.Column1.Name = "Column1";
            // 
            // ColItem
            // 
            this.ColItem.FillWeight = 214.7698F;
            this.ColItem.HeaderText = "الصنف";
            this.ColItem.Name = "ColItem";
            // 
            // ColPrice
            // 
            this.ColPrice.FillWeight = 58.915F;
            this.ColPrice.HeaderText = "السعر";
            this.ColPrice.Name = "ColPrice";
            // 
            // ColQty
            // 
            this.ColQty.FillWeight = 58.915F;
            this.ColQty.HeaderText = "الكمية";
            this.ColQty.Name = "ColQty";
            // 
            // ColExpirdDate
            // 
            this.ColExpirdDate.FillWeight = 58.915F;
            this.ColExpirdDate.HeaderText = "تاريخ الصلاحية";
            this.ColExpirdDate.Name = "ColExpirdDate";
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 544);
            this.Controls.Add(this.storesDataGridViewX);
            this.Controls.Add(itemBarCodeLabel);
            this.Controls.Add(this.itemBarCodeRadTextBox);
            this.Controls.Add(userIDLabel);
            this.Controls.Add(this.userIDLabel1);
            this.Controls.Add(billAmuntLabel);
            this.Controls.Add(this.billAmuntLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmSales";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المبيعات";
            this.Load += new System.EventHandler(this.frmSales_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSales_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.itemBarCodeRadTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesDataGridViewX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label billAmuntLabel1;
        private System.Windows.Forms.Label userIDLabel1;
        private Telerik.WinControls.UI.RadTextBox itemBarCodeRadTextBox;
        private DevComponents.DotNetBar.Controls.DataGridViewX storesDataGridViewX;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColExpirdDate;
    }
}