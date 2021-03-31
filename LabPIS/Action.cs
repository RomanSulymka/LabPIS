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
    public partial class Action : Form
    {
        public Action()
        {
            InitializeComponent();
        }

        private void actionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.actionBindingSource.EndEdit();
            try
            {
                this.tableAdapterManager.UpdateAll(this.pisLabUpdated);
            }
            catch (SqlException exception)
            {
                MessageBox.Show("Error: " + exception.Message, " Error");
            }
        }

        private void Action_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pisLabUpdated.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.pisLabUpdated.Product);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pisLabUpdated.TypeAction". При необходимости она может быть перемещена или удалена.
            this.typeActionTableAdapter.Fill(this.pisLabUpdated.TypeAction);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pisLabUpdated.Action". При необходимости она может быть перемещена или удалена.
            this.actionTableAdapter.Fill(this.pisLabUpdated.Action);

        }
    }
}
