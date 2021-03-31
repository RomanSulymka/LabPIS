
namespace LabPIS
{
    partial class TypeOfAction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TypeOfAction));
            System.Windows.Forms.Label typeActionIdLabel;
            System.Windows.Forms.Label actionNameLabel;
            this.pisLabUpdated = new LabPIS.pisLabUpdated();
            this.typeActionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeActionTableAdapter = new LabPIS.pisLabUpdatedTableAdapters.TypeActionTableAdapter();
            this.tableAdapterManager = new LabPIS.pisLabUpdatedTableAdapters.TableAdapterManager();
            this.typeActionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.typeActionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.typeActionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeActionIdTextBox = new System.Windows.Forms.TextBox();
            this.actionNameTextBox = new System.Windows.Forms.TextBox();
            typeActionIdLabel = new System.Windows.Forms.Label();
            actionNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pisLabUpdated)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeActionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeActionBindingNavigator)).BeginInit();
            this.typeActionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeActionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pisLabUpdated
            // 
            this.pisLabUpdated.DataSetName = "pisLabUpdated";
            this.pisLabUpdated.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeActionBindingSource
            // 
            this.typeActionBindingSource.DataMember = "TypeAction";
            this.typeActionBindingSource.DataSource = this.pisLabUpdated;
            // 
            // typeActionTableAdapter
            // 
            this.typeActionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActionTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.CompanyTableAdapter = null;
            this.tableAdapterManager.DocumentTableAdapter = null;
            this.tableAdapterManager.EnterprenuerTableAdapter = null;
            this.tableAdapterManager.InvoiceTableAdapter = null;
            this.tableAdapterManager.LineOfDocumentTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.PersonalTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.TypeActionTableAdapter = this.typeActionTableAdapter;
            this.tableAdapterManager.UpdateOrder = LabPIS.pisLabUpdatedTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // typeActionBindingNavigator
            // 
            this.typeActionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.typeActionBindingNavigator.BindingSource = this.typeActionBindingSource;
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
            this.typeActionBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.typeActionBindingNavigator.TabIndex = 0;
            this.typeActionBindingNavigator.Text = "bindingNavigator1";
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
            // typeActionBindingNavigatorSaveItem
            // 
            this.typeActionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.typeActionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("typeActionBindingNavigatorSaveItem.Image")));
            this.typeActionBindingNavigatorSaveItem.Name = "typeActionBindingNavigatorSaveItem";
            this.typeActionBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.typeActionBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.typeActionBindingNavigatorSaveItem.Click += new System.EventHandler(this.typeActionBindingNavigatorSaveItem_Click);
            // 
            // typeActionDataGridView
            // 
            this.typeActionDataGridView.AutoGenerateColumns = false;
            this.typeActionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.typeActionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.typeActionDataGridView.DataSource = this.typeActionBindingSource;
            this.typeActionDataGridView.Location = new System.Drawing.Point(26, 150);
            this.typeActionDataGridView.Name = "typeActionDataGridView";
            this.typeActionDataGridView.Size = new System.Drawing.Size(300, 220);
            this.typeActionDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "typeActionId";
            this.dataGridViewTextBoxColumn1.HeaderText = "typeActionId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "actionName";
            this.dataGridViewTextBoxColumn2.HeaderText = "actionName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // typeActionIdLabel
            // 
            typeActionIdLabel.AutoSize = true;
            typeActionIdLabel.Location = new System.Drawing.Point(23, 51);
            typeActionIdLabel.Name = "typeActionIdLabel";
            typeActionIdLabel.Size = new System.Drawing.Size(75, 13);
            typeActionIdLabel.TabIndex = 2;
            typeActionIdLabel.Text = "type Action Id:";
            // 
            // typeActionIdTextBox
            // 
            this.typeActionIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.typeActionBindingSource, "typeActionId", true));
            this.typeActionIdTextBox.Location = new System.Drawing.Point(104, 48);
            this.typeActionIdTextBox.Name = "typeActionIdTextBox";
            this.typeActionIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.typeActionIdTextBox.TabIndex = 3;
            // 
            // actionNameLabel
            // 
            actionNameLabel.AutoSize = true;
            actionNameLabel.Location = new System.Drawing.Point(23, 77);
            actionNameLabel.Name = "actionNameLabel";
            actionNameLabel.Size = new System.Drawing.Size(70, 13);
            actionNameLabel.TabIndex = 4;
            actionNameLabel.Text = "action Name:";
            // 
            // actionNameTextBox
            // 
            this.actionNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.typeActionBindingSource, "actionName", true));
            this.actionNameTextBox.Location = new System.Drawing.Point(104, 74);
            this.actionNameTextBox.Name = "actionNameTextBox";
            this.actionNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.actionNameTextBox.TabIndex = 5;
            // 
            // TypeOfAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(typeActionIdLabel);
            this.Controls.Add(this.typeActionIdTextBox);
            this.Controls.Add(actionNameLabel);
            this.Controls.Add(this.actionNameTextBox);
            this.Controls.Add(this.typeActionDataGridView);
            this.Controls.Add(this.typeActionBindingNavigator);
            this.Name = "TypeOfAction";
            this.Text = "TypeOfAction";
            this.Load += new System.EventHandler(this.TypeOfAction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pisLabUpdated)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeActionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeActionBindingNavigator)).EndInit();
            this.typeActionBindingNavigator.ResumeLayout(false);
            this.typeActionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeActionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private pisLabUpdated pisLabUpdated;
        private System.Windows.Forms.BindingSource typeActionBindingSource;
        private pisLabUpdatedTableAdapters.TypeActionTableAdapter typeActionTableAdapter;
        private pisLabUpdatedTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.DataGridView typeActionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox typeActionIdTextBox;
        private System.Windows.Forms.TextBox actionNameTextBox;
    }
}