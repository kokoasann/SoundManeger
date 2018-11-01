using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoundManeger
{
    public partial class FavConfigDialog : Form
    {
        private Form1 form;

        public FavConfigDialog(Form1 form)
        {
            InitializeComponent();
            this.form = form;

            foreach(var fs in this.form.Xset.filters.fil)
            {
                favsListBox.Items.Add(fs.filterName);
            }

            favsListBox.ContextMenuStrip = FavsMenuStrip;
            favListBox.ContextMenuStrip = FavMenuStrip;
        }

        private void favsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (favsListBox.SelectedIndex == -1)
                return;
            favListBox.Items.Clear();
            foreach(var f in form.Xset.filters.fil[favsListBox.SelectedIndex].fav)
            {
                string fn = form.path2fname(f);
                favListBox.Items.Add(fn);
            }
        }

        //filterの削除
        private void delToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (favsListBox.SelectedIndex == -1)
                return;
            form.Xset.filters.fil[favsListBox.SelectedIndex].fav.Clear();
            form.Xset.filters.fil.RemoveAt(favsListBox.SelectedIndex);
            favListBox.Items.Clear();

            

            favsListBox.Items.RemoveAt(favsListBox.SelectedIndex);
        }

        //favの削除
        private void ItemDeleteItem_Click(object sender, EventArgs e)
        {
            if (favListBox.SelectedIndex == -1 || favsListBox.SelectedIndex == -1)
                return;
            form.Xset.filters.fil[favsListBox.SelectedIndex].fav.RemoveAt(favListBox.SelectedIndex);

            //form.pathList.RemoveAt(favListBox.SelectedIndex);

            favListBox.Items.RemoveAt(favListBox.SelectedIndex);
        }
        
        private void FavConfigDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.xset2favslist();
        }
    }
}
