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
    public partial class Personal : Form
    {
        public Personal()
        {
            InitializeComponent();
        }

        private void Personal_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pisLabUpdated.Personal". При необходимости она может быть перемещена или удалена.
            this.personalTableAdapter.Fill(this.pisLabUpdated.Personal);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pisLabUpdated.Personal". При необходимости она может быть перемещена или удалена.
            this.personalTableAdapter.Fill(this.pisLabUpdated.Personal);

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personalBindingSource.EndEdit();
            try
            {
                this.tableAdapterManager.UpdateAll(this.pisLabUpdated);
            }
            catch (SqlException exception)
            {
                MessageBox.Show("Error: " + exception.Message, " Error");
            }
        }

        private void personalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personalBindingSource.EndEdit();
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
