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
    public partial class Document : Form
    {
        public Document()
        {
            InitializeComponent();
        }

        private void Document_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pisLabUpdated.Personal". При необходимости она может быть перемещена или удалена.
            this.personalTableAdapter.Fill(this.pisLabUpdated.Personal);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pisLabUpdated.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.pisLabUpdated.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pisLabUpdated.Document". При необходимости она может быть перемещена или удалена.
            this.documentTableAdapter.Fill(this.pisLabUpdated.Document);
        }


     /*   private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.documentBindingSource.Filter = "(documentType='" + textBox1.Text + "')";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.documentBindingSource.RemoveFilter();

        }
     */
        private void documentBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.documentBindingSource.EndEdit();
            try
            {
                this.tableAdapterManager.UpdateAll(this.pisLabUpdated);
            }
            catch (SqlException exception)
            {
                MessageBox.Show("Error: " + exception.Message, " Error");
            }

        }

        private void documentBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
