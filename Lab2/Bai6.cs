using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Lab2
{
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
            treeFolder.NodeMouseDoubleClick += TreeFolder_NodeMouseDoubleClick;
            InitTree();
        }

        private void InitTree()
        {
            string[] drives = Directory.GetLogicalDrives();
            foreach (string drive in drives)
            {
                TreeNode node = new TreeNode(drive);
                treeFolder.Nodes.Add(node);
                node.Nodes.Add("Temp");
            }
        }

        private void LoadDirectories(string path, TreeNodeCollection nodes)
        {
            try
            {
                string[] directories = Directory.GetDirectories(path);
                foreach (string directory in directories)
                {
                    TreeNode node = new TreeNode(Path.GetFileName(directory));
                    nodes.Add(node);
                    node.Nodes.Add("Temp");
                }

                string[] files = Directory.GetFiles(path);
                foreach (string file in files)
                {
                    TreeNode node = new TreeNode(Path.GetFileName(file));
                    nodes.Add(node);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void TreeFolder_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode node = e.Node;
            string fullPath = node.FullPath;

            if (File.Exists(fullPath))
            {
                string fileExtension = Path.GetExtension(fullPath).ToLower();
                if (fileExtension == ".jpg" || fileExtension == ".jpeg" || fileExtension == ".png" || fileExtension == ".gif")
                {
                    pictureBox.Visible = true;
                    txtNoiDung.Visible = false;
                    pictureBox.Image = Image.FromFile(fullPath);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (fileExtension == ".txt")
                {
                    pictureBox.Visible = false;
                    txtNoiDung.Visible = true;
                    txtNoiDung.Text = File.ReadAllText(fullPath);
                }
                else
                {
                    Process.Start(fullPath);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void treeFolder_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            node.Nodes.Clear();
            node.ImageIndex = 1;
            string fullPath = node.FullPath;
            LoadDirectories(fullPath, node.Nodes);
        }

        private void treeFolder_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}