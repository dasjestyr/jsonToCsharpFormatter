using System;
using System.Windows.Forms;

namespace JsonPasteToJsonObjectFormatter
{
    public partial class Formatter : Form
    {
        public Formatter()
        {
            InitializeComponent();
        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            var formatter = new NewtonsoftClassFormatter();
            var result = formatter.GetFormatted(txtInput.Text);
            txtOutput.Text = result;

            if(cbCopyToClipboard.Checked)
                Clipboard.SetText(result);
        }
    }
}
