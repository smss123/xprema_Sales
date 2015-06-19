namespace XSales
{
    partial class frmPurshes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurshes));
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewRelation gridViewRelation1 = new Telerik.WinControls.UI.GridViewRelation();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn1 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            this.purshesBillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purshesBillBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.purshesBillBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.purshesBillRadGridView = new Telerik.WinControls.UI.RadGridView();
            this.pourshesDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewTemplate1 = new Telerik.WinControls.UI.GridViewTemplate();
            ((System.ComponentModel.ISupportInitialize)(this.purshesBillBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purshesBillBindingNavigator)).BeginInit();
            this.purshesBillBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purshesBillRadGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purshesBillRadGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pourshesDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTemplate1)).BeginInit();
            this.SuspendLayout();
            // 
            // purshesBillBindingSource
            // 
            this.purshesBillBindingSource.DataSource = typeof(XSales.PurshesBill);
            // 
            // purshesBillBindingNavigator
            // 
            this.purshesBillBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.purshesBillBindingNavigator.BindingSource = this.purshesBillBindingSource;
            this.purshesBillBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.purshesBillBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.purshesBillBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.purshesBillBindingNavigatorSaveItem});
            this.purshesBillBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.purshesBillBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.purshesBillBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.purshesBillBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.purshesBillBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.purshesBillBindingNavigator.Name = "purshesBillBindingNavigator";
            this.purshesBillBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.purshesBillBindingNavigator.Size = new System.Drawing.Size(942, 25);
            this.purshesBillBindingNavigator.TabIndex = 0;
            this.purshesBillBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // purshesBillBindingNavigatorSaveItem
            // 
            this.purshesBillBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.purshesBillBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("purshesBillBindingNavigatorSaveItem.Image")));
            this.purshesBillBindingNavigatorSaveItem.Name = "purshesBillBindingNavigatorSaveItem";
            this.purshesBillBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.purshesBillBindingNavigatorSaveItem.Text = "Save Data";
            this.purshesBillBindingNavigatorSaveItem.Click += new System.EventHandler(this.purshesBillBindingNavigatorSaveItem_Click);
            // 
            // purshesBillRadGridView
            // 
            this.purshesBillRadGridView.BackColor = System.Drawing.SystemColors.Control;
            this.purshesBillRadGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.purshesBillRadGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purshesBillRadGridView.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.purshesBillRadGridView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.purshesBillRadGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.purshesBillRadGridView.Location = new System.Drawing.Point(0, 25);
            // 
            // purshesBillRadGridView
            // 
            this.purshesBillRadGridView.MasterTemplate.AllowSearchRow = true;
            this.purshesBillRadGridView.MasterTemplate.AutoGenerateColumns = false;
            this.purshesBillRadGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "ID";
            gridViewDecimalColumn1.Width = 81;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "PursesID";
            gridViewTextBoxColumn1.HeaderText = "رقم الفاتورة";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "PursesID";
            gridViewTextBoxColumn1.Width = 155;
            gridViewDateTimeColumn1.DataType = typeof(System.Nullable<System.DateTime>);
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "DatefProcess";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn1.HeaderText = "تاريخ الشراء";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "DatefProcess";
            gridViewDateTimeColumn1.Width = 161;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "SuppilerName";
            gridViewTextBoxColumn2.HeaderText = "اسم المورد";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "SuppilerName";
            gridViewTextBoxColumn2.Width = 210;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "Descriptin";
            gridViewTextBoxColumn3.HeaderText = "وصف";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "Descriptin";
            gridViewTextBoxColumn3.Width = 298;
            this.purshesBillRadGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewDateTimeColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            this.purshesBillRadGridView.MasterTemplate.DataSource = this.purshesBillBindingSource;
            this.purshesBillRadGridView.MasterTemplate.EnableFiltering = true;
            this.purshesBillRadGridView.MasterTemplate.Templates.AddRange(new Telerik.WinControls.UI.GridViewTemplate[] {
            this.gridViewTemplate1});
            this.purshesBillRadGridView.Name = "purshesBillRadGridView";
            gridViewRelation1.ChildColumnNames = ((System.Collections.Specialized.StringCollection)(resources.GetObject("gridViewRelation1.ChildColumnNames")));
            gridViewRelation1.ChildTemplate = this.gridViewTemplate1;
            gridViewRelation1.ParentColumnNames = ((System.Collections.Specialized.StringCollection)(resources.GetObject("gridViewRelation1.ParentColumnNames")));
            gridViewRelation1.ParentTemplate = this.purshesBillRadGridView.MasterTemplate;
            this.purshesBillRadGridView.Relations.AddRange(new Telerik.WinControls.UI.GridViewRelation[] {
            gridViewRelation1});
            this.purshesBillRadGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.purshesBillRadGridView.Size = new System.Drawing.Size(942, 422);
            this.purshesBillRadGridView.TabIndex = 1;
            this.purshesBillRadGridView.Text = "radGridView1";
            // 
            // pourshesDetailsBindingSource
            // 
            this.pourshesDetailsBindingSource.DataMember = "PourshesDetails";
            this.pourshesDetailsBindingSource.DataSource = this.purshesBillBindingSource;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(XSales.Item);
            // 
            // gridViewTemplate1
            // 
            this.gridViewTemplate1.AllowSearchRow = true;
            this.gridViewTemplate1.AutoGenerateColumns = false;
            this.gridViewTemplate1.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "ID";
            gridViewDecimalColumn2.HeaderText = "ID";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "ID";
            gridViewDecimalColumn3.DataType = typeof(System.Nullable<int>);
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "PourshesID";
            gridViewDecimalColumn3.HeaderText = "PourshesID";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.IsVisible = false;
            gridViewDecimalColumn3.Name = "PourshesID";
            gridViewDecimalColumn4.DataType = typeof(System.Nullable<int>);
            gridViewDecimalColumn4.EnableExpressionEditor = false;
            gridViewDecimalColumn4.FieldName = "Qty";
            gridViewDecimalColumn4.HeaderText = "الكمية";
            gridViewDecimalColumn4.IsAutoGenerated = true;
            gridViewDecimalColumn4.Name = "Qty";
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "Description";
            gridViewTextBoxColumn4.HeaderText = "الوصف";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "Description";
            gridViewComboBoxColumn1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            gridViewComboBoxColumn1.DataSource = this.itemBindingSource;
            gridViewComboBoxColumn1.DataType = typeof(System.Nullable<int>);
            gridViewComboBoxColumn1.DisplayMember = "ItemName";
            gridViewComboBoxColumn1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDown;
            gridViewComboBoxColumn1.EnableExpressionEditor = false;
            gridViewComboBoxColumn1.FieldName = "ItemID";
            gridViewComboBoxColumn1.HeaderText = "الصنف";
            gridViewComboBoxColumn1.Name = "column1";
            gridViewComboBoxColumn1.ValueMember = "ID";
            this.gridViewTemplate1.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewDecimalColumn4,
            gridViewTextBoxColumn4,
            gridViewComboBoxColumn1});
            this.gridViewTemplate1.DataSource = this.pourshesDetailsBindingSource;
            this.gridViewTemplate1.EnableFiltering = true;
            // 
            // frmPurshes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 447);
            this.Controls.Add(this.purshesBillRadGridView);
            this.Controls.Add(this.purshesBillBindingNavigator);
            this.Name = "frmPurshes";
            this.Text = "frmPurshes";
            this.Load += new System.EventHandler(this.frmPurshes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.purshesBillBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purshesBillBindingNavigator)).EndInit();
            this.purshesBillBindingNavigator.ResumeLayout(false);
            this.purshesBillBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purshesBillRadGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purshesBillRadGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pourshesDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTemplate1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource purshesBillBindingSource;
        private System.Windows.Forms.BindingNavigator purshesBillBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton purshesBillBindingNavigatorSaveItem;
        private Telerik.WinControls.UI.RadGridView purshesBillRadGridView;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.BindingSource pourshesDetailsBindingSource;
        private Telerik.WinControls.UI.GridViewTemplate gridViewTemplate1;
    }
}