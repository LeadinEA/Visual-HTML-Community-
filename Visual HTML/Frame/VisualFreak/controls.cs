﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_HTML.Frame.VisualFreak
{
    public partial class controls : Form
    {
        public controls()
        {
            InitializeComponent();
        }

        private void controls_Load(object sender, EventArgs e)
        {
            Icon icon = new Icon("Assets\\vishtml.ico");
            this.Icon = icon;
        }
    }
}
