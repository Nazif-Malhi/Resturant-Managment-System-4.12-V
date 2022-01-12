using Spinzer_Managment_System__4._12_V_.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spinzer_Managment_System__4._12_V_.View.Small_Controlls
{
    public partial class AddingDiscountsOnItems : Form
    {
        DealsViewModel dealsViewModel = new DealsViewModel();
        CategoriesViewModel categoriesViewModel = new CategoriesViewModel();
        public AddingDiscountsOnItems()
        {
            InitializeComponent();
            addingData();
            loadData();

        }
        private void addingData() {
            discountoOnEachItem_comboBox.SelectedIndex = 1;
            var v = categoriesViewModel.fillingData();
            var c = dealsViewModel.fillingData();
            foreach (var cat in categoriesViewModel.catModel.dataCat)
            {
                listBox1.Items.Add(cat.CategoriesName);
            }
            foreach (var deals in dealsViewModel.dataDeals.dataDealsModel)
            {
                listBox1.Items.Add(deals.Name);
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            listBox2.Items.Add(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void remove_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex == -1) return;
            listBox1.Items.Add(listBox2.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem);
            
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void Done_Click(object sender, EventArgs e)
        {
            
            string pathAndFileName = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\discount";
            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(pathAndFileName))
                {
                    File.Delete(pathAndFileName);
                }
                
                

                // Create a new file     
                using (FileStream fs = File.Create(pathAndFileName))
                {
                    Byte[] ui = new UTF8Encoding(true).GetBytes(discountoOnEachItem_comboBox.SelectedItem.ToString()+"\n");
                    fs.Write(ui, 0, ui.Length);
                    // Add some text to file    
                    foreach (var item in listBox2.Items)
                    {
                        Byte[] title = new UTF8Encoding(true).GetBytes(item.ToString()+"\n");
                        fs.Write(title, 0, title.Length);
                    }
                }

                // Open the stream and read it back.    
                using (StreamReader sr = File.OpenText(pathAndFileName))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        //Console.WriteLine(s);
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            this.Close();
        }
        private void loadData() 
        {
            string pathAndFileName = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\discount";
            try
            {
                if (File.Exists(pathAndFileName))
                {
                    discountoOnEachItem_comboBox.SelectedItem = File.ReadLines(pathAndFileName).First();
                    using (StreamReader sr = File.OpenText(pathAndFileName))
                    {
                        string s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            listBox2.Items.Add(s);
                            listBox1.Items.Remove(s);
                        }
                    }
                    listBox2.Items.RemoveAt(0);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
