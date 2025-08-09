using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace OneLineParagraph
{
    public partial class Tools : Form
    {
        public Tools()
        {
            InitializeComponent();
        }



        private void BtnConvert_Click(object sender, EventArgs e)
        {
            string paragraph = txtInput.Text;
            string oneLine = Regex.Replace(paragraph, @"\s+", " ").Trim();
            txtOutput.Text = oneLine;
        }


        private void BtnScramble_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;


            string scrambled = ScrambleWithoutAdjacentDuplicates(input, 1000);

            if (!string.IsNullOrEmpty(scrambled) && scrambled != "[Failed to generate a scramble without adjacent duplicates]")
            {
                scrambled = char.ToUpper(scrambled[0]) + scrambled[1..];
            }

            txtOutput.Text = scrambled;
        }

        static string ScrambleWithoutAdjacentDuplicates(string input, int maxAttempts)
        {
            if (string.IsNullOrWhiteSpace(input))
                return "";

            Random rng = new();
            char[] chars = input.ToLower().ToCharArray();

            for (int attempt = 0; attempt < maxAttempts; attempt++)
            {
                var shuffled = chars.OrderBy(c => rng.Next()).ToArray();

                if (!HasAdjacentDuplicates(shuffled))
                    return new string(shuffled);
            }

            return "[Failed to generate a scramble without adjacent duplicates]";
        }


        static bool HasAdjacentDuplicates(char[] chars)
        {
            for (int i = 1; i < chars.Length; i++)
            {
                if (chars[i] == chars[i - 1])
                    return true;
            }
            return false;
        }



        private void BtnReplace_Click(object sender, EventArgs e)
        {
            string original = txtInput.Text;
            string toFind = txtFind.Text;
            string toReplace = null;
            string scrambled = ScrambleWithoutAdjacentDuplicates(toFind, 1000);

            if (!string.IsNullOrEmpty(scrambled) && scrambled != "[Failed to generate a scramble without adjacent duplicates]")
            {
                toReplace = char.ToUpper(scrambled[0]) + scrambled[1..];
            }


            if (string.IsNullOrEmpty(toFind))
            {
                MessageBox.Show("Please enter the text to find.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Use Regex for case-insensitive replace
            string pattern = Regex.Escape(toFind);
            string result = Regex.Replace(original, pattern, toReplace, RegexOptions.IgnoreCase);

            txtInput.Text = result;
            txtOutput.Text = result;
        }

        private void BtnCopyResult(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtOutput.Text))
            {
                Clipboard.SetText(txtOutput.Text);
                MessageBox.Show("Result copied to clipboard!", "Copied", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Result is empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnStringToBinary_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            byte[] bytes = Encoding.UTF8.GetBytes(input);
            txtOutput.Text = string.Join(" ", bytes.Select(b => Convert.ToString(b, 2).PadLeft(8, '0')));

        }

        private void BtnBinaryToString_Click(object sender, EventArgs e)
        {
            try
            {
                string[] binaryCodes = txtInput.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                byte[] bytes = binaryCodes.Select(b => Convert.ToByte(b, 2)).ToArray();
                txtOutput.Text = Encoding.UTF8.GetString(bytes);
            }
            catch
            {
                MessageBox.Show("Invalid binary format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
