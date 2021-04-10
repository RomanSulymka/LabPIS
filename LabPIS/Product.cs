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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pisLabUpdated.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.pisLabUpdated.Product);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pisLabUpdated.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.pisLabUpdated.Product);

        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
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
            this.productBindingSource.Filter = "(productManufacturer='" + textBox1.Text + "')";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.productBindingSource.RemoveFilter();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int itemFound = this.productBindingSource.Find("productName", textBox2.Text);

            this.productBindingSource.Position = itemFound;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
