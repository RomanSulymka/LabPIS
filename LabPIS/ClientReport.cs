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
    public partial class ClientReport : Form
    {
        public ClientReport()
        {
            InitializeComponent();
        }

        private void ClientReport_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pisLabDataSet2.Client". При необходимости она может быть перемещена или удалена.
            this.ClientTableAdapter.Fill(this.pisLabDataSet2.Client);

            this.reportViewer1.RefreshReport();
        }
    }
}
