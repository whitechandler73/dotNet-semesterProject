namespace SemesterProject
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewControlGroupBox = new System.Windows.Forms.GroupBox();
            this.comboBoxPromptLabel = new System.Windows.Forms.Label();
            this.tableViewControlComboBox = new System.Windows.Forms.ComboBox();
            this.businessDatabaseDataSet = new SemesterProject.BusinessDatabaseDataSet();
            this.businessDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableAdapter = new SemesterProject.BusinessDatabaseDataSetTableAdapters.CategoriesTableAdapter();
            this.tableAdapterManager = new SemesterProject.BusinessDatabaseDataSetTableAdapters.TableAdapterManager();
            this.categoriesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.viewControlGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.businessDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.viewControlGroupBox);
            this.splitContainer.Size = new System.Drawing.Size(1105, 539);
            this.splitContainer.SplitterDistance = 319;
            this.splitContainer.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1105, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewControlGroupBox
            // 
            this.viewControlGroupBox.AutoSize = true;
            this.viewControlGroupBox.Controls.Add(this.tableViewControlComboBox);
            this.viewControlGroupBox.Controls.Add(this.comboBoxPromptLabel);
            this.viewControlGroupBox.Location = new System.Drawing.Point(13, 28);
            this.viewControlGroupBox.Name = "viewControlGroupBox";
            this.viewControlGroupBox.Size = new System.Drawing.Size(294, 128);
            this.viewControlGroupBox.TabIndex = 0;
            this.viewControlGroupBox.TabStop = false;
            this.viewControlGroupBox.Text = "View Control";
            // 
            // comboBoxPromptLabel
            // 
            this.comboBoxPromptLabel.AutoSize = true;
            this.comboBoxPromptLabel.Location = new System.Drawing.Point(7, 20);
            this.comboBoxPromptLabel.Name = "comboBoxPromptLabel";
            this.comboBoxPromptLabel.Size = new System.Drawing.Size(117, 13);
            this.comboBoxPromptLabel.TabIndex = 0;
            this.comboBoxPromptLabel.Text = "Select a Table for View";
            // 
            // tableViewControlComboBox
            // 
            this.tableViewControlComboBox.FormattingEnabled = true;
            this.tableViewControlComboBox.Items.AddRange(new object[] {
            "Categories",
            "Customers",
            "Employees",
            "Order Details",
            "Orders",
            "Products",
            "Shippers",
            "Suppliers"});
            this.tableViewControlComboBox.Location = new System.Drawing.Point(10, 37);
            this.tableViewControlComboBox.Name = "tableViewControlComboBox";
            this.tableViewControlComboBox.Size = new System.Drawing.Size(197, 21);
            this.tableViewControlComboBox.TabIndex = 1;
            this.tableViewControlComboBox.SelectedIndexChanged += new System.EventHandler(this.tableViewControlComboBox_SelectedIndexChanged);
            // 
            // businessDatabaseDataSet
            // 
            this.businessDatabaseDataSet.DataSetName = "BusinessDatabaseDataSet";
            this.businessDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // businessDatabaseDataSetBindingSource
            // 
            this.businessDatabaseDataSetBindingSource.DataSource = this.businessDatabaseDataSet;
            this.businessDatabaseDataSetBindingSource.Position = 0;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.businessDatabaseDataSet;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = this.categoriesTableAdapter;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.Order_DetailsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.ShippersTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SemesterProject.BusinessDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // categoriesBindingSource1
            // 
            this.categoriesBindingSource1.DataMember = "Categories";
            this.categoriesBindingSource1.DataSource = this.businessDatabaseDataSet;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 539);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitContainer);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "Database Management Suite";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.viewControlGroupBox.ResumeLayout(false);
            this.viewControlGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.businessDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox viewControlGroupBox;
        private System.Windows.Forms.ComboBox tableViewControlComboBox;
        private System.Windows.Forms.Label comboBoxPromptLabel;
        private System.Windows.Forms.BindingSource businessDatabaseDataSetBindingSource;
        private BusinessDatabaseDataSet businessDatabaseDataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private BusinessDatabaseDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private BusinessDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource categoriesBindingSource1;
    }
}

