
namespace LabPIS
{
    partial class DocumentsReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pisLabDataSet2 = new LabPIS.pisLabDataSet2();
            this.DocumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DocumentTableAdapter = new LabPIS.pisLabDataSet2TableAdapters.DocumentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pisLabDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.DocumentBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LabPIS.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 426);
            this.reportViewer1.TabIndex = 0;
            // 
            // pisLabDataSet2
            // 
            this.pisLabDataSet2.DataSetName = "pisLabDataSet2";
            this.pisLabDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DocumentBindingSource
            // 
            this.DocumentBindingSource.DataMember = "Document";
            this.DocumentBindingSource.DataSource = this.pisLabDataSet2;
            // 
            // DocumentTableAdapter
            // 
            this.DocumentTableAdapter.ClearBeforeFill = true;
            // 
            // DocumentsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "DocumentsReport";
            this.Text = "Звіт по документах";
            this.Load += new System.EventHandler(this.DocumentsReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pisLabDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DocumentBindingSource;
        private pisLabDataSet2 pisLabDataSet2;
        private pisLabDataSet2TableAdapters.DocumentTableAdapter DocumentTableAdapter;
    }
}