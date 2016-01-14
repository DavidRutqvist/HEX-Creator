using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRECCreator
{
    public partial class Form1 : Form
    {
        private FileFormatGenerator generator = new SRECGenerator();
        private GenerationMode generationMode = GenerationMode.AUTO;
        private Padding padding = Padding.NONE;
        private Condense condense = Condense.None;
        private bool justSearched = false;

        public Form1()
        {
            InitializeComponent();
            textboxHEX.Font = new Font(FontFamily.GenericMonospace, textboxHEX.Font.Size);
        }

        private byte[][] CondenseLines(byte[][] lines)
        {
            if ((condense != Condense.None) && (lines.Length > 0))
            {
                byte[] separators = null;
                switch (condense)
                {
                    case Condense.BLANK:
                        break;

                    case Condense.LF:
                        separators = new byte[] { 0x0A };
                        break;

                    case Condense.CR:
                        separators = new byte[] { 0x0D };
                        break;

                    case Condense.LFCR:
                        separators = new byte[] { 0x0A, 0x0D };
                        break;

                    case Condense.CRLF:
                        separators = new byte[] { 0x0D, 0x0A };
                        break;

                    case Condense.NULL:
                        separators = new byte[] { 0x00 };
                        break;
                }



                List<byte> condensedLines = new List<byte>();
                condensedLines.AddRange(lines[0]);

                //Merge all lines
                for (int i = 1; i < lines.Length; i++)
                {
                    if (separators != null)
                    {
                        condensedLines.AddRange(separators);
                    }
                    condensedLines = condensedLines.Concat(lines[i]).ToList();
                }

                return new byte[][] { condensedLines.ToArray() };
            }
            else
            {
                return lines;
            }
        }

        private byte[][] FixMaxWidth(List<byte> line) {
            if (!byteWidth.Text.ToLower().Equals("inf"))
            {
                int width = int.Parse(byteWidth.Text);
                int index = 0;
                List<byte[]> newLines = new List<byte[]>();
                int totalLength = line.Count;
                while (index < totalLength)
                {
                    if ((index + width) < totalLength)
                    {
                        newLines.Add(line.Skip(index).Take(width).ToArray());
                    }
                    else
                    {
                        newLines.Add(line.Skip(index).ToArray());
                    }
                    index += width;
                }

                return newLines.ToArray();
            }
            else
            {
                return new byte[][] { line.ToArray() };
            }
        }

        private string[] replaceSpecialCharacters(string[] lines)
        {
            List<string> replacedLines = new List<string>();
            foreach (var line in lines)
            {
                Regex regExp = new Regex("(0x[0-9A-Fa-f][0-9A-Fa-f])");
                string fixedLine = line;

                foreach (Match match in regExp.Matches(line))
                {
                    fixedLine = fixedLine.Replace(match.Value, Convert.ToChar(Convert.ToInt16(match.Value.Substring(2, 2), 16)).ToString());
                }
                replacedLines.Add(fixedLine);
            }

            return replacedLines.ToArray();
        }

        private void Generate() {
            textboxHEX.Lines = GenerateLines();
            highlight(textboxHEX);
        }

        private string[] GenerateLines()
        {
            
            var lines = CondenseLines(CommonHelper.GetBytes(replaceSpecialCharacters(textboxASCII.Lines)));

            List<byte[]> formattedLines = new List<byte[]>();

            foreach (var line in lines)
            {
                formattedLines.AddRange(FixMaxWidth(line.ToList()));
            }


            if (byteWidth.Text.ToLower().Equals("inf") || (padding == Padding.NONE))
            {
                return generator.Generate(formattedLines.ToArray());
            }
            else
            {
                byte pad = 0x00;
                if (padding == Padding.MAX)
                {
                    pad = 0xFF;
                }

                return generator.Generate(formattedLines.ToArray(), int.Parse(byteWidth.Text), pad);
            }
        }

        private enum Padding
        {
            NONE,
            MAX,
            MIN
        }

        private enum GenerationMode
        {
            MANUAL,
            AUTO
        }

        private enum Condense
        {
            None,
            LFCR,
            LF,
            CR,
            CRLF,
            BLANK,
            NULL
        }

        private void byteWidth_Leave(object sender, EventArgs e)
        {
            if (!byteWidth.Text.ToLower().Equals("inf"))
            {
                int width = 0;
                if (!int.TryParse(byteWidth.Text, out width))
                {
                    byteWidth.Text = "Inf";
                }
            }

            Generate();
        }

        private void noneToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            padding = Padding.NONE;
            Generate();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            padding = Padding.MIN;
            Generate();
        }

        private void fFToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            padding = Padding.MAX;
            Generate();
        }

        private void noneToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            condense = Condense.None;
            Generate();
        }

        private void lFToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            condense = Condense.LF;
            Generate();
        }

        private void cRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            condense = Condense.CR;
            Generate();
        }

        private void lFCRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            condense = Condense.LFCR;
            Generate();
        }

        private void cRLFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            condense = Condense.CRLF;
            Generate();
        }

        private void blankToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            condense = Condense.BLANK;
            Generate();
        }

        private void nULLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            condense = Condense.NULL;
            Generate();
        }

        private void paddingToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            noneToolStripMenuItem2.Image = null;
            toolStripMenuItem3.Image = null;
            fFToolStripMenuItem1.Image = null;

            switch (padding)
            {
                case Padding.NONE:
                    noneToolStripMenuItem2.Image = Icons.check;
                    break;

                case Padding.MIN:
                    toolStripMenuItem3.Image = Icons.check;
                    break;

                case Padding.MAX:
                    fFToolStripMenuItem1.Image = Icons.check;
                    break;
            }
        }

        private void mergeLinesToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            noneToolStripMenuItem1.Image = null;
            lFToolStripMenuItem1.Image = null;
            cRToolStripMenuItem.Image = null;
            lFCRToolStripMenuItem.Image = null;
            cRLFToolStripMenuItem.Image = null;
            blankToolStripMenuItem1.Image = null;
            nULLToolStripMenuItem.Image = null;

            switch (condense)
            {
                case Condense.NULL:
                    nULLToolStripMenuItem.Image = Icons.check;
                    break;

                case Condense.None:
                    noneToolStripMenuItem1.Image = Icons.check;
                    break;

                case Condense.LFCR:
                    lFCRToolStripMenuItem.Image = Icons.check;
                    break;

                case Condense.LF:
                    lFToolStripMenuItem1.Image = Icons.check;
                    break;

                case Condense.CRLF:
                    cRLFToolStripMenuItem.Image = Icons.check;
                    break;

                case Condense.CR:
                    cRToolStripMenuItem.Image = Icons.check;
                    break;

                case Condense.BLANK:
                    blankToolStripMenuItem1.Image = Icons.check;
                    break;
            }
        }

        private void generate_ButtonClick(object sender, EventArgs e)
        {
            Generate();
        }

        private void autoGenerateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (generationMode == GenerationMode.AUTO)
            {
                generationMode = GenerationMode.MANUAL;
            }
            else
            {
                generationMode = GenerationMode.AUTO;
            }
        }

        private void generate_DropDownOpening(object sender, EventArgs e)
        {
            autoGenerateToolStripMenuItem.Image = null;

            if (generationMode == GenerationMode.AUTO)
            {
                autoGenerateToolStripMenuItem.Image = Icons.check;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HEX creator v" + FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).FileVersion + ".\nCreated by David Rutqvist (david.rutqvist@bnearit.se)\n2015", "About");
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You have unsaved changes, are you sure that you want to discard these changes?", "Confirm", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                textboxASCII.Clear();
                textboxHEX.Clear();
            }
        }

        private void exportFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            var lines = GenerateLines();

            using (StreamWriter file = new StreamWriter(exportFileDialog.FileName))
            {
                int index = 0;
                foreach (var line in lines)
                {
                    index++;
                    if (index != lines.Length)
                    {
                        file.WriteLine(line);
                    }
                    else
                    {
                        file.Write(line);
                    }
                }
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            exportFileDialog.ShowDialog();
        }

        private void highlightASCII() {
            //Get cursor position
            int cursorIndex = -1;
            if (textboxASCII.Focused)
            {
                cursorIndex = textboxASCII.SelectionStart;
            }

            //Reset highlighting
            textboxASCII.Select(0, textboxASCII.TextLength);
            textboxASCII.SelectionColor = Color.Black;
            textboxASCII.SelectionBackColor = Color.White;

            Regex regExp = new Regex("(0x[0-9A-Fa-f][0-9A-Fa-f])");

            foreach (Match match in regExp.Matches(textboxASCII.Text))
            {
                textboxASCII.Select(match.Index, match.Length);
                textboxASCII.SelectionBackColor = Color.Gray;
                textboxASCII.SelectionColor = Color.White;
            }

            textboxASCII.DeselectAll();

            //Set cursor position
            if (cursorIndex != -1)
            {
                textboxASCII.SelectionStart = cursorIndex;
            }
            else
            {
                textboxASCII.SelectionStart = textboxASCII.TextLength;
            }
        }

        private void highlight(RichTextBox rtb)
        {
            //Reset
            rtb.Select(0, rtb.TextLength);
            rtb.SelectionColor = Color.Black;
            rtb.SelectionBackColor = Color.White;


            //TODO: Make dynamical using XML or something

            //Highlight S#
            Regex regExp = new Regex("([S][0-9])");

            foreach (Match match in regExp.Matches(rtb.Text))
            {
                rtb.Select(match.Index, match.Length);
                rtb.SelectionBackColor = Color.LightSkyBlue;
            }

            //Highlight byte count
            Regex regExp2 = new Regex("(?<=S[0-9])..(?=.)*");
            foreach (Match match in regExp2.Matches(rtb.Text))
            {
                rtb.Select(match.Index, match.Length);
                rtb.SelectionBackColor = Color.LightPink;
            }

            //Highlight address count
            Regex regExp3 = new Regex("(?<=S[0-9]..)....(?=.)*");
            foreach (Match match in regExp3.Matches(rtb.Text))
            {
                rtb.Select(match.Index, match.Length);
                rtb.SelectionBackColor = Color.LightGreen;
            }

            //Highlight checksum
            Regex regExp4 = new Regex("..(?:$|\n)");
            foreach (Match match in regExp4.Matches(rtb.Text))
            {
                rtb.Select(match.Index, match.Length);
                rtb.SelectionBackColor = Color.LightSalmon;
            }

            rtb.DeselectAll();
        }

        private void search(string searchstring, bool isRegularExpr = false)
        {
            //Get cursor position
            int cursorIndex = -1;
            bool hadFocus = textboxASCII.Focused;
            if (textboxASCII.Focused)
            {
                cursorIndex = textboxASCII.SelectionStart;
            }

            highlightASCII();
            highlight(textboxHEX);

            Regex regExp = null;
            if(isRegularExpr) {
                try
                {
                    regExp = new Regex(searchstring, RegexOptions.IgnoreCase);//TODO: Case is option?
                }
                catch (Exception)
                {
                    MessageBox.Show("The regular expression you entered was not valid", "Error");
                }
            }
            else {
                regExp = new Regex(@"(" + searchstring + @")", RegexOptions.IgnoreCase);//TODO: Case is option?
            }


            foreach (Match match in regExp.Matches(textboxHEX.Text))
            {
                textboxHEX.Select(match.Index, match.Length);
                textboxHEX.SelectionBackColor = Color.Orange;
            }

            foreach (Match match in regExp.Matches(textboxASCII.Text))
            {
                textboxASCII.Select(match.Index, match.Length);
                textboxASCII.SelectionBackColor = Color.Orange;
            }

            textboxASCII.DeselectAll();
            textboxHEX.DeselectAll();

            //Set cursor position
            if (hadFocus)
            {
                if (cursorIndex != -1)
                {
                    textboxASCII.SelectionStart = cursorIndex;
                }
                else
                {
                    textboxASCII.SelectionStart = textboxASCII.TextLength;
                }
            }

            justSearched = true;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Shift | Keys.F))
            {
                search(PromptDialog.ShowDialog("Find using regular expression:", "Find"), true);
                return true;
            }
            else if (keyData == (Keys.Control | Keys.F))
            {
                search(PromptDialog.ShowDialog("Find what:", "Find"));
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void textboxASCII_KeyUp(object sender, KeyEventArgs e)
        {
            if (!justSearched)
            {
                if (generationMode == GenerationMode.AUTO)
                {
                    Generate();
                }

                if (textboxASCII.Lines.Length > 0)
                {
                    toolStripButton3.Enabled = true;
                }
                else
                {
                    toolStripButton3.Enabled = false;
                }

                highlightASCII();
            }
            justSearched = false;
        }
    }
}
