using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht_6._3._3._2_2_
{
    public partial class OpdrachtZesDrieDrieTwee : Form
    {
        private int _score = 0;
        public OpdrachtZesDrieDrieTwee()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void OpdrachtZesDrieDrieTwee_Load(object sender, EventArgs e)
        {

        }

        private void txtProgress_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _score = int.Parse(txtProgress.Text);
                pbProgress.Value = _score;
            }
            catch
            {
                MessageBox.Show("Er is een fout opgetreden");
            }
        }
    }
}
