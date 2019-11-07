using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cumpooter_Inventory_Management
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryManagement_CITC2312DataSet.Desktops' table. You can move, or remove it, as needed.
            this.desktopsTableAdapter.Fill(this.inventoryManagement_CITC2312DataSet.Desktops);

        }

        private void desktopsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.desktopsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inventoryManagement_CITC2312DataSet);

        }
    }
}
