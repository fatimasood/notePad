using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace notePad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private string file = " ";
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "Text file|*.txt";

            if (dr == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(openFileDialog1.FileName);
                streamReader.Close();
                file = openFileDialog1.FileName;
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            richTextBox1.Redo();

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            richTextBox1.Undo();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            richTextBox1.SelectedText = " ";
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                richTextBox1.Paste();
            }

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != " ")
            {
                richTextBox1.Cut();
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = saveFileDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog1.FileName);
                streamWriter.Write(richTextBox1.Text);
                streamWriter.Close();
            }
            else
            {
                try
                {
                    StreamWriter streamWriter = new StreamWriter(saveFileDialog1.FileName);

                    streamWriter.Write(richTextBox1.Text);
                    streamWriter.Close();
                }
                catch
                {

                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.ShowDialog();
                System.IO.StreamWriter SaveFile = new
                System.IO.StreamWriter(saveFileDialog1.FileName);
                SaveFile.WriteLine(richTextBox1.Text);
                SaveFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex.Message);
                // MessageBox.Show("Sorry..!! something wrong, try again.", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit....??", " Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = printDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {

            }

        }
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void deleteAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void dateAndTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            richTextBox1.Text = dt.ToString();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void onToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.WordWrap = true;
        }

        private void offToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.WordWrap = false;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A simple notepad developed by Fatima Masood. it is helpful to save your information as long as you want. It's very easy to use, availability to change font save print and much more. ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // statusStrip1.Enabled = true;
            statusStrip1.Show();
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // statusStrip1.Enabled = false;
            statusStrip1.Hide();
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float currentSize;
            currentSize = richTextBox1.Font.Size;
            currentSize += 2.0F;
            richTextBox1.Font = new Font(richTextBox1.Font.Name, currentSize, richTextBox1.Font.Style, richTextBox1.Font.Unit);
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float currentSize;
            currentSize = richTextBox1.Font.Size;
            currentSize -= 2.0F;
            richTextBox1.Font = new Font(richTextBox1.Font.Name, currentSize, richTextBox1.Font.Style, richTextBox1.Font.Unit);
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "Hello User...!! You can write something from here....";

        }
        private void shareToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void zoomInToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            float currentSize;
            currentSize = richTextBox1.Font.Size;
            currentSize += 2.0F;
            richTextBox1.Font = new Font(richTextBox1.Font.Name, currentSize,
                richTextBox1.Font.Style, richTextBox1.Font.Unit);
        }

        private void zoomOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            float currentSize;
            currentSize = richTextBox1.Font.Size;
            currentSize -= 2.0F;
            richTextBox1.Font = new Font(richTextBox1.Font.Name, currentSize,
                richTextBox1.Font.Style, richTextBox1.Font.Unit);
        }
        private void colorsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ColorDialog colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {

                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void toolStripSplitButton1_Click(object sender, EventArgs e)
        {
            float currentSize;
            currentSize = richTextBox1.Font.Size;
            currentSize += 1.5F;
            richTextBox1.Font = new Font(richTextBox1.Font.Name, currentSize,
                richTextBox1.Font.Style, richTextBox1.Font.Unit);


        }
    }
}