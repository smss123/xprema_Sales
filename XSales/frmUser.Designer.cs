﻿namespace XSales
{
    partial class frmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn12 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn13 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn14 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn15 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn16 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn17 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn18 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn19 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn20 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn21 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn22 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.userBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.userRadGridView = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingNavigator)).BeginInit();
            this.userBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userRadGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRadGridView.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(XSales.User);
            // 
            // userBindingNavigator
            // 
            this.userBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.userBindingNavigator.BindingSource = this.userBindingSource;
            this.userBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.userBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.userBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.userBindingNavigatorSaveItem});
            this.userBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.userBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.userBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.userBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.userBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.userBindingNavigator.Name = "userBindingNavigator";
            this.userBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.userBindingNavigator.Size = new System.Drawing.Size(1138, 25);
            this.userBindingNavigator.TabIndex = 0;
            this.userBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // userBindingNavigatorSaveItem
            // 
            this.userBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.userBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("userBindingNavigatorSaveItem.Image")));
            this.userBindingNavigatorSaveItem.Name = "userBindingNavigatorSaveItem";
            this.userBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.userBindingNavigatorSaveItem.Text = "Save Data";
            this.userBindingNavigatorSaveItem.Click += new System.EventHandler(this.userBindingNavigatorSaveItem_Click);
            // 
            // userRadGridView
            // 
            this.userRadGridView.BackColor = System.Drawing.SystemColors.Control;
            this.userRadGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.userRadGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userRadGridView.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.userRadGridView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.userRadGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.userRadGridView.Location = new System.Drawing.Point(0, 25);
            // 
            // userRadGridView
            // 
            this.userRadGridView.MasterTemplate.AllowSearchRow = true;
            this.userRadGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.FieldName = "ID";
            gridViewDecimalColumn2.HeaderText = "ID";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "ID";
            gridViewDecimalColumn2.Width = 75;
            gridViewTextBoxColumn4.FieldName = "FullName";
            gridViewTextBoxColumn4.HeaderText = "اسم الموظف";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "FullName";
            gridViewTextBoxColumn4.Width = 75;
            gridViewTextBoxColumn5.FieldName = "UserName";
            gridViewTextBoxColumn5.HeaderText = "اسم المستخدم";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "UserName";
            gridViewTextBoxColumn5.Width = 75;
            gridViewTextBoxColumn6.FieldName = "pwd";
            gridViewTextBoxColumn6.HeaderText = "كلمة المرور";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.Name = "pwd";
            gridViewTextBoxColumn6.Width = 75;
            gridViewCheckBoxColumn12.DataType = typeof(System.Nullable<bool>);
            gridViewCheckBoxColumn12.FieldName = "IsCategory";
            gridViewCheckBoxColumn12.HeaderText = "ادارة الاصناف";
            gridViewCheckBoxColumn12.IsAutoGenerated = true;
            gridViewCheckBoxColumn12.Name = "IsCategory";
            gridViewCheckBoxColumn12.Width = 75;
            gridViewCheckBoxColumn13.DataType = typeof(System.Nullable<bool>);
            gridViewCheckBoxColumn13.FieldName = "IsItem";
            gridViewCheckBoxColumn13.HeaderText = "ادارة الاصناف";
            gridViewCheckBoxColumn13.IsAutoGenerated = true;
            gridViewCheckBoxColumn13.Name = "IsItem";
            gridViewCheckBoxColumn13.Width = 75;
            gridViewCheckBoxColumn14.DataType = typeof(System.Nullable<bool>);
            gridViewCheckBoxColumn14.FieldName = "IsStore";
            gridViewCheckBoxColumn14.HeaderText = "ادارة المخزن";
            gridViewCheckBoxColumn14.IsAutoGenerated = true;
            gridViewCheckBoxColumn14.Name = "IsStore";
            gridViewCheckBoxColumn14.Width = 75;
            gridViewCheckBoxColumn15.DataType = typeof(System.Nullable<bool>);
            gridViewCheckBoxColumn15.FieldName = "Ispurchase";
            gridViewCheckBoxColumn15.HeaderText = "ادارة المشتريات";
            gridViewCheckBoxColumn15.IsAutoGenerated = true;
            gridViewCheckBoxColumn15.Name = "Ispurchase";
            gridViewCheckBoxColumn15.Width = 75;
            gridViewCheckBoxColumn16.DataType = typeof(System.Nullable<bool>);
            gridViewCheckBoxColumn16.FieldName = "IsSales";
            gridViewCheckBoxColumn16.HeaderText = "ادارة المبيعات";
            gridViewCheckBoxColumn16.IsAutoGenerated = true;
            gridViewCheckBoxColumn16.Name = "IsSales";
            gridViewCheckBoxColumn16.Width = 75;
            gridViewCheckBoxColumn17.DataType = typeof(System.Nullable<bool>);
            gridViewCheckBoxColumn17.FieldName = "IsExpensses";
            gridViewCheckBoxColumn17.HeaderText = "ادارة المصرفات";
            gridViewCheckBoxColumn17.IsAutoGenerated = true;
            gridViewCheckBoxColumn17.Name = "IsExpensses";
            gridViewCheckBoxColumn17.Width = 75;
            gridViewCheckBoxColumn18.DataType = typeof(System.Nullable<bool>);
            gridViewCheckBoxColumn18.FieldName = "IsGoods";
            gridViewCheckBoxColumn18.HeaderText = "ادارة البضائع";
            gridViewCheckBoxColumn18.IsAutoGenerated = true;
            gridViewCheckBoxColumn18.Name = "IsGoods";
            gridViewCheckBoxColumn18.Width = 75;
            gridViewCheckBoxColumn19.DataType = typeof(System.Nullable<bool>);
            gridViewCheckBoxColumn19.FieldName = "IsSalesBetween2Date";
            gridViewCheckBoxColumn19.HeaderText = "تقرير/المبيعات";
            gridViewCheckBoxColumn19.IsAutoGenerated = true;
            gridViewCheckBoxColumn19.Name = "IsSalesBetween2Date";
            gridViewCheckBoxColumn19.Width = 75;
            gridViewCheckBoxColumn20.DataType = typeof(System.Nullable<bool>);
            gridViewCheckBoxColumn20.FieldName = "IsReportExpensses";
            gridViewCheckBoxColumn20.HeaderText = "تقرير/المصروفات";
            gridViewCheckBoxColumn20.IsAutoGenerated = true;
            gridViewCheckBoxColumn20.Name = "IsReportExpensses";
            gridViewCheckBoxColumn20.Width = 75;
            gridViewCheckBoxColumn21.DataType = typeof(System.Nullable<bool>);
            gridViewCheckBoxColumn21.FieldName = "IsBalanceSheet";
            gridViewCheckBoxColumn21.HeaderText = "تقرير/ميزان المراجعه";
            gridViewCheckBoxColumn21.IsAutoGenerated = true;
            gridViewCheckBoxColumn21.Name = "IsBalanceSheet";
            gridViewCheckBoxColumn21.Width = 75;
            gridViewCheckBoxColumn22.DataType = typeof(System.Nullable<bool>);
            gridViewCheckBoxColumn22.FieldName = "IsUser";
            gridViewCheckBoxColumn22.HeaderText = "ادارة المستخدين";
            gridViewCheckBoxColumn22.IsAutoGenerated = true;
            gridViewCheckBoxColumn22.Name = "IsUser";
            gridViewCheckBoxColumn22.Width = 82;
            this.userRadGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn2,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewCheckBoxColumn12,
            gridViewCheckBoxColumn13,
            gridViewCheckBoxColumn14,
            gridViewCheckBoxColumn15,
            gridViewCheckBoxColumn16,
            gridViewCheckBoxColumn17,
            gridViewCheckBoxColumn18,
            gridViewCheckBoxColumn19,
            gridViewCheckBoxColumn20,
            gridViewCheckBoxColumn21,
            gridViewCheckBoxColumn22});
            this.userRadGridView.MasterTemplate.DataSource = this.userBindingSource;
            this.userRadGridView.Name = "userRadGridView";
            this.userRadGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userRadGridView.Size = new System.Drawing.Size(1138, 610);
            this.userRadGridView.TabIndex = 1;
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 635);
            this.Controls.Add(this.userRadGridView);
            this.Controls.Add(this.userBindingNavigator);
            this.Name = "frmUser";
            this.Text = "frmUser";
            this.Load += new System.EventHandler(this.frmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingNavigator)).EndInit();
            this.userBindingNavigator.ResumeLayout(false);
            this.userBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userRadGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRadGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingNavigator userBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton userBindingNavigatorSaveItem;
        private Telerik.WinControls.UI.RadGridView userRadGridView;
    }
}