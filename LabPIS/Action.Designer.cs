
namespace LabPIS
{
    partial class Action
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
            System.Windows.Forms.Label actionIdLabel;
            System.Windows.Forms.Label amountOfProductsForActionLabel;
            System.Windows.Forms.Label typeActionIdLabel;
            System.Windows.Forms.Label productIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Action));
            this.pisLabUpdated = new LabPIS.pisLabUpdated();
            this.actionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actionTableAdapter = new LabPIS.pisLabUpdatedTableAdapters.ActionTableAdapter();
            this.tableAdapterManager = new LabPIS.pisLabUpdatedTableAdapters.TableAdapterManager();
            this.productTableAdapter = new LabPIS.pisLabUpdatedTableAdapters.ProductTableAdapter();
            this.typeActionTableAdapter = new LabPIS.pisLabUpdatedTableAdapters.TypeActionTableAdapter();
            this.actionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.actionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.actionDataGridView = new System.Windows.Forms.DataGridView();
            this.actionIdTextBox = new System.Windows.Forms.TextBox();
            this.amountOfProductsForActionTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.typeActionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            actionIdLabel = new System.Windows.Forms.Label();
            amountOfProductsForActionLabel = new System.Windows.Forms.Label();
            typeActionIdLabel = new System.Windows.Forms.Label();
            productIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pisLabUpdated)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionBindingNavigator)).BeginInit();
            this.actionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeActionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // actionIdLabel
            // 
            actionIdLabel.AutoSize = true;
            actionIdLabel.Location = new System.Drawing.Point(12, 35);
            actionIdLabel.Name = "actionIdLabel";
            actionIdLabel.Size = new System.Drawing.Size(55, 13);
            actionIdLabel.TabIndex = 2;
            actionIdLabel.Text = "Код акції:";
            // 
            // amountOfProductsForActionLabel
            // 
            amountOfProductsForActionLabel.AutoSize = true;
            amountOfProductsForActionLabel.Location = new System.Drawing.Point(179, 35);
            amountOfProductsForActionLabel.Name = "amountOfProductsForActionLabel";
            amountOfProductsForActionLabel.Size = new System.Drawing.Size(137, 13);
            amountOfProductsForActionLabel.TabIndex = 4;
            amountOfProductsForActionLabel.Text = "Кількість товарів на акції:";
            // 
            // typeActionIdLabel
            // 
            typeActionIdLabel.AutoSize = true;
            typeActionIdLabel.Location = new System.Drawing.Point(428, 35);
            typeActionIdLabel.Name = "typeActionIdLabel";
            typeActionIdLabel.Size = new System.Drawing.Size(55, 13);
            typeActionIdLabel.TabIndex = 6;
            typeActionIdLabel.Text = "Тип акції:";
            // 
            // productIdLabel
            // 
            productIdLabel.AutoSize = true;
            productIdLabel.Location = new System.Drawing.Point(605, 35);
            productIdLabel.Name = "productIdLabel";
            productIdLabel.Size = new System.Drawing.Size(41, 13);
            productIdLabel.TabIndex = 8;
            productIdLabel.Text = "Товар:";
            // 
            // pisLabUpdated
            // 
            this.pisLabUpdated.DataSetName = "pisLabUpdated";
            this.pisLabUpdated.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // actionBindingSource
            // 
            this.actionBindingSource.DataMember = "Action";
            this.actionBindingSource.DataSource = this.pisLabUpdated;
            // 
            // actionTableAdapter
            // 
            this.actionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActionTableAdapter = this.actionTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.CompanyTableAdapter = null;
            this.tableAdapterManager.DocumentTableAdapter = null;
            this.tableAdapterManager.EnterprenuerTableAdapter = null;
            this.tableAdapterManager.InvoiceTableAdapter = null;
            this.tableAdapterManager.LineOfDocumentTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.PersonalTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.TypeActionTableAdapter = this.typeActionTableAdapter;
            this.tableAdapterManager.UpdateOrder = LabPIS.pisLabUpdatedTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // typeActionTableAdapter
            // 
            this.typeActionTableAdapter.ClearBeforeFill = true;
            // 
            // actionBindingNavigator
            // 
            this.actionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.actionBindingNavigator.BindingSource = this.actionBindingSource;
            this.actionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.actionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.actionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.actionBindingNavigatorSaveItem});
            this.actionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.actionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.actionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.actionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.actionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.actionBindingNavigator.Name = "actionBindingNavigator";
            this.actionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.actionBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.actionBindingNavigator.TabIndex = 0;
            this.actionBindingNavigator.Text = "bindingNavigator1";
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
            // actionBindingNavigatorSaveItem
            // 
            this.actionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.actionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("actionBindingNavigatorSaveItem.Image")));
            this.actionBindingNavigatorSaveItem.Name = "actionBindingNavigatorSaveItem";
            this.actionBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.actionBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.actionBindingNavigatorSaveItem.Click += new System.EventHandler(this.actionBindingNavigatorSaveItem_Click);
            // 
            // actionDataGridView
            // 
            this.actionDataGridView.AutoGenerateColumns = false;
            this.actionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.actionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.actionDataGridView.DataSource = this.actionBindingSource;
            this.actionDataGridView.Location = new System.Drawing.Point(15, 144);
            this.actionDataGridView.Name = "actionDataGridView";
            this.actionDataGridView.Size = new System.Drawing.Size(462, 220);
            this.actionDataGridView.TabIndex = 1;
            // 
            // actionIdTextBox
            // 
            this.actionIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actionBindingSource, "actionId", true));
            this.actionIdTextBox.Location = new System.Drawing.Point(73, 32);
            this.actionIdTextBox.Name = "actionIdTextBox";
            this.actionIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.actionIdTextBox.TabIndex = 3;
            // 
            // amountOfProductsForActionTextBox
            // 
            this.amountOfProductsForActionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actionBindingSource, "amountOfProductsForAction", true));
            this.amountOfProductsForActionTextBox.Location = new System.Drawing.Point(322, 32);
            this.amountOfProductsForActionTextBox.Name = "amountOfProductsForActionTextBox";
            this.amountOfProductsForActionTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountOfProductsForActionTextBox.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.actionBindingSource, "typeActionId", true));
            this.comboBox1.DataSource = this.typeActionBindingSource;
            this.comboBox1.DisplayMember = "actionName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(489, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.ValueMember = "typeActionId";
            // 
            // typeActionBindingSource
            // 
            this.typeActionBindingSource.DataMember = "TypeAction";
            this.typeActionBindingSource.DataSource = this.pisLabUpdated;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.actionBindingSource, "productId", true));
            this.comboBox2.DataSource = this.productBindingSource;
            this.comboBox2.DisplayMember = "productName";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(652, 32);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.ValueMember = "productId";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.pisLabUpdated;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Введіть кількість товарів по акції";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(386, 111);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(91, 17);
            this.radioButton2.TabIndex = 20;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Зняти фільтр";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(274, 111);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(101, 17);
            this.radioButton1.TabIndex = 19;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Відфільтрувати";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(321, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "actionId";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код акції";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "amountOfProductsForAction";
            this.dataGridViewTextBoxColumn2.HeaderText = "Кількість товарів по акції";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "typeActionId";
            this.dataGridViewTextBoxColumn3.DataSource = this.typeActionBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "actionName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Тип акції";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "typeActionId";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "productId";
            this.dataGridViewTextBoxColumn4.DataSource = this.productBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "productName";
            this.dataGridViewTextBoxColumn4.HeaderText = "Товар";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "ProductId";
            // 
            // Action
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(actionIdLabel);
            this.Controls.Add(this.actionIdTextBox);
            this.Controls.Add(amountOfProductsForActionLabel);
            this.Controls.Add(this.amountOfProductsForActionTextBox);
            this.Controls.Add(typeActionIdLabel);
            this.Controls.Add(productIdLabel);
            this.Controls.Add(this.actionDataGridView);
            this.Controls.Add(this.actionBindingNavigator);
            this.Name = "Action";
            this.Text = "Акції";
            this.Load += new System.EventHandler(this.Action_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pisLabUpdated)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionBindingNavigator)).EndInit();
            this.actionBindingNavigator.ResumeLayout(false);
            this.actionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeActionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private pisLabUpdated pisLabUpdated;
        private System.Windows.Forms.BindingSource actionBindingSource;
        private pisLabUpdatedTableAdapters.ActionTableAdapter actionTableAdapter;
        private pisLabUpdatedTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator actionBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton actionBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView actionDataGridView;
        private pisLabUpdatedTableAdapters.TypeActionTableAdapter typeActionTableAdapter;
        private System.Windows.Forms.TextBox actionIdTextBox;
        private System.Windows.Forms.TextBox amountOfProductsForActionTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource typeActionBindingSource;
        private pisLabUpdatedTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
    }
}