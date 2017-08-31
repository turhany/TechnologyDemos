using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SyntaxHigh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            const string tokens = "(test|keyword|highlight)";

            Regex rex = new Regex(tokens);

            MatchCollection mc = rex.Matches(richTextBox1.Text);
            int startCursorPosition = richTextBox1.SelectionStart;
            foreach (Match m in mc)
            {
                var startIndex = m.Index;
                var stopIndex = m.Length;

                richTextBox1.Select(startIndex, stopIndex);
                richTextBox1.SelectionColor = Color.Blue;
                richTextBox1.SelectionStart = startCursorPosition;
                richTextBox1.SelectionColor = Color.Black;
            }
        }
    }
}
