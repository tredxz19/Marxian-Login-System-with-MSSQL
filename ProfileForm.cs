﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marxian_Login_System
{
    public partial class ProfileForm : Form
    {
        public static ProfileForm instanceForm;

        public ProfileForm()
        {
            InitializeComponent();
            instanceForm = this;
        }


        private void ProfileForm_Load(object sender, EventArgs e)
        {

        }
    }
}
