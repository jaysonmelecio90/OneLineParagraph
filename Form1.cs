using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace OneLineParagraph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string paragraph = txtInput.Text;
            string oneLine = Regex.Replace(paragraph, @"\s+", " ").Trim();
            txtOutput.Text = oneLine;
        }
    }
}
