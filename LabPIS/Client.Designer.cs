
namespace LabPIS
{
    partial class Client
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
            System.Windows.Forms.Label companyIdLabel;
            System.Windows.Forms.Label enterprenuerIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            System.Windows.Forms.Label clientIdLabel;
            System.Windows.Forms.Label clientNameLabel;
            System.Windows.Forms.Label clientEmailLabel;
            System.Windows.Forms.Label clientPhoneNumberLabel;
            System.Windows.Forms.Label clientCityLabel;
            this.clientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pisLabUpdated = new LabPIS.pisLabUpdated();
            this.clientTableAdapter = new LabPIS.pisLabDataSetTableAdapters.ClientTableAdapter();
            this.tableAdapterManager = new LabPIS.pisLabDataSetTableAdapters.TableAdapterManager();
            this.enterprenuerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enterprenuerTableAdapter = new LabPIS.pisLabUpdatedTableAdapters.EnterprenuerTableAdapter();
            this.tableAdapterManager1 = new LabPIS.pisLabUpdatedTableAdapters.TableAdapterManager();
            this.clientTableAdapter1 = new LabPIS.pisLabUpdatedTableAdapters.ClientTableAdapter();
            this.companyTableAdapter = new LabPIS.pisLabUpdatedTableAdapters.CompanyTableAdapter();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.companyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.enterprenuerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeActionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.typeActionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.companyDataGridView = new System.Windows.Forms.DataGridView();
            this.enterprenuerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIdTextBox = new System.Windows.Forms.TextBox();
            this.clientNameTextBox = new System.Windows.Forms.TextBox();
            this.clientEmailTextBox = new System.Windows.Forms.TextBox();
            this.clientPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.clientCityTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            companyIdLabel = new System.Windows.Forms.Label();
            enterprenuerIdLabel = new System.Windows.Forms.Label();
            clientIdLabel = new System.Windows.Forms.Label();
            clientNameLabel = new System.Windows.Forms.Label();
            clientEmailLabel = new System.Windows.Forms.Label();
            clientPhoneNumberLabel = new System.Windows.Forms.Label();
            clientCityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pisLabUpdated)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterprenuerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterprenuerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeActionBindingNavigator)).BeginInit();
            this.typeActionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterprenuerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // companyIdLabel
            // 
            companyIdLabel.AutoSize = true;
            companyIdLabel.Location = new System.Drawing.Point(22, 202);
            companyIdLabel.Name = "companyIdLabel";
            companyIdLabel.Size = new System.Drawing.Size(65, 13);
            companyIdLabel.TabIndex = 32;
            companyIdLabel.Text = "company Id:";
            // 
            // enterprenuerIdLabel
            // 
            enterprenuerIdLabel.AutoSize = true;
            enterprenuerIdLabel.Location = new System.Drawing.Point(22, 228);
            enterprenuerIdLabel.Name = "enterprenuerIdLabel";
            enterprenuerIdLabel.Size = new System.Drawing.Size(82, 13);
            enterprenuerIdLabel.TabIndex = 34;
            enterprenuerIdLabel.Text = "enterprenuer Id:";
            // 
            // clientBindingSource1
            // 
            this.clientBindingSource1.DataMember = "Client";
            this.clientBindingSource1.DataSource = this.pisLabUpdated;
            // 
            // pisLabUpdated
            // 
            this.pisLabUpdated.DataSetName = "pisLabUpdated";
            this.pisLabUpdated.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActionTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = this.clientTableAdapter;
            this.tableAdapterManager.CompanyTableAdapter = null;
            this.tableAdapterManager.DocumentTableAdapter = null;
            this.tableAdapterManager.EnterprenuerTableAdapter = null;
            this.tableAdapterManager.InvoiceTableAdapter = null;
            this.tableAdapterManager.LineOfDocumentTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.PersonalTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.TypeActionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LabPIS.pisLabDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // enterprenuerBindingSource
            // 
            this.enterprenuerBindingSource.DataMember = "Enterprenuer";
            this.enterprenuerBindingSource.DataSource = this.pisLabUpdated;
            // 
            // enterprenuerTableAdapter
            // 
            this.enterprenuerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.ActionTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ClientTableAdapter = this.clientTableAdapter1;
            this.tableAdapterManager1.CompanyTableAdapter = this.companyTableAdapter;
            this.tableAdapterManager1.DocumentTableAdapter = null;
            this.tableAdapterManager1.EnterprenuerTableAdapter = this.enterprenuerTableAdapter;
            this.tableAdapterManager1.InvoiceTableAdapter = null;
            this.tableAdapterManager1.LineOfDocumentTableAdapter = null;
            this.tableAdapterManager1.OrderTableAdapter = null;
            this.tableAdapterManager1.PersonalTableAdapter = null;
            this.tableAdapterManager1.ProductTableAdapter = null;
            this.tableAdapterManager1.TypeActionTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = LabPIS.pisLabUpdatedTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clientTableAdapter1
            // 
            this.clientTableAdapter1.ClearBeforeFill = true;
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "Company";
            this.companyBindingSource.DataSource = this.pisLabUpdated;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clientBindingSource1, "clientId", true));
            this.comboBox1.DataSource = this.companyBindingSource1;
            this.comboBox1.DisplayMember = "paymentAccount";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(137, 199);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 35;
            this.comboBox1.ValueMember = "companyId";
            // 
            // companyBindingSource1
            // 
            this.companyBindingSource1.DataMember = "Company";
            this.companyBindingSource1.DataSource = this.pisLabUpdated;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clientBindingSource1, "enterprenuerId", true));
            this.comboBox2.DataSource = this.enterprenuerBindingSource1;
            this.comboBox2.DisplayMember = "taxNumber";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(137, 225);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 36;
            this.comboBox2.ValueMember = "enterprenuerId";
            // 
            // enterprenuerBindingSource1
            // 
            this.enterprenuerBindingSource1.DataMember = "Enterprenuer";
            this.enterprenuerBindingSource1.DataSource = this.pisLabUpdated;
            // 
            // clientDataGridView
            // 
            this.clientDataGridView.AutoGenerateColumns = false;
            this.clientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.clientDataGridView.DataSource = this.clientBindingSource1;
            this.clientDataGridView.Location = new System.Drawing.Point(25, 287);
            this.clientDataGridView.Name = "clientDataGridView";
            this.clientDataGridView.Size = new System.Drawing.Size(753, 220);
            this.clientDataGridView.TabIndex = 36;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "clientId";
            this.dataGridViewTextBoxColumn1.HeaderText = "clientId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "clientName";
            this.dataGridViewTextBoxColumn2.HeaderText = "clientName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "clientEmail";
            this.dataGridViewTextBoxColumn3.HeaderText = "clientEmail";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "clientPhoneNumber";
            this.dataGridViewTextBoxColumn4.HeaderText = "clientPhoneNumber";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "clientCity";
            this.dataGridViewTextBoxColumn5.HeaderText = "clientCity";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "companyId";
            this.dataGridViewTextBoxColumn6.HeaderText = "companyId";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "enterprenuerId";
            this.dataGridViewTextBoxColumn7.HeaderText = "enterprenuerId";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // typeActionBindingNavigator
            // 
            this.typeActionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.typeActionBindingNavigator.BindingSource = this.clientBindingSource1;
            this.typeActionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.typeActionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.typeActionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.typeActionBindingNavigatorSaveItem});
            this.typeActionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.typeActionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.typeActionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.typeActionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.typeActionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.typeActionBindingNavigator.Name = "typeActionBindingNavigator";
            this.typeActionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.typeActionBindingNavigator.Size = new System.Drawing.Size(868, 25);
            this.typeActionBindingNavigator.TabIndex = 37;
            this.typeActionBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // typeActionBindingNavigatorSaveItem
            // 
            this.typeActionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.typeActionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("typeActionBindingNavigatorSaveItem.Image")));
            this.typeActionBindingNavigatorSaveItem.Name = "typeActionBindingNavigatorSaveItem";
            this.typeActionBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.typeActionBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.typeActionBindingNavigatorSaveItem.Click += new System.EventHandler(this.typeActionBindingNavigatorSaveItem_Click);
            // 
            // companyDataGridView
            // 
            this.companyDataGridView.AutoGenerateColumns = false;
            this.companyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.companyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.companyDataGridView.DataSource = this.companyBindingSource1;
            this.companyDataGridView.Location = new System.Drawing.Point(489, 28);
            this.companyDataGridView.Name = "companyDataGridView";
            this.companyDataGridView.Size = new System.Drawing.Size(339, 103);
            this.companyDataGridView.TabIndex = 37;
            // 
            // enterprenuerDataGridView
            // 
            this.enterprenuerDataGridView.AutoGenerateColumns = false;
            this.enterprenuerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enterprenuerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.enterprenuerDataGridView.DataSource = this.enterprenuerBindingSource1;
            this.enterprenuerDataGridView.Location = new System.Drawing.Point(487, 150);
            this.enterprenuerDataGridView.Name = "enterprenuerDataGridView";
            this.enterprenuerDataGridView.Size = new System.Drawing.Size(361, 108);
            this.enterprenuerDataGridView.TabIndex = 37;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "enterprenuerId";
            this.dataGridViewTextBoxColumn10.HeaderText = "enterprenuerId";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "taxNumber";
            this.dataGridViewTextBoxColumn11.HeaderText = "taxNumber";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "cashRegister";
            this.dataGridViewTextBoxColumn12.HeaderText = "cashRegister";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // clientIdLabel
            // 
            clientIdLabel.AutoSize = true;
            clientIdLabel.Location = new System.Drawing.Point(22, 71);
            clientIdLabel.Name = "clientIdLabel";
            clientIdLabel.Size = new System.Drawing.Size(47, 13);
            clientIdLabel.TabIndex = 37;
            clientIdLabel.Text = "client Id:";
            // 
            // clientIdTextBox
            // 
            this.clientIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource1, "clientId", true));
            this.clientIdTextBox.Location = new System.Drawing.Point(137, 68);
            this.clientIdTextBox.Name = "clientIdTextBox";
            this.clientIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.clientIdTextBox.TabIndex = 38;
            // 
            // clientNameLabel
            // 
            clientNameLabel.AutoSize = true;
            clientNameLabel.Location = new System.Drawing.Point(22, 97);
            clientNameLabel.Name = "clientNameLabel";
            clientNameLabel.Size = new System.Drawing.Size(66, 13);
            clientNameLabel.TabIndex = 39;
            clientNameLabel.Text = "client Name:";
            // 
            // clientNameTextBox
            // 
            this.clientNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource1, "clientName", true));
            this.clientNameTextBox.Location = new System.Drawing.Point(137, 94);
            this.clientNameTextBox.Name = "clientNameTextBox";
            this.clientNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.clientNameTextBox.TabIndex = 40;
            // 
            // clientEmailLabel
            // 
            clientEmailLabel.AutoSize = true;
            clientEmailLabel.Location = new System.Drawing.Point(22, 123);
            clientEmailLabel.Name = "clientEmailLabel";
            clientEmailLabel.Size = new System.Drawing.Size(63, 13);
            clientEmailLabel.TabIndex = 41;
            clientEmailLabel.Text = "client Email:";
            // 
            // clientEmailTextBox
            // 
            this.clientEmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource1, "clientEmail", true));
            this.clientEmailTextBox.Location = new System.Drawing.Point(137, 120);
            this.clientEmailTextBox.Name = "clientEmailTextBox";
            this.clientEmailTextBox.Size = new System.Drawing.Size(100, 20);
            this.clientEmailTextBox.TabIndex = 42;
            // 
            // clientPhoneNumberLabel
            // 
            clientPhoneNumberLabel.AutoSize = true;
            clientPhoneNumberLabel.Location = new System.Drawing.Point(22, 149);
            clientPhoneNumberLabel.Name = "clientPhoneNumberLabel";
            clientPhoneNumberLabel.Size = new System.Drawing.Size(109, 13);
            clientPhoneNumberLabel.TabIndex = 43;
            clientPhoneNumberLabel.Text = "client Phone Number:";
            // 
            // clientPhoneNumberTextBox
            // 
            this.clientPhoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource1, "clientPhoneNumber", true));
            this.clientPhoneNumberTextBox.Location = new System.Drawing.Point(137, 146);
            this.clientPhoneNumberTextBox.Name = "clientPhoneNumberTextBox";
            this.clientPhoneNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.clientPhoneNumberTextBox.TabIndex = 44;
            // 
            // clientCityLabel
            // 
            clientCityLabel.AutoSize = true;
            clientCityLabel.Location = new System.Drawing.Point(22, 175);
            clientCityLabel.Name = "clientCityLabel";
            clientCityLabel.Size = new System.Drawing.Size(55, 13);
            clientCityLabel.TabIndex = 45;
            clientCityLabel.Text = "client City:";
            // 
            // clientCityTextBox
            // 
            this.clientCityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource1, "clientCity", true));
            this.clientCityTextBox.Location = new System.Drawing.Point(137, 172);
            this.clientCityTextBox.Name = "clientCityTextBox";
            this.clientCityTextBox.Size = new System.Drawing.Size(100, 20);
            this.clientCityTextBox.TabIndex = 46;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "companyId";
            this.dataGridViewTextBoxColumn8.HeaderText = "companyId";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "paymentAccount";
            this.dataGridViewTextBoxColumn9.HeaderText = "Company name";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 574);
            this.Controls.Add(clientIdLabel);
            this.Controls.Add(this.clientIdTextBox);
            this.Controls.Add(clientNameLabel);
            this.Controls.Add(this.clientNameTextBox);
            this.Controls.Add(clientEmailLabel);
            this.Controls.Add(this.clientEmailTextBox);
            this.Controls.Add(clientPhoneNumberLabel);
            this.Controls.Add(this.clientPhoneNumberTextBox);
            this.Controls.Add(clientCityLabel);
            this.Controls.Add(this.clientCityTextBox);
            this.Controls.Add(this.enterprenuerDataGridView);
            this.Controls.Add(this.companyDataGridView);
            this.Controls.Add(this.typeActionBindingNavigator);
            this.Controls.Add(this.clientDataGridView);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(companyIdLabel);
            this.Controls.Add(enterprenuerIdLabel);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pisLabUpdated)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterprenuerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterprenuerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeActionBindingNavigator)).EndInit();
            this.typeActionBindingNavigator.ResumeLayout(false);
            this.typeActionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterprenuerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource clientBindingSource;
        private pisLabDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private pisLabDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private pisLabUpdated pisLabUpdated;
        private System.Windows.Forms.BindingSource enterprenuerBindingSource;
        private pisLabUpdatedTableAdapters.EnterprenuerTableAdapter enterprenuerTableAdapter;
        private pisLabUpdatedTableAdapters.TableAdapterManager tableAdapterManager1;
        private pisLabUpdatedTableAdapters.CompanyTableAdapter companyTableAdapter;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private pisLabUpdatedTableAdapters.ClientTableAdapter clientTableAdapter1;
        private System.Windows.Forms.BindingSource clientBindingSource1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource companyBindingSource1;
        private System.Windows.Forms.BindingSource enterprenuerBindingSource1;
        private System.Windows.Forms.DataGridView clientDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.BindingNavigator typeActionBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton typeActionBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView companyDataGridView;
        private System.Windows.Forms.DataGridView enterprenuerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.TextBox clientIdTextBox;
        private System.Windows.Forms.TextBox clientNameTextBox;
        private System.Windows.Forms.TextBox clientEmailTextBox;
        private System.Windows.Forms.TextBox clientPhoneNumberTextBox;
        private System.Windows.Forms.TextBox clientCityTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}