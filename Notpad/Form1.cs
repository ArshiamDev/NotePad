using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notpad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            txtMain.Text = String.Empty;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Select File";
            open.Filter = "All File (*.*)|*.*|Text File (*.txt*)|*.txt";
            if(open.ShowDialog() == DialogResult.OK)
            {
               txtMain.Text=System.IO.File.ReadAllText(open.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save Your File !";
            save.Filter = "All File(*.*)|*.*|Text File (*.txt)|*.txt";
            save.OverwritePrompt = true;
            if(save.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(save.FileName, txtMain.Text);
                this.Text = save.FileName;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMain.Text = String.Empty;
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            openToolStripMenuItem_Click( sender,  e);
        }

        private void txtMain_TextChanged(object sender, EventArgs e)
        {

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox mytextbox=(TextBox) this.ActiveControl;
            mytextbox.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox mytextbox = (TextBox)this.ActiveControl;
            mytextbox.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox mytextbox = (TextBox)this.ActiveControl;
            mytextbox.Paste();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            cutToolStripMenuItem_Click(sender, e);
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            copyToolStripMenuItem_Click( sender, e);
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            pasteToolStripMenuItem_Click(sender, e);
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem_Click(sender, e);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}