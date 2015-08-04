using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSSReader
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Will open the Help Contents");
        }

        private void indexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Will open the Help Index");
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Will open the Help Search");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Will open the About Dialog");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Will open Folder Dialog");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Will open Folder Dialog");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Will open Folder Dialog");
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Will open Channel Dialog");
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Will open Channel Dialog");
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Will open Channel Dialog");
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Will Refresh RSS feed");
        }
    }
}
