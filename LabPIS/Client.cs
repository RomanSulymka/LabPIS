using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LabPIS
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pisLabUpdated.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter1.Fill(this.pisLabUpdated.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pisLabUpdated.Company". При необходимости она может быть перемещена или удалена.
            this.companyTableAdapter.Fill(this.pisLabUpdated.Company);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pisLabUpdated.Enterprenuer". При необходимости она может быть перемещена или удалена.
            this.enterprenuerTableAdapter.Fill(this.pisLabUpdated.Enterprenuer);


        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            try
            {
                this.tableAdapterManager1.UpdateAll(this.pisLabUpdated);
            }
            catch (SqlException exception)
            {
                MessageBox.Show("Error: " + exception.Message, " Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int itemFound = this.clientBindingSource.Find("clientName", textBox2.Text);
            this.clientBindingSource.Position = itemFound;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
