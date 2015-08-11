using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Xml;

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
            FolderDialog folderDialog = new FolderDialog();

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("User selected OK");
            }
            else
            {
                MessageBox.Show("User Selected Cancel");
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FolderDialog folderDialog = new FolderDialog();

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("User selected OK");
            }
            else
            {
                MessageBox.Show("User Selected Cancel");
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FolderDialog folderDialog = new FolderDialog();

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("User selected OK");
            }
            else
            {
                MessageBox.Show("User Selected Cancel");
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            ChannelDialog channelDialog = new ChannelDialog();

            if (channelDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("User selected OK");
            }
            else
            {
                MessageBox.Show("User Selected Cancel");
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            ChannelDialog channelDialog = new ChannelDialog();

            if (channelDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("User selected OK");
            }
            else
            {
                MessageBox.Show("User Selected Cancel");
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            ChannelDialog channelDialog = new ChannelDialog();

            if (channelDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("User selected OK");
            }
            else
            {
                MessageBox.Show("User Selected Cancel");
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            string rssURL = "http://www.rte.ie/news/rss/news-headlines.xml";

            RssManager.RefreshRSS(rssURL);
        }
    }
}
