﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubwayForms.Forms
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            Load += MenuForm_Load;
            this.BackColor = Color.Red;
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
