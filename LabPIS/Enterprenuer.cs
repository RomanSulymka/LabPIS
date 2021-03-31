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
    public partial class Enterprenuer : Form
    {
        public Enterprenuer()
        {
            InitializeComponent();
        }

        private void enterprenuerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.enterprenuerBindingSource.EndEdit();
            try
            {
                this.tableAdapterManager.UpdateAll(this.pisLabUpdated);
            }
            catch (SqlException exception)
            {
                MessageBox.Show("Error: " + exception.Message, " Error");
            }
        }

        private void Enterprenuer_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pisLabUpdated.Enterprenuer". При необходимости она может быть перемещена или удалена.
            this.enterprenuerTableAdapter.Fill(this.pisLabUpdated.Enterprenuer);

        }
    }
}
