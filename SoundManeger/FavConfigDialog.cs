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

            favsListBox.ContextMenuStrip = contextMenuStrip1;
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
    }
}
