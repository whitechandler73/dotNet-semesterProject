﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterProject
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'businessDatabaseDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.businessDatabaseDataSet.Categories);

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableViewControlComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
