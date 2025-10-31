using System;
using System.Windows.Forms;

namespace sayitahmin
{
    public partial class MAINFORM : Form
    {
        public MAINFORM()
        {
            InitializeComponent();
        }

        private void btnSayiAvcisi_Click(object sender, EventArgs e)
        {
            SAYIAVCISIFORM sayiAvcisiForm = new SAYIAVCISIFORM();
            sayiAvcisiForm.Show();
        }

        private void btnNumWordle_Click(object sender, EventArgs e)
        {
            NUMWORDLEFORM numWordleForm = new NUMWORDLEFORM();
            numWordleForm.Show();
        }
    }
}