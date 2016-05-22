using System;

namespace OOP_Course_Work
{
    partial class Form1
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
            this.ItemTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MeasureTextBox = new System.Windows.Forms.TextBox();
            this.resultBoxDataTable = new System.Windows.Forms.DataGridView();
            this.DateOfIncome = new System.Windows.Forms.DateTimePicker();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printBaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeStorageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.SearchByName = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.storageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.resultBoxDataTable)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemTextBox
            // 
            this.ItemTextBox.Location = new System.Drawing.Point(58, 13);
            this.ItemTextBox.Name = "ItemTextBox";
            this.ItemTextBox.Size = new System.Drawing.Size(152, 20);
            this.ItemTextBox.TabIndex = 4;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(244, 122);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Amount";
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(58, 66);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(152, 20);
            this.CostTextBox.TabIndex = 7;
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(58, 39);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(152, 20);
            this.AmountTextBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Measure";
            // 
            // MeasureTextBox
            // 
            this.MeasureTextBox.Location = new System.Drawing.Point(58, 95);
            this.MeasureTextBox.Name = "MeasureTextBox";
            this.MeasureTextBox.Size = new System.Drawing.Size(152, 20);
            this.MeasureTextBox.TabIndex = 10;
            // 
            // resultBoxDataTable
            // 
            this.resultBoxDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultBoxDataTable.Location = new System.Drawing.Point(12, 213);
            this.resultBoxDataTable.Name = "resultBoxDataTable";
            this.resultBoxDataTable.ReadOnly = true;
            this.resultBoxDataTable.Size = new System.Drawing.Size(595, 203);
            this.resultBoxDataTable.TabIndex = 2;
            // 
            // DateOfIncome
            // 
            this.DateOfIncome.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.DateOfIncome.Location = new System.Drawing.Point(367, 10);
            this.DateOfIncome.Name = "DateOfIncome";
            this.DateOfIncome.Size = new System.Drawing.Size(200, 20);
            this.DateOfIncome.TabIndex = 12;
            // 
            // EndDate
            // 
            this.EndDate.Location = new System.Drawing.Point(367, 36);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(200, 20);
            this.EndDate.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Date of Income";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "EndDate";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.changeStorageToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(625, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadBaseToolStripMenuItem,
            this.fileToolStripMenuItem,
            this.changeProductToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // loadBaseToolStripMenuItem
            // 
            this.loadBaseToolStripMenuItem.Name = "loadBaseToolStripMenuItem";
            this.loadBaseToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.loadBaseToolStripMenuItem.Text = "Load Base";
            this.loadBaseToolStripMenuItem.Click += new System.EventHandler(this.loadBaseToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printBaToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // printBaToolStripMenuItem
            // 
            this.printBaToolStripMenuItem.Name = "printBaToolStripMenuItem";
            this.printBaToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.printBaToolStripMenuItem.Text = "Print Waybill";
            // 
            // changeProductToolStripMenuItem
            // 
            this.changeProductToolStripMenuItem.Name = "changeProductToolStripMenuItem";
            this.changeProductToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.changeProductToolStripMenuItem.Text = "Change Product";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // changeStorageToolStripMenuItem
            // 
            this.changeStorageToolStripMenuItem.Name = "changeStorageToolStripMenuItem";
            this.changeStorageToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.changeStorageToolStripMenuItem.Text = "Change Storage";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(599, 174);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightCyan;
            this.tabPage1.Controls.Add(this.CostTextBox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.AddButton);
            this.tabPage1.Controls.Add(this.DateOfIncome);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.MeasureTextBox);
            this.tabPage1.Controls.Add(this.ItemTextBox);
            this.tabPage1.Controls.Add(this.EndDate);
            this.tabPage1.Controls.Add(this.AmountTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(591, 148);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add product";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightCyan;
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.SearchByName);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(591, 148);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search Product";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Search By Name";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // SearchByName
            // 
            this.SearchByName.Location = new System.Drawing.Point(97, 6);
            this.SearchByName.Name = "SearchByName";
            this.SearchByName.Size = new System.Drawing.Size(179, 20);
            this.SearchByName.TabIndex = 4;
            this.SearchByName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // storageBindingSource
            // 
            this.storageBindingSource.DataSource = typeof(OOP_Course_Work.Storage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(625, 428);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.resultBoxDataTable);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Складская база данных";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultBoxDataTable)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.TextBox ItemTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MeasureTextBox;
        private System.Windows.Forms.DataGridView resultBoxDataTable;
        private System.Windows.Forms.DateTimePicker DateOfIncome;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeStorageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printBaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeProductToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingSource storageBindingSource;
        private System.Windows.Forms.TextBox SearchByName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

