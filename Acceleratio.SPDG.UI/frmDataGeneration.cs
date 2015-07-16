﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Acceleratio.SPDG.Generator;

namespace Acceleratio.SPDG.UI
{
    public partial class frmDataGeneration : frmWizardMaster
    {
        public frmDataGeneration()
        {
            InitializeComponent();

            base.lblTitle.Text = "Data generation in progress";

            btnNext.Visible = false;
            btnBack.Visible = false;

            btnClose.Text = "Cancel";
            btnClose.Click += btnClose_Click;

            startDataGeneration();
        }

        private void startDataGeneration()
        {
            DataGenerator generator = new DataGenerator(Common.WorkingDefinition);
            generator.startDataGeneration();

            MessageBox.Show("SharePoint Data Generation Done!");
        }

        void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel data generation?", "SharePoint Data Generation", MessageBoxButtons.YesNo);
            if( result == System.Windows.Forms.DialogResult.Yes )
            {
                RootForm.MoveAt(12, this);
                this.Hide();
            }
        }
    }
}