using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabPIS
{
    public partial class DocumentsReport : Form
    {
        public DocumentsReport()
        {
            InitializeComponent();
        }

        private void documentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void DocumentsReport_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pisLabDataSet2.Document". При необходимости она может быть перемещена или удалена.
            this.DocumentTableAdapter.Fill(this.pisLabDataSet2.Document);
            this.reportViewer1.RefreshReport();
        }
    }
}
