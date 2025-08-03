using System;
using System.Linq;
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


        private void btnScramble_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;


            string scrambled = ScrambleWithoutAdjacentDuplicates(input, 1000);

            if (!string.IsNullOrEmpty(scrambled) && scrambled != "[Failed to generate a scramble without adjacent duplicates]")
            {
                scrambled = char.ToUpper(scrambled[0]) + scrambled.Substring(1);
            }

            txtOutput.Text = scrambled;
        }

        static string ScrambleWithoutAdjacentDuplicates(string input, int maxAttempts)
        {
            if (string.IsNullOrWhiteSpace(input))
                return "";

            Random rng = new Random();
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
    }
}
