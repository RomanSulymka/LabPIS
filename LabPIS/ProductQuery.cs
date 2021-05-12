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
    public partial class ProductQuery : Form
    {
        public ProductQuery()
        {
            InitializeComponent();
        }

        private void ProductQuery_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pisLabUpdated.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.pisLabUpdated.Product);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pisLabUpdated.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.pisLabUpdated.Product);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.product1TableAdapter.Fill(this.pisLabUpdated.Product1, ((int)(System.Convert.ChangeType(p1ToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void p1ToolStripLabel_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
