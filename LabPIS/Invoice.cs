using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabPIS
{
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pisLabUpdated.Invoice". При необходимости она может быть перемещена или удалена.
            this.invoiceTableAdapter.Fill(this.pisLabUpdated.Invoice);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pisLabUpdated.Invoice". При необходимости она может быть перемещена или удалена.
            this.invoiceTableAdapter.Fill(this.pisLabUpdated.Invoice);

        }

        private void invoiceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.invoiceBindingSource.EndEdit();
            try
            {
                this.tableAdapterManager.UpdateAll(this.pisLabUpdated);
            }
            catch (SqlException exception)
            {
                MessageBox.Show("Error: " + exception.Message, " Error");
            }
        }
    }
}
