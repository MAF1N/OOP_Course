using System;
using System.IO;
using System.Windows.Forms;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace OOP_Course_Work
{
    public partial class Form1 : Form
    {
        private DataTable table = new DataTable();
        private Storage store;
        private bool CheckDateFile(string s)
        {
            string[] currdate = DateTime.Today.ToString("d").Split('.');
            string[] checkingDate = s.Split('.');
            return (Convert.ToInt32(currdate[2]) < Convert.ToInt32(checkingDate[2]))|| (Convert.ToInt32(currdate[2]) == Convert.ToInt32(checkingDate[2])&&Convert.ToInt32(currdate[1])<Convert.ToInt32(checkingDate[1]))|| (Convert.ToInt32(currdate[2]) == Convert.ToInt32(checkingDate[2]) && Convert.ToInt32(currdate[1])== Convert.ToInt32(checkingDate[1])&&Convert.ToInt32(checkingDate[0])>=Convert.ToInt32(currdate[0]));
        }

        private void DisplayProduct(Product p)
        {
            string[] str1=p.Name.Split('_');
            string s = "";
            for (int i = 0; i < str1.Length; i++)
                if (i < str1.Length - 1)
                    s += str1[i] + " ";
                else
                    s += str1[str1.Length - 1];
            DataRow r = table.NewRow();
            r["Code"] = p.code;
            r["Name"] = s;
            r["Amount"] = p.Amount;
            r["Measure"] = p.Measure;
            r["Cost"] = p.Cost;
            r["DateOfIncome"] = p.DateOfIncome;
            r["End Date"] = p.EndDate;
            table.Rows.Add(r);
        }

        private void Save(Storage s1)
        {
            string line;
            Product[] ps = s1.GetAllProducts();
            using (TextWriter tw = new StreamWriter("DataBase.txt"))
            {
                for (int i = 0; i < ps.Length; i++)
                {
                    line = ps[i].ProductToString();
                    tw.WriteLine(line);
                }
            }
        }

        private Storage LoadStorageBase()
        {
            Storage Storage1 = new Storage();
            using (TextReader reader = new StreamReader("DataBase.txt"))
            {

                string line;
                while ((line = reader.ReadLine()) != null)
                {

                    string[] sparse = line.Split();
                    if (CheckDateFile(sparse[6]))
                    {
                        Product p = new Product();
                        p.code = Convert.ToInt32(sparse[0]);
                        p.Name = sparse[1];

                        p.Amount = Convert.ToInt32(sparse[2]);
                        p.Measure = sparse[3];
                        p.Cost = sparse[4];
                        p.DateOfIncome = sparse[5];
                        p.EndDate = sparse[6];
                        Storage1.AddProduct(p);
                    }
                }
                store = Storage1;
                return Storage1;
            }
        }

        private void ShowProducts(Storage Storage1)
        {
            table.Rows.Clear();
            Product[] ps = Storage1.GetAllProducts();
            if (table.Columns.Count == 0)
            {
                table.Columns.Add("Code");
                table.Columns.Add("Name");
                table.Columns.Add("Amount");
                table.Columns.Add("Measure");
                table.Columns.Add("Cost");
                table.Columns.Add("DateOfIncome");
                table.Columns.Add("End Date");
            }
            for (int i = 0; i < ps.Length; i++)
            {
                DisplayProduct(ps[i]);
            }
            resultBoxDataTable.DataSource = table;
            dataGridView1.DataSource = table;
        }

        public Form1()
        {
            InitializeComponent();
            store = LoadStorageBase();
            DateOfIncome.Format = DateTimePickerFormat.Custom;
            DateOfIncome.CustomFormat = "dd.MM.yyyy";
            EndDate.Format = DateTimePickerFormat.Custom;
            EndDate.CustomFormat = "dd.MM.yyyy";
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Info";
            toolTip1.SetToolTip(SearchByName, "Type here to search by name");
        }

        private void SearchInfoInBase(IEnumerable<Product> stor)
        {
            table.Rows.Clear();
            if (table.Columns.Count == 0)
            {
                table.Columns.Add("Code");
                table.Columns.Add("Name");
                table.Columns.Add("Amount");
                table.Columns.Add("Measure");
                table.Columns.Add("Cost");
                table.Columns.Add("DateOfIncome");
                table.Columns.Add("End Date");
            }
            foreach (var i in stor)
            {
                DisplayProduct(i);
            }
            dataGridView1.DataSource = table;
        }

        private void ClearAllTextBoxes()
        {
            ItemTextBox.Clear();
            AmountTextBox.Clear();
            CostTextBox.Clear();
            MeasureTextBox.Clear();
            EndDate.Text = DateOfIncome.Text;

        }

        private Product GetProductFromTextBoxes()
        {
            int val;
            string[] nameText;
            string s ="";
            Product pr = new Product();
            if (ItemTextBox.Text != null&&ItemTextBox.Text!="")
            {
                nameText = ItemTextBox.Text.Split();
                for (int i = 0; i < nameText.Length; i++)
                    if (i != nameText.Length - 1)
                        s += nameText[i] + "_";
                    else
                        s += nameText[nameText.Length - 1];
                pr.Name = s;
            }
            else
                throw new TextBoxesException("Item TextBox is empty. Try to enter name of product that will be stored in storage");
            if (AmountTextBox.Text != null&&AmountTextBox.Text!="")
                if (Int32.TryParse(AmountTextBox.Text, out val))
                    pr.Amount = val;
                else
                    throw new TextBoxesException("Amount TextBox Error. Try to enter numeric value.");
            else
                throw new TextBoxesException("Amount TextBox is empty. Try to enter numeric value.");

            if (CostTextBox.Text != null&&CostTextBox.Text!="")
            {
                pr.Cost = CostTextBox.Text;
            }
            else
                throw new TextBoxesException("Cost TextBox is emty. Please enter it.");
            if (MeasureTextBox.Text != null&& MeasureTextBox.Text!="")
                pr.Measure = MeasureTextBox.Text;
            else
                throw new TextBoxesException("Measure TextBox is empty. Please enter it.");
            checkDate();   //Checking date formats,  checking EndDate>DateOfIncome
            pr.DateOfIncome = DateOfIncome.Text;
            pr.EndDate = EndDate.Text;
            return pr;
        }

        private void checkDate()
        {
            int val;
            string[] parser = DateOfIncome.Text.Split('.');
            int[] date1 = new int[3];
            for (int i = 0; i < parser.Length; i++)
                if (Int32.TryParse(parser[i], out val))
                    date1[i] = val;
                else
                    throw new TextBoxesException("DateOfIncome is in wrong format. Try to change to dd.mm.yyyy format.");

            //EndDate
            parser = EndDate.Text.Split('.');
            int[] date2 = new int[3];
            for (int i = 0; i < parser.Length; i++)
                if (Int32.TryParse(parser[i], out val))
                    date2[i] = val;
                else
                    throw new TextBoxesException("End Date is in wrong format. Try to change to dd.mm.yyyy format.");
            if (date2[2] < date1[2] || (date1[2] == date2[2] && date1[1] > date2[1]) || (date1[2] == date2[2] && date1[1] == date2[1] && date1[0] > date2[0]))
                throw new TextBoxesException("End Date must be greater than DateOfIncome");
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                Product pr = GetProductFromTextBoxes();
               
                Storage s1 = LoadStorageBase();
                s1.AddProduct(pr);
                Save(s1);
                ShowProducts(s1);
                ClearAllTextBoxes();
            }
            catch (TextBoxesException ex)
            {
                DialogResult result = MessageBox.Show( ex.Message , "TextBoxesFailure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DataException)
            {
                DialogResult result = MessageBox.Show( "Попробуйте изменить файл, или проверьте вручную данные в файле на соответсвие типов", "Данные в файле ошибочны", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }

        private void loadBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowProducts(LoadStorageBase());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SearchInfoInBase(LoadStorageBase().SearchName(SearchByName.Text));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void changeStorageToolStripMenuItem_Click(object sender, EventArgs e)
        { 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            store.Width = 500;
            store.Length = 300;
            Graphics g = pictureBox1.CreateGraphics();
            store.DisplayStorage(g);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(store.Check(e.X,e.Y)!=null)
            {
                toolTip2.ToolTipTitle = store.Check(e.X, e.Y).ToString();
                toolTip2.ToolTipIcon = ToolTipIcon.Info;
                toolTip2.SetToolTip(pictureBox1, "Product");
            }

        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }
    }

    class DataException : Exception
    {

    }

    class TextBoxesException : Exception
    {
        public TextBoxesException(string message) : base(message)
        {
        }
    }
}
