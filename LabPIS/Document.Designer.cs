
namespace LabPIS
{
    partial class Document
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Document));
            System.Windows.Forms.Label documentIdLabel;
            System.Windows.Forms.Label documentTypeLabel;
            System.Windows.Forms.Label dataOfRegistrationLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label personalIdLabel1;
            System.Windows.Forms.Label clientIdLabel;
            this.pisLabDataSet2 = new LabPIS.pisLabDataSet2();
            this.documentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentTableAdapter = new LabPIS.pisLabDataSet2TableAdapters.DocumentTableAdapter();
            this.tableAdapterManager = new LabPIS.pisLabDataSet2TableAdapters.TableAdapterManager();
            this.documentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.documentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.documentDataGridView = new System.Windows.Forms.DataGridView();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new LabPIS.pisLabDataSet2TableAdapters.ClientTableAdapter();
            this.personalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalTableAdapter = new LabPIS.pisLabDataSet2TableAdapters.PersonalTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.documentIdTextBox = new System.Windows.Forms.TextBox();
            this.documentTypeTextBox = new System.Windows.Forms.TextBox();
            this.dataOfRegistrationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.personalIdComboBox = new System.Windows.Forms.ComboBox();
            this.clientIdComboBox = new System.Windows.Forms.ComboBox();
            documentIdLabel = new System.Windows.Forms.Label();
            documentTypeLabel = new System.Windows.Forms.Label();
            dataOfRegistrationLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            personalIdLabel1 = new System.Windows.Forms.Label();
            clientIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pisLabDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingNavigator)).BeginInit();
            this.documentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pisLabDataSet2
            // 
            this.pisLabDataSet2.DataSetName = "pisLabDataSet2";
            this.pisLabDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // documentBindingSource
            // 
            this.documentBindingSource.DataMember = "Document";
            this.documentBindingSource.DataSource = this.pisLabDataSet2;
            // 
            // documentTableAdapter
            // 
            this.documentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActionTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = this.clientTableAdapter;
            this.tableAdapterManager.CompanyTableAdapter = null;
            this.tableAdapterManager.DocumentTableAdapter = this.documentTableAdapter;
            this.tableAdapterManager.EnterprenuerTableAdapter = null;
            this.tableAdapterManager.InvoiceTableAdapter = null;
            this.tableAdapterManager.LineOfDocumentTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.PersonalTableAdapter = this.personalTableAdapter;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.TypeActionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LabPIS.pisLabDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // documentBindingNavigator
            // 
            this.documentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.documentBindingNavigator.BindingSource = this.documentBindingSource;
            this.documentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.documentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.documentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.documentBindingNavigatorSaveItem});
            this.documentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.documentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.documentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.documentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.documentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.documentBindingNavigator.Name = "documentBindingNavigator";
            this.documentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.documentBindingNavigator.Size = new System.Drawing.Size(925, 25);
            this.documentBindingNavigator.TabIndex = 0;
            this.documentBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // documentBindingNavigatorSaveItem
            // 
            this.documentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.documentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("documentBindingNavigatorSaveItem.Image")));
            this.documentBindingNavigatorSaveItem.Name = "documentBindingNavigatorSaveItem";
            this.documentBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.documentBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.documentBindingNavigatorSaveItem.Click += new System.EventHandler(this.documentBindingNavigatorSaveItem_Click);
            // 
            // documentDataGridView
            // 
            this.documentDataGridView.AutoGenerateColumns = false;
            this.documentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.documentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.documentDataGridView.DataSource = this.documentBindingSource;
            this.documentDataGridView.Location = new System.Drawing.Point(12, 54);
            this.documentDataGridView.Name = "documentDataGridView";
            this.documentDataGridView.Size = new System.Drawing.Size(663, 302);
            this.documentDataGridView.TabIndex = 1;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.pisLabDataSet2;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // personalBindingSource
            // 
            this.personalBindingSource.DataMember = "Personal";
            this.personalBindingSource.DataSource = this.pisLabDataSet2;
            // 
            // personalTableAdapter
            // 
            this.personalTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "documentId";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код документу";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "documentType";
            this.dataGridViewTextBoxColumn2.HeaderText = "Тип документу";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "dataOfRegistration";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата реєстрації";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn6.HeaderText = "Ціна";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "clientId";
            this.dataGridViewTextBoxColumn4.DataSource = this.clientBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "clientName";
            this.dataGridViewTextBoxColumn4.HeaderText = "Назва клієнта";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "clientId";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "personalId";
            this.dataGridViewTextBoxColumn5.DataSource = this.personalBindingSource;
            this.dataGridViewTextBoxColumn5.DisplayMember = "surname";
            this.dataGridViewTextBoxColumn5.HeaderText = "Персонал";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.ValueMember = "personalId";
            // 
            // documentIdLabel
            // 
            documentIdLabel.AutoSize = true;
            documentIdLabel.Location = new System.Drawing.Point(776, 54);
            documentIdLabel.Name = "documentIdLabel";
            documentIdLabel.Size = new System.Drawing.Size(85, 13);
            documentIdLabel.TabIndex = 2;
            documentIdLabel.Text = "Код документу:";
            // 
            // documentIdTextBox
            // 
            this.documentIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.documentBindingSource, "documentId", true));
            this.documentIdTextBox.Location = new System.Drawing.Point(713, 76);
            this.documentIdTextBox.Name = "documentIdTextBox";
            this.documentIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.documentIdTextBox.TabIndex = 3;
            // 
            // documentTypeLabel
            // 
            documentTypeLabel.AutoSize = true;
            documentTypeLabel.Location = new System.Drawing.Point(774, 109);
            documentTypeLabel.Name = "documentTypeLabel";
            documentTypeLabel.Size = new System.Drawing.Size(86, 13);
            documentTypeLabel.TabIndex = 4;
            documentTypeLabel.Text = "Тип документа:";
            // 
            // documentTypeTextBox
            // 
            this.documentTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.documentBindingSource, "documentType", true));
            this.documentTypeTextBox.Location = new System.Drawing.Point(713, 125);
            this.documentTypeTextBox.Name = "documentTypeTextBox";
            this.documentTypeTextBox.Size = new System.Drawing.Size(200, 20);
            this.documentTypeTextBox.TabIndex = 5;
            // 
            // dataOfRegistrationLabel
            // 
            dataOfRegistrationLabel.AutoSize = true;
            dataOfRegistrationLabel.Location = new System.Drawing.Point(776, 160);
            dataOfRegistrationLabel.Name = "dataOfRegistrationLabel";
            dataOfRegistrationLabel.Size = new System.Drawing.Size(91, 13);
            dataOfRegistrationLabel.TabIndex = 6;
            dataOfRegistrationLabel.Text = "Дата реєстрації:";
            // 
            // dataOfRegistrationDateTimePicker
            // 
            this.dataOfRegistrationDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.documentBindingSource, "dataOfRegistration", true));
            this.dataOfRegistrationDateTimePicker.Location = new System.Drawing.Point(713, 176);
            this.dataOfRegistrationDateTimePicker.Name = "dataOfRegistrationDateTimePicker";
            this.dataOfRegistrationDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataOfRegistrationDateTimePicker.TabIndex = 7;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(799, 209);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(32, 13);
            priceLabel.TabIndex = 12;
            priceLabel.Text = "Ціна:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.documentBindingSource, "price", true));
            this.priceTextBox.Location = new System.Drawing.Point(713, 225);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(200, 20);
            this.priceTextBox.TabIndex = 13;
            // 
            // personalIdLabel1
            // 
            personalIdLabel1.AutoSize = true;
            personalIdLabel1.Location = new System.Drawing.Point(784, 317);
            personalIdLabel1.Name = "personalIdLabel1";
            personalIdLabel1.Size = new System.Drawing.Size(60, 13);
            personalIdLabel1.TabIndex = 14;
            personalIdLabel1.Text = "Персонал:";
            // 
            // personalIdComboBox
            // 
            this.personalIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.documentBindingSource, "personalId", true));
            this.personalIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.documentBindingSource, "personalId", true));
            this.personalIdComboBox.DataSource = this.personalBindingSource;
            this.personalIdComboBox.DisplayMember = "surname";
            this.personalIdComboBox.FormattingEnabled = true;
            this.personalIdComboBox.Location = new System.Drawing.Point(713, 333);
            this.personalIdComboBox.Name = "personalIdComboBox";
            this.personalIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.personalIdComboBox.TabIndex = 15;
            this.personalIdComboBox.ValueMember = "personalId";
            // 
            // clientIdLabel
            // 
            clientIdLabel.AutoSize = true;
            clientIdLabel.Location = new System.Drawing.Point(776, 261);
            clientIdLabel.Name = "clientIdLabel";
            clientIdLabel.Size = new System.Drawing.Size(82, 13);
            clientIdLabel.TabIndex = 15;
            clientIdLabel.Text = "Назва клієнта:";
            // 
            // clientIdComboBox
            // 
            this.clientIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.documentBindingSource, "clientId", true));
            this.clientIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.documentBindingSource, "clientId", true));
            this.clientIdComboBox.DataSource = this.clientBindingSource;
            this.clientIdComboBox.DisplayMember = "clientName";
            this.clientIdComboBox.FormattingEnabled = true;
            this.clientIdComboBox.Location = new System.Drawing.Point(713, 277);
            this.clientIdComboBox.Name = "clientIdComboBox";
            this.clientIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.clientIdComboBox.TabIndex = 16;
            this.clientIdComboBox.ValueMember = "clientId";
            // 
            // Document
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 551);
            this.Controls.Add(clientIdLabel);
            this.Controls.Add(this.clientIdComboBox);
            this.Controls.Add(personalIdLabel1);
            this.Controls.Add(this.personalIdComboBox);
            this.Controls.Add(documentIdLabel);
            this.Controls.Add(this.documentIdTextBox);
            this.Controls.Add(documentTypeLabel);
            this.Controls.Add(this.documentTypeTextBox);
            this.Controls.Add(dataOfRegistrationLabel);
            this.Controls.Add(this.dataOfRegistrationDateTimePicker);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.documentDataGridView);
            this.Controls.Add(this.documentBindingNavigator);
            this.Name = "Document";
            this.Text = "Документи";
            this.Load += new System.EventHandler(this.Document_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pisLabDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingNavigator)).EndInit();
            this.documentBindingNavigator.ResumeLayout(false);
            this.documentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private pisLabDataSet2 pisLabDataSet2;
        private System.Windows.Forms.BindingSource documentBindingSource;
        private pisLabDataSet2TableAdapters.DocumentTableAdapter documentTableAdapter;
        private pisLabDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator documentBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton documentBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView documentDataGridView;
        private pisLabDataSet2TableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private pisLabDataSet2TableAdapters.PersonalTableAdapter personalTableAdapter;
        private System.Windows.Forms.BindingSource personalBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox documentIdTextBox;
        private System.Windows.Forms.TextBox documentTypeTextBox;
        private System.Windows.Forms.DateTimePicker dataOfRegistrationDateTimePicker;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.ComboBox personalIdComboBox;
        private System.Windows.Forms.ComboBox clientIdComboBox;
    }
}