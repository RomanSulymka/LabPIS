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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pisLabDataSet2.Personal". При необходимости она может быть перемещена или удалена.
            this.personalTableAdapter.Fill(this.pisLabDataSet2.Personal);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pisLabDataSet2.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.pisLabDataSet2.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pisLabDataSet2.Document". При необходимости она может быть перемещена или удалена.
            this.documentTableAdapter.Fill(this.pisLabDataSet2.Document);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pisLabDataSet2.Document". При необходимости она может быть перемещена или удалена.
            this.documentTableAdapter.Fill(this.pisLabDataSet2.Document);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pisLabDataSet2.Document". При необходимости она может быть перемещена или удалена.
            this.documentTableAdapter.Fill(this.pisLabDataSet2.Document);
        }

        private void documentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.documentBindingSource.EndEdit();
            try
            {
                this.tableAdapterManager.UpdateAll(this.pisLabDataSet2);
            }
            catch (SqlException exception)
            {
                MessageBox.Show("Error: " + exception.Message, " Error");
            }
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

    }
}
