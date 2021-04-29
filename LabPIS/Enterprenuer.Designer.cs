
namespace LabPIS
{
    partial class Enterprenuer
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
            System.Windows.Forms.Label enterprenuerIdLabel;
            System.Windows.Forms.Label taxNumberLabel;
            System.Windows.Forms.Label cashRegisterLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Enterprenuer));
            this.pisLabUpdated = new LabPIS.pisLabUpdated();
            this.enterprenuerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enterprenuerTableAdapter = new LabPIS.pisLabUpdatedTableAdapters.EnterprenuerTableAdapter();
            this.tableAdapterManager = new LabPIS.pisLabUpdatedTableAdapters.TableAdapterManager();
            this.enterprenuerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.enterprenuerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.enterprenuerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enterprenuerIdTextBox = new System.Windows.Forms.TextBox();
            this.taxNumberTextBox = new System.Windows.Forms.TextBox();
            this.cashRegisterTextBox = new System.Windows.Forms.TextBox();
            enterprenuerIdLabel = new System.Windows.Forms.Label();
            taxNumberLabel = new System.Windows.Forms.Label();
            cashRegisterLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pisLabUpdated)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterprenuerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterprenuerBindingNavigator)).BeginInit();
            this.enterprenuerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enterprenuerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // enterprenuerIdLabel
            // 
            enterprenuerIdLabel.AutoSize = true;
            enterprenuerIdLabel.Location = new System.Drawing.Point(421, 28);
            enterprenuerIdLabel.Name = "enterprenuerIdLabel";
            enterprenuerIdLabel.Size = new System.Drawing.Size(90, 13);
            enterprenuerIdLabel.TabIndex = 2;
            enterprenuerIdLabel.Text = "Код підприємця:";
            // 
            // taxNumberLabel
            // 
            taxNumberLabel.AutoSize = true;
            taxNumberLabel.Location = new System.Drawing.Point(416, 74);
            taxNumberLabel.Name = "taxNumberLabel";
            taxNumberLabel.Size = new System.Drawing.Size(106, 13);
            taxNumberLabel.TabIndex = 4;
            taxNumberLabel.Text = "Податковий номер:";
            // 
            // cashRegisterLabel
            // 
            cashRegisterLabel.AutoSize = true;
            cashRegisterLabel.Location = new System.Drawing.Point(415, 127);
            cashRegisterLabel.Name = "cashRegisterLabel";
            cashRegisterLabel.Size = new System.Drawing.Size(103, 13);
            cashRegisterLabel.TabIndex = 6;
            cashRegisterLabel.Text = "Назва підприємця:";
            // 
            // pisLabUpdated
            // 
            this.pisLabUpdated.DataSetName = "pisLabUpdated";
            this.pisLabUpdated.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActionTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.CompanyTableAdapter = null;
            this.tableAdapterManager.DocumentTableAdapter = null;
            this.tableAdapterManager.EnterprenuerTableAdapter = this.enterprenuerTableAdapter;
            this.tableAdapterManager.InvoiceTableAdapter = null;
            this.tableAdapterManager.LineOfDocumentTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.PersonalTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.TypeActionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LabPIS.pisLabUpdatedTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // enterprenuerBindingNavigator
            // 
            this.enterprenuerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.enterprenuerBindingNavigator.BindingSource = this.enterprenuerBindingSource;
            this.enterprenuerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.enterprenuerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.enterprenuerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.enterprenuerBindingNavigatorSaveItem});
            this.enterprenuerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.enterprenuerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.enterprenuerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.enterprenuerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.enterprenuerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.enterprenuerBindingNavigator.Name = "enterprenuerBindingNavigator";
            this.enterprenuerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.enterprenuerBindingNavigator.Size = new System.Drawing.Size(535, 25);
            this.enterprenuerBindingNavigator.TabIndex = 0;
            this.enterprenuerBindingNavigator.Text = "bindingNavigator1";
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
            // enterprenuerBindingNavigatorSaveItem
            // 
            this.enterprenuerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.enterprenuerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("enterprenuerBindingNavigatorSaveItem.Image")));
            this.enterprenuerBindingNavigatorSaveItem.Name = "enterprenuerBindingNavigatorSaveItem";
            this.enterprenuerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.enterprenuerBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.enterprenuerBindingNavigatorSaveItem.Click += new System.EventHandler(this.enterprenuerBindingNavigatorSaveItem_Click);
            // 
            // enterprenuerDataGridView
            // 
            this.enterprenuerDataGridView.AutoGenerateColumns = false;
            this.enterprenuerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enterprenuerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.enterprenuerDataGridView.DataSource = this.enterprenuerBindingSource;
            this.enterprenuerDataGridView.Location = new System.Drawing.Point(12, 28);
            this.enterprenuerDataGridView.Name = "enterprenuerDataGridView";
            this.enterprenuerDataGridView.Size = new System.Drawing.Size(384, 220);
            this.enterprenuerDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "enterprenuerId";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код підприємця";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "taxNumber";
            this.dataGridViewTextBoxColumn2.HeaderText = "Податковий номер";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "cashRegister";
            this.dataGridViewTextBoxColumn3.HeaderText = "Назва підприємця";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // enterprenuerIdTextBox
            // 
            this.enterprenuerIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enterprenuerBindingSource, "enterprenuerId", true));
            this.enterprenuerIdTextBox.Location = new System.Drawing.Point(416, 44);
            this.enterprenuerIdTextBox.Name = "enterprenuerIdTextBox";
            this.enterprenuerIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.enterprenuerIdTextBox.TabIndex = 3;
            // 
            // taxNumberTextBox
            // 
            this.taxNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enterprenuerBindingSource, "taxNumber", true));
            this.taxNumberTextBox.Location = new System.Drawing.Point(416, 94);
            this.taxNumberTextBox.Name = "taxNumberTextBox";
            this.taxNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.taxNumberTextBox.TabIndex = 5;
            // 
            // cashRegisterTextBox
            // 
            this.cashRegisterTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enterprenuerBindingSource, "cashRegister", true));
            this.cashRegisterTextBox.Location = new System.Drawing.Point(416, 143);
            this.cashRegisterTextBox.Name = "cashRegisterTextBox";
            this.cashRegisterTextBox.Size = new System.Drawing.Size(100, 20);
            this.cashRegisterTextBox.TabIndex = 7;
            // 
            // Enterprenuer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 266);
            this.Controls.Add(enterprenuerIdLabel);
            this.Controls.Add(this.enterprenuerIdTextBox);
            this.Controls.Add(taxNumberLabel);
            this.Controls.Add(this.taxNumberTextBox);
            this.Controls.Add(cashRegisterLabel);
            this.Controls.Add(this.cashRegisterTextBox);
            this.Controls.Add(this.enterprenuerDataGridView);
            this.Controls.Add(this.enterprenuerBindingNavigator);
            this.Name = "Enterprenuer";
            this.Text = "Приватний підприємець";
            this.Load += new System.EventHandler(this.Enterprenuer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pisLabUpdated)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterprenuerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterprenuerBindingNavigator)).EndInit();
            this.enterprenuerBindingNavigator.ResumeLayout(false);
            this.enterprenuerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enterprenuerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private pisLabUpdated pisLabUpdated;
        private System.Windows.Forms.BindingSource enterprenuerBindingSource;
        private pisLabUpdatedTableAdapters.EnterprenuerTableAdapter enterprenuerTableAdapter;
        private pisLabUpdatedTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator enterprenuerBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton enterprenuerBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView enterprenuerDataGridView;
        private System.Windows.Forms.TextBox enterprenuerIdTextBox;
        private System.Windows.Forms.TextBox taxNumberTextBox;
        private System.Windows.Forms.TextBox cashRegisterTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}