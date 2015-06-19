namespace XSales
{
    partial class frmAddToStore
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
            System.Windows.Forms.Label itemIDLabel;
            System.Windows.Forms.Label qtyLabel;
            System.Windows.Forms.Label itemBarCodeLabel;
            System.Windows.Forms.Label expiredDateLabel;
            System.Windows.Forms.Label dateOfImportLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddToStore));
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.storeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.storeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.itemIDRadMultiColumnComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qtyTextBoxX = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.itemBarCodeRadTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.expiredDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateOfImportDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.storeDataGridViewX = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            itemIDLabel = new System.Windows.Forms.Label();
            qtyLabel = new System.Windows.Forms.Label();
            itemBarCodeLabel = new System.Windows.Forms.Label();
            expiredDateLabel = new System.Windows.Forms.Label();
            dateOfImportLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingNavigator)).BeginInit();
            this.storeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemIDRadMultiColumnComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemIDRadMultiColumnComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemIDRadMultiColumnComboBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBarCodeRadTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataGridViewX)).BeginInit();
            this.SuspendLayout();
            // 
            // itemIDLabel
            // 
            itemIDLabel.AutoSize = true;
            itemIDLabel.Location = new System.Drawing.Point(59, 52);
            itemIDLabel.Name = "itemIDLabel";
            itemIDLabel.Size = new System.Drawing.Size(61, 13);
            itemIDLabel.TabIndex = 1;
            itemIDLabel.Text = "اسم الصنف";
            // 
            // qtyLabel
            // 
            qtyLabel.AutoSize = true;
            qtyLabel.Location = new System.Drawing.Point(83, 78);
            qtyLabel.Name = "qtyLabel";
            qtyLabel.Size = new System.Drawing.Size(36, 13);
            qtyLabel.TabIndex = 3;
            qtyLabel.Text = "الكمية";
            // 
            // itemBarCodeLabel
            // 
            itemBarCodeLabel.AutoSize = true;
            itemBarCodeLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            itemBarCodeLabel.Location = new System.Drawing.Point(257, 119);
            itemBarCodeLabel.Name = "itemBarCodeLabel";
            itemBarCodeLabel.Size = new System.Drawing.Size(57, 21);
            itemBarCodeLabel.TabIndex = 5;
            itemBarCodeLabel.Text = "الباركود";
            // 
            // expiredDateLabel
            // 
            expiredDateLabel.AutoSize = true;
            expiredDateLabel.Location = new System.Drawing.Point(464, 50);
            expiredDateLabel.Name = "expiredDateLabel";
            expiredDateLabel.Size = new System.Drawing.Size(71, 13);
            expiredDateLabel.TabIndex = 7;
            expiredDateLabel.Text = "تاريخ الصلاحية";
            // 
            // dateOfImportLabel
            // 
            dateOfImportLabel.AutoSize = true;
            dateOfImportLabel.Location = new System.Drawing.Point(437, 78);
            dateOfImportLabel.Name = "dateOfImportLabel";
            dateOfImportLabel.Size = new System.Drawing.Size(98, 13);
            dateOfImportLabel.TabIndex = 9;
            dateOfImportLabel.Text = "تاريخ الدخول للمخزن";
            // 
            // storeBindingSource
            // 
            this.storeBindingSource.DataSource = typeof(XSales.Store);
            // 
            // storeBindingNavigator
            // 
            this.storeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.storeBindingNavigator.BindingSource = this.storeBindingSource;
            this.storeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.storeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.storeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.storeBindingNavigatorSaveItem});
            this.storeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.storeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.storeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.storeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.storeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.storeBindingNavigator.Name = "storeBindingNavigator";
            this.storeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.storeBindingNavigator.Size = new System.Drawing.Size(861, 25);
            this.storeBindingNavigator.TabIndex = 0;
            this.storeBindingNavigator.Text = "bindingNavigator1";
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
            // storeBindingNavigatorSaveItem
            // 
            this.storeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.storeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("storeBindingNavigatorSaveItem.Image")));
            this.storeBindingNavigatorSaveItem.Name = "storeBindingNavigatorSaveItem";
            this.storeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.storeBindingNavigatorSaveItem.Text = "Save Data";
            this.storeBindingNavigatorSaveItem.Click += new System.EventHandler(this.storeBindingNavigatorSaveItem_Click);
            // 
            // itemIDRadMultiColumnComboBox
            // 
            this.itemIDRadMultiColumnComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storeBindingSource, "ItemID", true));
            this.itemIDRadMultiColumnComboBox.DataSource = this.itemBindingSource;
            this.itemIDRadMultiColumnComboBox.DisplayMember = "ItemName";
            // 
            // itemIDRadMultiColumnComboBox.NestedRadGridView
            // 
            this.itemIDRadMultiColumnComboBox.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.itemIDRadMultiColumnComboBox.EditorControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.itemIDRadMultiColumnComboBox.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.itemIDRadMultiColumnComboBox.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.itemIDRadMultiColumnComboBox.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.itemIDRadMultiColumnComboBox.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // itemIDRadMultiColumnComboBox.NestedRadGridView
            // 
            this.itemIDRadMultiColumnComboBox.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.itemIDRadMultiColumnComboBox.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.itemIDRadMultiColumnComboBox.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.itemIDRadMultiColumnComboBox.EditorControl.MasterTemplate.AllowSearchRow = true;
            this.itemIDRadMultiColumnComboBox.EditorControl.MasterTemplate.AutoGenerateColumns = false;
            this.itemIDRadMultiColumnComboBox.EditorControl.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "ID";
            gridViewDecimalColumn2.HeaderText = "ID";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "ID";
            gridViewDecimalColumn2.Width = 45;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "ItemModel";
            gridViewTextBoxColumn5.HeaderText = "الموديل";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "ItemModel";
            gridViewTextBoxColumn5.Width = 45;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "ItemName";
            gridViewTextBoxColumn6.HeaderText = "اسم الصنف";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.Name = "ItemName";
            gridViewTextBoxColumn6.Width = 45;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "ItemDescription";
            gridViewTextBoxColumn7.HeaderText = "وصف";
            gridViewTextBoxColumn7.IsAutoGenerated = true;
            gridViewTextBoxColumn7.Name = "ItemDescription";
            gridViewTextBoxColumn7.Width = 45;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "ItemPrice";
            gridViewTextBoxColumn8.HeaderText = "السعر";
            gridViewTextBoxColumn8.IsAutoGenerated = true;
            gridViewTextBoxColumn8.Name = "ItemPrice";
            gridViewTextBoxColumn8.Width = 44;
            this.itemIDRadMultiColumnComboBox.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn2,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8});
            this.itemIDRadMultiColumnComboBox.EditorControl.MasterTemplate.DataSource = this.itemBindingSource;
            this.itemIDRadMultiColumnComboBox.EditorControl.MasterTemplate.EnableGrouping = false;
            this.itemIDRadMultiColumnComboBox.EditorControl.MasterTemplate.SearchRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.itemIDRadMultiColumnComboBox.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.itemIDRadMultiColumnComboBox.EditorControl.Name = "NestedRadGridView";
            this.itemIDRadMultiColumnComboBox.EditorControl.ReadOnly = true;
            this.itemIDRadMultiColumnComboBox.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.itemIDRadMultiColumnComboBox.EditorControl.ShowGroupPanel = false;
            this.itemIDRadMultiColumnComboBox.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.itemIDRadMultiColumnComboBox.EditorControl.TabIndex = 0;
            this.itemIDRadMultiColumnComboBox.Location = new System.Drawing.Point(124, 49);
            this.itemIDRadMultiColumnComboBox.Name = "itemIDRadMultiColumnComboBox";
            this.itemIDRadMultiColumnComboBox.Size = new System.Drawing.Size(266, 20);
            this.itemIDRadMultiColumnComboBox.TabIndex = 2;
            this.itemIDRadMultiColumnComboBox.TabStop = false;
            this.itemIDRadMultiColumnComboBox.ValueMember = "ID";
            this.itemIDRadMultiColumnComboBox.SelectedIndexChanged += new System.EventHandler(this.itemIDRadMultiColumnComboBox_SelectedIndexChanged);
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(XSales.Item);
            // 
            // qtyTextBoxX
            // 
            // 
            // 
            // 
            this.qtyTextBoxX.Border.Class = "TextBoxBorder";
            this.qtyTextBoxX.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.qtyTextBoxX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storeBindingSource, "Qty", true));
            this.qtyTextBoxX.Location = new System.Drawing.Point(124, 75);
            this.qtyTextBoxX.Name = "qtyTextBoxX";
            this.qtyTextBoxX.PreventEnterBeep = true;
            this.qtyTextBoxX.Size = new System.Drawing.Size(266, 20);
            this.qtyTextBoxX.TabIndex = 4;
            // 
            // itemBarCodeRadTextBox
            // 
            this.itemBarCodeRadTextBox.BackColor = System.Drawing.Color.Yellow;
            this.itemBarCodeRadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storeBindingSource, "ItemBarCode", true));
            this.itemBarCodeRadTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.itemBarCodeRadTextBox.Location = new System.Drawing.Point(320, 117);
            this.itemBarCodeRadTextBox.Name = "itemBarCodeRadTextBox";
            this.itemBarCodeRadTextBox.NullText = "ادخل الباركود";
            this.itemBarCodeRadTextBox.Size = new System.Drawing.Size(205, 27);
            this.itemBarCodeRadTextBox.TabIndex = 6;
            this.itemBarCodeRadTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.itemBarCodeRadTextBox_KeyDown);
            // 
            // expiredDateDateTimePicker
            // 
            this.expiredDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.storeBindingSource, "ExpiredDate", true));
            this.expiredDateDateTimePicker.Location = new System.Drawing.Point(543, 46);
            this.expiredDateDateTimePicker.Name = "expiredDateDateTimePicker";
            this.expiredDateDateTimePicker.Size = new System.Drawing.Size(261, 20);
            this.expiredDateDateTimePicker.TabIndex = 8;
            // 
            // dateOfImportDateTimePicker
            // 
            this.dateOfImportDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.storeBindingSource, "DateOfImport", true));
            this.dateOfImportDateTimePicker.Location = new System.Drawing.Point(543, 72);
            this.dateOfImportDateTimePicker.Name = "dateOfImportDateTimePicker";
            this.dateOfImportDateTimePicker.Size = new System.Drawing.Size(261, 20);
            this.dateOfImportDateTimePicker.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(321, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "عدد الاصناف المدخله:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCount.Location = new System.Drawing.Point(468, 147);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(57, 23);
            this.lblCount.TabIndex = 11;
            this.lblCount.Text = "00000";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // storeDataGridViewX
            // 
            this.storeDataGridViewX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.storeDataGridViewX.AutoGenerateColumns = false;
            this.storeDataGridViewX.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.storeDataGridViewX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storeDataGridViewX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.storeDataGridViewX.DataSource = this.storeBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.storeDataGridViewX.DefaultCellStyle = dataGridViewCellStyle2;
            this.storeDataGridViewX.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.storeDataGridViewX.Location = new System.Drawing.Point(41, 197);
            this.storeDataGridViewX.Name = "storeDataGridViewX";
            this.storeDataGridViewX.Size = new System.Drawing.Size(763, 205);
            this.storeDataGridViewX.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Qty";
            this.dataGridViewTextBoxColumn3.HeaderText = "الكمية";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DateOfImport";
            this.dataGridViewTextBoxColumn4.HeaderText = "تاريخ الدخول للمخزن";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ExpiredDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "تاريخ الصلاحية";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ItemBarCode";
            this.dataGridViewTextBoxColumn6.HeaderText = "الباركود";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(543, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 53);
            this.button1.TabIndex = 14;
            this.button1.Text = "انهاء";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAddToStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 414);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.storeDataGridViewX);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(dateOfImportLabel);
            this.Controls.Add(this.dateOfImportDateTimePicker);
            this.Controls.Add(expiredDateLabel);
            this.Controls.Add(this.expiredDateDateTimePicker);
            this.Controls.Add(itemBarCodeLabel);
            this.Controls.Add(this.itemBarCodeRadTextBox);
            this.Controls.Add(qtyLabel);
            this.Controls.Add(this.qtyTextBoxX);
            this.Controls.Add(itemIDLabel);
            this.Controls.Add(this.itemIDRadMultiColumnComboBox);
            this.Controls.Add(this.storeBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmAddToStore";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة الي المخزن";
            this.Load += new System.EventHandler(this.frmAddToStore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingNavigator)).EndInit();
            this.storeBindingNavigator.ResumeLayout(false);
            this.storeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemIDRadMultiColumnComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemIDRadMultiColumnComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemIDRadMultiColumnComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBarCodeRadTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataGridViewX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource storeBindingSource;
        private System.Windows.Forms.BindingNavigator storeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton storeBindingNavigatorSaveItem;
        private Telerik.WinControls.UI.RadMultiColumnComboBox itemIDRadMultiColumnComboBox;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private DevComponents.DotNetBar.Controls.TextBoxX qtyTextBoxX;
        private Telerik.WinControls.UI.RadTextBox itemBarCodeRadTextBox;
        private System.Windows.Forms.DateTimePicker expiredDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateOfImportDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCount;
        private DevComponents.DotNetBar.Controls.DataGridViewX storeDataGridViewX;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button button1;
    }
}