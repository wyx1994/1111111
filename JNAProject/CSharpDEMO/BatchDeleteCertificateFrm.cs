using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEMO
{
    public partial class BatchDeleteCertificateFrm : Form
    {
        public BatchDeleteCertificateFrm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BatchDeleteCertificateFrm_Load(object sender, EventArgs e)
        {
            comboBox_credenceType.SelectedIndex = 0;
        }
    }
}
