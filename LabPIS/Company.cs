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
    public partial class Company : Form
    {
        public Company()
        {
            InitializeComponent();
        }

        private void Company_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pisLabUpdated.Company". При необходимости она может быть перемещена или удалена.
            this.companyTableAdapter.Fill(this.pisLabUpdated.Company);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pisLabUpdated.Company". При необходимости она может быть перемещена или удалена.
            this.companyTableAdapter.Fill(this.pisLabUpdated.Company);

        }

       
        private void companyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.companyBindingSource.EndEdit();
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
