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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pisLabUpdated.Order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.pisLabUpdated.Order);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pisLabUpdated.Order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.pisLabUpdated.Order);
        }


        private void orderBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.orderBindingSource.EndEdit();
            try
            {
                this.tableAdapterManager.UpdateAll(this.pisLabUpdated);
            }
            catch (SqlException exception)
            {
                MessageBox.Show("Error: " + exception.Message, " Error");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.orderBindingSource.Filter = "(amountOrderedProducts='" + textBox1.Text + "')";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.orderBindingSource.RemoveFilter();
        }
    }
}
