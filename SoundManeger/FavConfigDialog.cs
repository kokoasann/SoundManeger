﻿using System;
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
        }
    }
}