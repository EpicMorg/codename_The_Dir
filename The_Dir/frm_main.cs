using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace The_Dir
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
            
        {
            txt_mask1.SelectedIndex = 0;
               txt_mask1.Items.AddRange(Properties.Resources.ResourceManager.GetString("src").Split(new char[] { '\n' }));
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            txt_result.Lines = Directory.GetFiles(txt_path.Text, txt_mask1.Text, cbx_findrec.Checked?SearchOption.AllDirectories:SearchOption.TopDirectoryOnly).Select(x=>cbx_fullpath.Checked?x:Path.GetFileName(x)).ToArray();
           
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            if (dialog_browse.ShowDialog() == DialogResult.OK)
            {
                txt_path.Text = dialog_browse.SelectedPath;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (dialog_save.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dialog_save.FileName, txt_result.Text);
            }
        }

        private void frm_main_MouseDown(object sender, MouseEventArgs e)
        {
            this.Capture = false;
            Message n = Message.Create(this.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref n);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frm_about dsk = new frm_about();
            dsk.ShowDialog();
        }

        private void txt_mask1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
            
    }
}
