namespace prj27aThickWindowsFormsNF
{
    partial class Form3
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node1txt");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node2txt");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node0top", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.rbAfternoon = new System.Windows.Forms.RadioButton();
            this.rbMorning = new System.Windows.Forms.RadioButton();
            this.gbShift = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.masterDataSet = new prj27aThickWindowsFormsNF.masterDataSet();
            this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table1TableAdapter = new prj27aThickWindowsFormsNF.masterDataSetTableAdapters.Table1TableAdapter();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.gbShift.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "<< Back3";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 48);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Navigation3";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "str11",
            "str22",
            "str33"});
            this.listBox1.Location = new System.Drawing.Point(27, 122);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 2;
            // 
            // rbAfternoon
            // 
            this.rbAfternoon.AutoSize = true;
            this.rbAfternoon.Location = new System.Drawing.Point(57, 55);
            this.rbAfternoon.Name = "rbAfternoon";
            this.rbAfternoon.Size = new System.Drawing.Size(70, 17);
            this.rbAfternoon.TabIndex = 4;
            this.rbAfternoon.Text = "afternoon";
            this.rbAfternoon.UseVisualStyleBackColor = true;
            // 
            // rbMorning
            // 
            this.rbMorning.AutoSize = true;
            this.rbMorning.Checked = true;
            this.rbMorning.Location = new System.Drawing.Point(57, 32);
            this.rbMorning.Name = "rbMorning";
            this.rbMorning.Size = new System.Drawing.Size(62, 17);
            this.rbMorning.TabIndex = 3;
            this.rbMorning.TabStop = true;
            this.rbMorning.Text = "morning";
            this.rbMorning.UseVisualStyleBackColor = true;
            // 
            // gbShift
            // 
            this.gbShift.Controls.Add(this.rbAfternoon);
            this.gbShift.Controls.Add(this.rbMorning);
            this.gbShift.Location = new System.Drawing.Point(27, 241);
            this.gbShift.Name = "gbShift";
            this.gbShift.Size = new System.Drawing.Size(138, 87);
            this.gbShift.TabIndex = 5;
            this.gbShift.TabStop = false;
            this.gbShift.Text = "Shift";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(377, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(106, 118);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Skills";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(30, 78);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(47, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "SQL";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(30, 55);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(45, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "C++";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(30, 32);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(49, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Java";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(201, 331);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Node1txt";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Node2txt";
            treeNode3.Checked = true;
            treeNode3.Name = "Node0";
            treeNode3.Text = "Node0top";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.treeView1.Size = new System.Drawing.Size(121, 97);
            this.treeView1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(201, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 157);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.table1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(504, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(284, 277);
            this.dataGridView1.TabIndex = 9;
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table1BindingSource
            // 
            this.table1BindingSource.DataMember = "Table1";
            this.table1BindingSource.DataSource = this.masterDataSet;
            // 
            // table1TableAdapter
            // 
            this.table1TableAdapter.ClearBeforeFill = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbShift);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.gbShift.ResumeLayout(false);
            this.gbShift.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton rbAfternoon;
        private System.Windows.Forms.RadioButton rbMorning;
        private System.Windows.Forms.GroupBox gbShift;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource table1BindingSource;
        private masterDataSetTableAdapters.Table1TableAdapter table1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
    }
}