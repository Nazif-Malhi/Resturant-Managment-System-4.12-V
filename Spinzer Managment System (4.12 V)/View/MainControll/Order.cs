using Spinzer_Managment_System__4._12_V_.ExternalResoursces.QRCode;
using Spinzer_Managment_System__4._12_V_.Model;
using Spinzer_Managment_System__4._12_V_.Model.Queries;
using Spinzer_Managment_System__4._12_V_.View.Small_Controlls;
using Spinzer_Managment_System__4._12_V_.ViewModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Spinzer_Managment_System__4._12_V_.View.MainControll
{
    public partial class Order : UserControl
    {
        

        #region Initilizing the variables with data Type
        public Button dynamicButton;
        public bool mainFormToOrderFormLock = false, gettinglastOrderLock = false, dealsLock =false,itemLock=false, returnFromItemToCategoryLock = false, specialPriceTrigger = false;

        private DateTime dateTime;
        private Random rnd = new Random();
        private string lastOrderInvoice = "";

        private CategoriesViewModel categoriesViewModel;
        private ItemViewModel itemViewModel;
        private DealsViewModel dealsViewModel;
        private DealsItemViewModel dealsItemViewModel;
        private InvoiceViewModel invoiceViewModel;
        private CustomerViewModel customerViewModel;

        private int notGoFurtherItemsToSelectAnyThingCounter = 0, notGoFurtherItemsToSelectAnyThingMouseCounter=0, totalPrice = 0, counterForInvoice = 0;

        private ArrayList CategoryList, itemList, chechingDuplicateList, dealList;
        private string[] gettingReadyForOrderToEnterInDataGridViewStack = new string[5];
        private List<string []> testing;


        private int CategoryID = 0, invoice = 0;
        #endregion


        #region Create Params
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }
        #endregion


        #region Constructor
        public Order()
        {
            InitializeComponent();
            categoriesViewModel = new CategoriesViewModel();
            itemViewModel = new ItemViewModel();
            dealsViewModel = new DealsViewModel();
            dealsItemViewModel = new DealsItemViewModel();

            chechingDuplicateList = new ArrayList();
            CategoryList = new ArrayList();
            itemList = new ArrayList();
            dealList = new ArrayList();
            testing = new List<string []>();

           
            InitializeOnLoading();


            //gettingCategoriesInFlowLayoutPanelButton();
            gettingCategoriesAndDealsInFlowLayoutPanelButton();
        }
        #endregion


        #region InitializeOnLoading
        private void InitializeOnLoading()
        {
            orderType_ComboBox.SelectedIndex = 0;
            custName_TextBox.Enabled = false;
            custAddress_TextBox.Enabled = false;
            custPhone_TextBox.Enabled = false;
            custMail_TextBox.Enabled = false;
            orderType_ComboBox.Enabled = false;
            mainFormLoad_DataGrid(dataGridView1);
            qty_TextBox.Text = "1";
            dateTime = DateTime.Now;
            gettingInvoiceNumber();
            discountoOnEachItem_comboBox.SelectedIndex = 0;
            fullDiscount_ComboBox.SelectedIndex = 0;
            Datetimer.Start();
            //discountoOnEachItem_comboBox.SelectedIndex = 3;
        }
        #endregion

        private void gettingCategoriesAndDealsInFlowLayoutPanelButton()
        {
            ButtonsflowLayoutPanel.Controls.Clear();
            string[] array = { "Deals", "Items" };
            for (int i = 0; i < 2; i++)
            {
                styleOfButton(array[i]);
            }
            itemLock = false;
            dealsLock = false;
        }

        #region gettingCategoriesInFlowLayoutPanelButton
        private void gettingCategoriesInFlowLayoutPanelButton()
        {
            ButtonsflowLayoutPanel.Controls.Clear();
            categoriesViewModel = new CategoriesViewModel();
            var initialize = categoriesViewModel.fillingData();
            foreach (var item in categoriesViewModel.catModel.dataCat)
            {
                styleOfButton(item.CategoriesName);
            }
            dynamicButton.Focus();
        }
        private void gettingDealsInFlowLayoutPanelButton()
        {
            ButtonsflowLayoutPanel.Controls.Clear();
            dealsViewModel = new DealsViewModel();
            var initialize = dealsViewModel.fillingData();
            foreach (var item in dealsViewModel.dataDeals.dataDealsModel)
            {
                styleOfButton(item.Name);
            }
            dynamicButton.Focus();
        }
        #endregion


        #region Dynamic Key Down


        private void DynamicButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (gettinglastOrderLock)
            {
                MessageBox.Show("Please 1st Clear or delete the last get Order");
            }
            else
            {
                if (dealsLock == false && itemLock == false)
                {
                    if (e.KeyCode.ToString() == "I")
                    {
                        gettingCategoriesInFlowLayoutPanelButton();
                        itemLock = true;
                    }
                    else if (e.KeyCode.ToString() == "D")
                    {
                        gettingDealsInFlowLayoutPanelButton();
                        dealsLock = true;
                    }
                    else if (e.Modifiers == Keys.Control)
                    {

                        custName_TextBox.Enabled = true;
                        custAddress_TextBox.Enabled = true;
                        custPhone_TextBox.Enabled = true;
                        custMail_TextBox.Enabled = true;
                        orderType_ComboBox.Enabled = true;
                        custName_TextBox.Focus();
                        label2.Visible = true;
                        label2.Text = "Please Enter Unique Phone Number \n or Unique Name which is not present\n in database";
                    }
                }
                 
                else if (dealsLock)
                {
                    if (e.KeyCode == Keys.Back)
                    {

                        gettingCategoriesAndDealsInFlowLayoutPanelButton();
                        itemLock = false;
                        dealsLock = false;
                        returnFromItemToCategoryLock = false;
                        dynamicButton.Focus();
                        notGoFurtherItemsToSelectAnyThingCounter = 0;

                        //gettingCategoriesAndDealsInFlowLayoutPanelButton();
                        //dealsLock = false;
                        //dynamicButton.Focus();
                    }
                   
                    else
                    {
                        string result = e.KeyCode.ToString();
                        if ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) || (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9))
                        {
                            result = e.KeyCode.ToString().Substring(e.KeyCode.ToString().Length - 1);
                        }
                        foreach (var item in dealsViewModel.dataDeals.dataDealsModel)
                        {
                            if (result == item.Name.Substring(0, 1))
                            {
                                price_TextBox.Text = item.Price.ToString();
                                qty_TextBox.Focus();
                                gettingReadyForOrderToEnterInDataGridViewStack[0] = item.Name;
                                gettingReadyForOrderToEnterInDataGridViewStack[2] = price_TextBox.Text;
                                gettingReadyForOrderToEnterInDataGridViewStack[3] = "0";
                                gettingReadyForOrderToEnterInDataGridViewStack[4] = item.ID.ToString();
                                subHeading_Label.Text = item.Name;
                            }
                        }
                    }
                }
                else if (itemLock)
                {
                    if (e.KeyCode == Keys.Back)
                    {

                        gettingCategoriesAndDealsInFlowLayoutPanelButton();
                        itemLock = false;
                        dealsLock = false;
                        returnFromItemToCategoryLock = false;
                        dynamicButton.Focus();
                        notGoFurtherItemsToSelectAnyThingCounter = 0;
                        //if (returnFromItemToCategoryLock == false && notGoFurtherItemsToSelectAnyThingCounter>0)
                        //{
                        //    gettingCategoriesInFlowLayoutPanelButton();
                        //    notGoFurtherItemsToSelectAnyThingCounter = 0;
                        //    notGoFurtherItemsToSelectAnyThingMouseCounter = 0;
                        //    price_TextBox.Text = "";
                        //    dynamicButton.Focus();
                        //    heading_Label.Text = "";
                        //    CategoryID = -1;
                        //    returnFromItemToCategoryLock = true;
                        //}
                        //else {
                        //    gettingCategoriesAndDealsInFlowLayoutPanelButton();
                        //    itemLock = false;
                        //    returnFromItemToCategoryLock = false;
                        //    dynamicButton.Focus();
                        //}

                    }
                   

                    else if (notGoFurtherItemsToSelectAnyThingCounter == 1)   // input [A-Z] Alphabets...
                    {
                        itemViewModel = new ItemViewModel();
                        int length = itemViewModel.fillingData();
                        string result = e.KeyCode.ToString();
                        if ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) || (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9))
                        {
                            result = e.KeyCode.ToString().Substring(e.KeyCode.ToString().Length - 1);
                        }
                        foreach (var item in itemViewModel.itemModel.dataItem)
                        {
                            if (result == item.Item_Name.Substring(0, 1) && CategoryID == item.Cat_ID)
                            {
                                price_TextBox.Text = item.Price.ToString();
                                qty_TextBox.Focus();
                                gettingReadyForOrderToEnterInDataGridViewStack[0] = item.Item_Name;
                                gettingReadyForOrderToEnterInDataGridViewStack[2] = price_TextBox.Text;
                                gettingReadyForOrderToEnterInDataGridViewStack[3] = item.Cat_ID.ToString();
                                gettingReadyForOrderToEnterInDataGridViewStack[4] = item.Id.ToString();
                                subHeading_Label.Text = item.Item_Name + "" + heading_Label.Text;
                            }
                        }
                    }
                    else
                    {
                        if (!mainFormToOrderFormLock) return;
                        else
                        {
                            itemViewModel = new ItemViewModel();
                            var tupple = itemViewModel.fillingData(e);
                            CategoryID = tupple.Item4;
                            if (tupple.Item1 == 0) return;
                            ButtonsflowLayoutPanel.Controls.Clear();
                            heading_Label.Text = tupple.Item2;
                            for (int i = 0; i < tupple.Item1; i++)
                            {
                                styleOfButton(itemViewModel.itemModel.dataItem[i].Item_Name + "\n" + tupple.Item2);
                            }
                            dynamicButton.Focus();
                            notGoFurtherItemsToSelectAnyThingCounter++;
                        }
                    }
                }
            }
        }
        #endregion

        #region Dynamic Mouse Down Click
        private void backButton_Click(object sender, EventArgs e)
        {
            if (gettinglastOrderLock)
            {
                MessageBox.Show("Please 1st Clear or delete the last get Order");
            }
            else
            {
                gettingCategoriesAndDealsInFlowLayoutPanelButton();
                notGoFurtherItemsToSelectAnyThingCounter = 0;
                itemLock = false;
                dealsLock = false;
                returnFromItemToCategoryLock = false;
                dynamicButton.Focus();
            }
            //if (dealsLock)
            //{
            //    gettingCategoriesAndDealsInFlowLayoutPanelButton();
            //    dealsLock = false;
            //    dynamicButton.Focus();
            //}
            //else if (itemLock) {
            //    if (returnFromItemToCategoryLock == false && notGoFurtherItemsToSelectAnyThingCounter > 0)
            //    {
            //        gettingCategoriesInFlowLayoutPanelButton();
            //        notGoFurtherItemsToSelectAnyThingCounter = 0;
            //        notGoFurtherItemsToSelectAnyThingMouseCounter = 0;
            //        price_TextBox.Text = "";
            //        dynamicButton.Focus();
            //        heading_Label.Text = "";
            //        CategoryID = -1;
            //        returnFromItemToCategoryLock = true;
            //    }
            //    else
            //    {

            //    }
        //}
           
        }
        private void done_Button_Click(object sender, EventArgs e)
        {
            if (gettinglastOrderLock)
            {
                MessageBox.Show("Please 1st Clear or delete the last get Order");
            }
            else
            {
                if (gettingReadyForOrderToEnterInDataGridViewStack[0] == null)
                {
                    MessageBox.Show("Please select items from category to proceed");
                }
                else
                {
                    gettingReadyForOrderToEnterInDataGridViewStack[1] = qty_TextBox.Text;

                    if (checkingForDuplicate())
                    {
                        MessageBox.Show("Already in Qeue");
                        Array.Clear(gettingReadyForOrderToEnterInDataGridViewStack, 0, gettingReadyForOrderToEnterInDataGridViewStack.Length);
                        dynamicButton.Focus();
                    }
                    else
                    {
                        string concat = "";
                        if (dealsLock)
                        {
                            concat = gettingReadyForOrderToEnterInDataGridViewStack[0];
                        }
                        else if (itemLock)
                        {
                            concat = gettingReadyForOrderToEnterInDataGridViewStack[0] + "-" + heading_Label.Text;
                        }
                        gettingReadyForOrderToEnterInDataGridViewStack[0] = concat;
                        if (gettingReadyForOrderToEnterInDataGridViewStack[2] != price_TextBox.Text) {
                            gettingReadyForOrderToEnterInDataGridViewStack[2] = price_TextBox.Text;
                            specialPriceTrigger = true;
                        }
                        chechingDuplicateList.Add(gettingReadyForOrderToEnterInDataGridViewStack[0].ToString());


                        getingDataInDataGrid();
                        Array.Clear(gettingReadyForOrderToEnterInDataGridViewStack, 0, gettingReadyForOrderToEnterInDataGridViewStack.Length);  //Empty ArrayList
                        calculationTotal();
                    }
                    //gettingCategoriesInFlowLayoutPanelButton();
                    gettingCategoriesAndDealsInFlowLayoutPanelButton();
                    notGoFurtherItemsToSelectAnyThingCounter = 0;
                    notGoFurtherItemsToSelectAnyThingMouseCounter = 0;
                    price_TextBox.Text = "";
                    dynamicButton.Focus();
                    heading_Label.Text = "";
                    CategoryID = -1;
                    itemLock = false;
                    dealsLock = false;
                }
            }
        }
        private void DynamicButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (gettinglastOrderLock)
            {
                MessageBox.Show("Please 1st Clear or delete the last get Order");
            }
            else
            {
                Button button = sender as Button;

                if (dealsLock == false && itemLock == false)
                {
                    if (button.Name == "Items")
                    {
                        gettingCategoriesInFlowLayoutPanelButton();
                        itemLock = true;
                    }
                    else if (button.Name == "Deals")
                    {
                        gettingDealsInFlowLayoutPanelButton();
                        dealsLock = true;
                    }
                }
                else if (dealsLock)
                {
                    string result = button.Name;
                    foreach (var item in dealsViewModel.dataDeals.dataDealsModel)
                    {
                        if (result == item.Name)
                        {
                            price_TextBox.Text = item.Price.ToString();
                            qty_TextBox.Focus();
                            gettingReadyForOrderToEnterInDataGridViewStack[0] = item.Name;
                            gettingReadyForOrderToEnterInDataGridViewStack[2] = price_TextBox.Text;
                            gettingReadyForOrderToEnterInDataGridViewStack[3] = "0";
                            gettingReadyForOrderToEnterInDataGridViewStack[4] = item.ID.ToString();
                            subHeading_Label.Text = item.Name;
                        }
                    }
                }
                else if (itemLock)
                {
                    itemViewModel = new ItemViewModel();

                    if (notGoFurtherItemsToSelectAnyThingCounter == 0)
                    {
                        var tupple = itemViewModel.fillingData(button.Name);
                        CategoryID = tupple.Item4;
                        if (tupple.Item1 == 0) return;
                        ButtonsflowLayoutPanel.Controls.Clear();
                        heading_Label.Text = tupple.Item2;
                        for (int i = 0; i < tupple.Item1; i++)
                        {
                            styleOfButton(itemViewModel.itemModel.dataItem[i].Item_Name + "\n" + tupple.Item2);
                        }
                        dynamicButton.Focus();
                        notGoFurtherItemsToSelectAnyThingCounter++;
                    }
                    else if (notGoFurtherItemsToSelectAnyThingCounter == 1)
                    {
                        itemViewModel = new ItemViewModel();
                        int length = itemViewModel.fillingData();
                        foreach (var item in itemViewModel.itemModel.dataItem)
                        {
                            if (button.Name.StartsWith(item.Item_Name.Substring(0, 1)) && CategoryID == item.Cat_ID)
                            {
                                price_TextBox.Text = item.Price.ToString();
                                qty_TextBox.Focus();
                                gettingReadyForOrderToEnterInDataGridViewStack[0] = item.Item_Name;
                                gettingReadyForOrderToEnterInDataGridViewStack[2] = price_TextBox.Text;
                                gettingReadyForOrderToEnterInDataGridViewStack[3] = item.Cat_ID.ToString();
                                gettingReadyForOrderToEnterInDataGridViewStack[4] = item.Id.ToString();
                                subHeading_Label.Text = item.Item_Name + "" + heading_Label.Text;
                            }
                        }
                    }
                }
            }

        }
        #endregion

        #region TextBox 


        #region KeyPress
        private void qty_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            textTrueAlphaValues(e);

        }

        private void price_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            textTrueAlphaValues(e);
        }

        private void custName_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            textTrueNumericValues(e);
        }
        private void custPhone_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            textTrueAlphaValues(e);
        }

        private void custMail_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            textTrueNumericValues(e);
        }
        #endregion

        #region Key Down
        private void qty_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back && qty_TextBox.Text == "")
            {
                subHeading_Label.Text = "";
                backPressedDynamicFocus(e);
                qty_TextBox.Text = "1";

            }
            else if (e.KeyCode == Keys.Enter)
            {
               
                if (gettingReadyForOrderToEnterInDataGridViewStack[0] == null)
                {
                    MessageBox.Show("Please select items from category to proceed"); 
                }
              
                else
                {
                    gettingReadyForOrderToEnterInDataGridViewStack[1] = qty_TextBox.Text;

                    if (checkingForDuplicate())
                    {
                        MessageBox.Show("Already in Qeue");
                        Array.Clear(gettingReadyForOrderToEnterInDataGridViewStack, 0, gettingReadyForOrderToEnterInDataGridViewStack.Length);
                        dynamicButton.Focus();
                    }
                    else
                    {
                        string concat = "";
                        if (dealsLock)
                        {
                            concat = gettingReadyForOrderToEnterInDataGridViewStack[0];
                        }
                        else if(itemLock)
                        {
                            concat = gettingReadyForOrderToEnterInDataGridViewStack[0] + "-" + heading_Label.Text;
                        }
                        gettingReadyForOrderToEnterInDataGridViewStack[0] = concat;
                        if (gettingReadyForOrderToEnterInDataGridViewStack[2] != price_TextBox.Text)
                        {
                            gettingReadyForOrderToEnterInDataGridViewStack[2] = price_TextBox.Text;
                            specialPriceTrigger = true;
                        }
                        chechingDuplicateList.Add(gettingReadyForOrderToEnterInDataGridViewStack[0].ToString());


                        getingDataInDataGrid();
                        Array.Clear(gettingReadyForOrderToEnterInDataGridViewStack, 0, gettingReadyForOrderToEnterInDataGridViewStack.Length);  //Empty ArrayList
                        calculationTotal();
                    }
                    gettingCategoriesAndDealsInFlowLayoutPanelButton();
                    notGoFurtherItemsToSelectAnyThingCounter = 0;
                    notGoFurtherItemsToSelectAnyThingMouseCounter = 0;
                    price_TextBox.Text = "";
                    dynamicButton.Focus();
                    heading_Label.Text = "";
                    CategoryID = -1;
                    itemLock = false;
                    dealsLock = false;
                }
            }

        }
        private void custName_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                custAddress_TextBox.Focus();
            }
            disableTextBoxBackEnableOrders(e);
        }
        private void custAddress_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                custPhone_TextBox.Focus();
            }
            disableTextBoxBackEnableOrders(e);
        }
        private void custPhone_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                custMail_TextBox.Focus();
            }
            disableTextBoxBackEnableOrders(e);
        }
        private void custMail_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                custName_TextBox.Focus();
            }
            disableTextBoxBackEnableOrders(e);
        }
        private void orderType_ComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            disableTextBoxBackEnableOrders(e);
        }

        #endregion

        #region Methods for TextBox
        private static Boolean isAlphaNumeric(string strToCheck)
        {
            Regex rg = new Regex(@"^[a-zA-Z]*$"); return rg.IsMatch(strToCheck);
        }

        private void textTrueAlphaValues(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }
        private void textTrueNumericValues(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) { e.Handled = true; }
        }

        private void backPressedDynamicFocus(KeyEventArgs e)
        {
               dynamicButton.Focus();
        }
        private void disableTextBoxBackEnableOrders(KeyEventArgs e) {
            if (e.Modifiers == Keys.Control)
            {
                custName_TextBox.Enabled = false;
                custAddress_TextBox.Enabled = false;
                custPhone_TextBox.Enabled = false;
                custMail_TextBox.Enabled = false;
                orderType_ComboBox.Enabled = false;
                label2.Visible = false;
                dynamicButton.Focus();
            }
        }
        
        #endregion

        #endregion
        /// <summary>
        /// Date Time , gettingDataInDataGrid,CalculationTotal,CheckingForDuplicates
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region Others
        private void Datetimer_Tick(object sender, EventArgs e)
        {
            dateTime = DateTime.Now;
            date_Label.Text = dateTime.ToString();

        }
        private void getingDataInDataGrid() {

            testing.Add(new[] { gettingReadyForOrderToEnterInDataGridViewStack[0], gettingReadyForOrderToEnterInDataGridViewStack[1], gettingReadyForOrderToEnterInDataGridViewStack[2], gettingReadyForOrderToEnterInDataGridViewStack[3], gettingReadyForOrderToEnterInDataGridViewStack[4] });
            string triggerPrice = gettingReadyForOrderToEnterInDataGridViewStack[2];
            string discount = discountoOnEachItem_comboBox.SelectedItem.ToString();
            discount = (discount.Remove(discount.Length - 1));
            int discountValue = Convert.ToInt32(gettingReadyForOrderToEnterInDataGridViewStack[2]);
            int afterDiscount = discountValue - (discountValue * Convert.ToInt32(discount) / 100);
            if (specialPriceTrigger == true)
            {
                gettingReadyForOrderToEnterInDataGridViewStack[2] = triggerPrice;
            }
            else
            {
                gettingReadyForOrderToEnterInDataGridViewStack[2] = afterDiscount.ToString();
            }
            dataGridView1.Rows.Add(gettingReadyForOrderToEnterInDataGridViewStack);
            
            qty_TextBox.Text = "1";
            subHeading_Label.Text = "";

            dynamicButton.Focus();
        }
        private void calculationTotal()
        {
            string pathAndFileName = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\discount";
            ArrayList discountList = new ArrayList();
            string[] seprateList = new string[2];
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.Clear();
                string[] vs = new string[5];
                try
                {
                    // Check if file already exists. If yes, delete it.     
                    if (File.Exists(pathAndFileName))
                    {
                        discountoOnEachItem_comboBox.SelectedItem = File.ReadLines(pathAndFileName).First();
                        using (StreamReader sr = File.OpenText(pathAndFileName))
                        {
                            string s = "";
                            while ((s = sr.ReadLine()) != null)
                            {
                                discountList.Add(s);
                            }
                        }
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

                foreach (string[] item in testing)
                {
                    for (int i = 0; i < item.Length; i++)
                    {
                        vs[i] = item[i];
                    }
                    seprateList = vs[0].Split('-');
                    if (seprateList.Length == 1)
                    {
                        if (discountList.Contains(seprateList[0]))
                        {
                            string discount = discountoOnEachItem_comboBox.SelectedItem.ToString();
                            discount = (discount.Remove(discount.Length - 1));
                            int discountValue = Convert.ToInt32(vs[2]);
                            int afterDiscount = discountValue - (discountValue * Convert.ToInt32(discount) / 100);
                            vs[2] = afterDiscount.ToString();
                            dataGridView1.Rows.Add(vs);
                        }
                        else {
                            dataGridView1.Rows.Add(vs);
                        }
                    }
                    else {
                        if (discountList.Contains(seprateList[1])) {
                            string discount = discountoOnEachItem_comboBox.SelectedItem.ToString();
                            discount = (discount.Remove(discount.Length - 1));
                            int discountValue = Convert.ToInt32(vs[2]);
                            int afterDiscount = discountValue - (discountValue * Convert.ToInt32(discount) / 100);
                            vs[2] = afterDiscount.ToString();
                            dataGridView1.Rows.Add(vs);
                        }
                        else {
                            dataGridView1.Rows.Add(vs);
                        } 
                    }
                }
                totalPrice = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    totalPrice += Convert.ToInt32(row.Cells[1].Value) * Convert.ToInt32(row.Cells[2].Value);
                }
              
                total_label.Text = totalPrice.ToString();
                dynamicButton.Focus();
            }

           



            ////if (dataGridView1.Rows.Count > 0)
            ////{
            ////    dataGridView1.Rows.Clear();
            ////    string[] vs = new string[5];
            ////    foreach (string[] item in testing)
            ////    {
            ////        for (int i = 0; i < item.Length; i++)
            ////        {
            ////            vs[i] = item[i];
            ////        }
            ////        dealsViewModel = new DealsViewModel();
            ////        int lenght = dealsViewModel.fillingData();
            ////        bool surface = false;
            ////        foreach (var deals in dealsViewModel.dataDeals.dataDealsModel)
            ////        {
            ////            if (vs[0].Equals(deals.Name))
            ////            {
            ////                surface = true;
            ////            }
            ////        }
            ////        if (!surface)
            ////        {
            ////            string discount = discountoOnEachItem_comboBox.SelectedItem.ToString();
            ////            discount = (discount.Remove(discount.Length - 1));
            ////            int discountValue = Convert.ToInt32(vs[2]);
            ////            int afterDiscount = discountValue - (discountValue * Convert.ToInt32(discount) / 100);
            ////            vs[2] = afterDiscount.ToString();
            ////            dataGridView1.Rows.Add(vs);
            ////        }
            ////        else
            ////        {
            ////            dataGridView1.Rows.Add(vs);
            ////        }
            ////    }
            ////    //calculationTotal();
            ////}

            //totalPrice = 0;
            //foreach (DataGridViewRow row in dataGridView1.Rows)
            //{
            //    totalPrice += Convert.ToInt32(row.Cells[1].Value) * Convert.ToInt32(row.Cells[2].Value);
            //}
            //if (deleviryCharges_TextBox.Text != "")
            //{
            //    totalPrice += Convert.ToInt32(deleviryCharges_TextBox.Text);
            //}
            //total_label.Text = totalPrice.ToString();
            //dynamicButton.Focus();
        }
        private bool checkingForDuplicate()
        {
            bool checkMark = false;
            foreach (var item in chechingDuplicateList)
            {
                if (dealsLock)
                {
                    if (item.ToString() == gettingReadyForOrderToEnterInDataGridViewStack[0] ) checkMark = true;
                }
                else
                {
                    if (item.ToString() == gettingReadyForOrderToEnterInDataGridViewStack[0] + "-" + heading_Label.Text) checkMark = true;
                }
            }
            return checkMark;
        }

        #endregion

        #region Data Grid View Mouse Enter, Leave, Click Compare Images
       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateQuantitiyFromOrder updateQuantitiyFromOrder;
            int qty = 0;
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {
                    if (dataGridView1.Columns[e.ColumnIndex].Name == "removeDGV")
                    {
                        DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                        dataGridView1.Rows.Remove(row);
                        chechingDuplicateList.Remove(row.Cells[0].Value.ToString());
                        testing.RemoveAt(e.RowIndex);
                        
                        calculationTotal();
                        
                    }
                    else if (dataGridView1.Columns[e.ColumnIndex].Name == "updateDGV")
                    {
                        DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                        using (updateQuantitiyFromOrder = new UpdateQuantitiyFromOrder(Convert.ToInt32(row.Cells[1].Value.ToString())))
                        {
                            updateQuantitiyFromOrder.ShowDialog();

                            qty = updateQuantitiyFromOrder.getValue();
                            
                        }

                        row.Cells[1].Value = qty;
                        qty = 0;
                        calculationTotal();
                    }
                }
            }
           
        }
        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "removeDGV")
                {
                    if (CompareImages((Bitmap)dataGridView1.Rows[e.RowIndex].Cells[6].Value, Properties.Resources.btnDataGrid_Remove))
                    {
                        dataGridView1.Rows[e.RowIndex].Cells[6].Value = Properties.Resources.btnDataGrid_RemoveHover;
                    }
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "updateDGV")
                {
                    if (CompareImages((Bitmap)dataGridView1.Rows[e.RowIndex].Cells[5].Value, Properties.Resources.btnDataGrid_Update))
                    {
                        dataGridView1.Rows[e.RowIndex].Cells[5].Value = Properties.Resources.btnDataGrid_UpdateHover;
                    }
                }
            }
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "removeDGV")
                {
                    if (CompareImages((Bitmap)dataGridView1.Rows[e.RowIndex].Cells[6].Value, Properties.Resources.btnDataGrid_RemoveHover))
                    {
                        dataGridView1.Rows[e.RowIndex].Cells[6].Value = Properties.Resources.btnDataGrid_Remove;
                    }
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "updateDGV")
                {
                    if (CompareImages((Bitmap)dataGridView1.Rows[e.RowIndex].Cells[5].Value, Properties.Resources.btnDataGrid_UpdateHover))
                    {
                        dataGridView1.Rows[e.RowIndex].Cells[5].Value = Properties.Resources.btnDataGrid_Update;
                    }
                }
            }
        }
        private static bool CompareImages(Bitmap image1, Bitmap image2)
        {
            if (image1.Width == image2.Width && image1.Height == image2.Height)
            {
                for (int i = 0; i < image1.Width; i++)
                {
                    for (int j = 0; j < image1.Height; j++)
                    {
                        if (image1.GetPixel(i, j) != image2.GetPixel(i, j))
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        private void invoice_PictureBox_Click(object sender, EventArgs e)
        {
            
            if (gettinglastOrderLock)
            {
                MessageBox.Show("Please 1st Clear or delete the last get Order");
                return;
            }
            else
            {
                if (dataGridView1.Rows.Count == 0) {
                MessageBox.Show("Please Enter The Items To proceed");
                return;
            }
            itemViewModel = new ItemViewModel();
            dealsViewModel = new DealsViewModel();
            dealsItemViewModel = new DealsItemViewModel();
            var l1 = itemViewModel.fillingData();
            var l2 = dealsItemViewModel.fillingData();
            var l3 = dealsViewModel.fillingData();
            seprateDataGridNameRowToMultipleList();
           
            Insert insert = new Insert();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    ArrayList arrayList = new ArrayList();
                    ArrayList checkingDuplicateValuesForDealsBczForEachLoop = new ArrayList();
                    foreach (var item in dealsViewModel.dataDeals.dataDealsModel)
                    {
                        arrayList.Add(item.Name);
                    }
                    if (arrayList.Contains(row.Cells[0].Value.ToString()))
                    {

                        foreach (var deals in dealsViewModel.dataDeals.dataDealsModel)
                        {
                            foreach (var dealsItem in dealsItemViewModel.dataDealsItem.dataDealsItemModel)
                            {
                                foreach (var item in itemViewModel.itemModel.dataItem)
                                {
                                    if (row.Cells[0].Value.Equals(deals.Name) && dealsItem.Item_id.Equals(item.Id) && deals.ID.Equals(dealsItem.Deals_id))
                                    {
                                        if (!checkingDuplicateValuesForDealsBczForEachLoop.Contains(deals.Name + "-" + item.Id + "-" + dealsItem.Deals_id))
                                        {

                                            checkingDuplicateValuesForDealsBczForEachLoop.Add(deals.Name + "-" + item.Id + "-" + dealsItem.Deals_id);


                                            string l = discountoOnEachItem_comboBox.SelectedItem.ToString();
                                            l = (l.Remove(l.Length - 1));

                                            insert.InsertOrders(deals.Price, Global.userId, item.Id, item.Cat_ID, invoice_Label.Text + "-" + deals.Name, Convert.ToInt32(row.Cells[1].Value), Convert.ToInt32(deleviryCharges_TextBox.Text), Convert.ToInt32(l), 0);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        string l = discountoOnEachItem_comboBox.SelectedItem.ToString();
                        l = (l.Remove(l.Length - 1));
                        insert.InsertOrders(Convert.ToInt32(total_label.Text), Global.userId, Convert.ToInt32(row.Cells[4].Value), Convert.ToInt32(row.Cells[3].Value), invoice_Label.Text, Convert.ToInt32(row.Cells[1].Value), Convert.ToInt32(deleviryCharges_TextBox.Text), Convert.ToInt32(l), 0);
                    }
                }
            }
            if (custName_TextBox.Text != "")
            {
                Insert insert = new Insert();
                insert.InsertCustomerOrder((invoice_Label.Text), custName_TextBox.Text, custMail_TextBox.Text, custPhone_TextBox.Text, custAddress_TextBox.Text);

            }
            custName_TextBox.Text ="";
            custAddress_TextBox.Text = "";
            custPhone_TextBox.Text = "";
            custMail_TextBox.Text = "";
            notGoFurtherItemsToSelectAnyThingCounter = 0;
            printDocumentMethod();
            clearList();
            dataGridView1.Rows.Clear();
            gettingCategoriesAndDealsInFlowLayoutPanelButton();
            Update update1 = new Update();
            int invo = gettingInvoiceNumber();
            invo++;
            update1.UpdateInvoice(0, invo);
            gettingInvoiceNumber();
        }

        private void fullDiscount_ComboBox_MouseClick(object sender, MouseEventArgs e)
        {
            discountoOnEachItem_comboBox.SelectedIndex = 0;
        }

        private void discountoOnEachItem_comboBox_MouseClick(object sender, MouseEventArgs e)
        {
            AddingDiscountsOnItems addingDiscountsOnItems = new AddingDiscountsOnItems();
            addingDiscountsOnItems.ShowDialog();
            //fullDiscount_ComboBox.SelectedIndex = 0;
        }

        private void discountoOnEachItem_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculationTotal();
            //if (dataGridView1.Rows.Count > 0)
            //{
            //    dataGridView1.Rows.Clear();
            //    string[] vs = new string[5];
            //    foreach (string[] item in testing)
            //    {
            //        for (int i = 0; i < item.Length; i++)
            //        {
            //            vs[i] = item[i];
            //        }
            //        dealsViewModel = new DealsViewModel();
            //        int lenght = dealsViewModel.fillingData();
            //        bool surface = false;
            //        foreach (var deals in dealsViewModel.dataDeals.dataDealsModel)
            //        {
            //            if (vs[0].Equals(deals.Name))
            //            {
            //                surface = true;
            //            }
            //        }
            //        if (!surface)
            //        {
            //            string discount = discountoOnEachItem_comboBox.SelectedItem.ToString();
            //            discount = (discount.Remove(discount.Length - 1));
            //            int discountValue = Convert.ToInt32(vs[2]);
            //            int afterDiscount = discountValue - (discountValue * Convert.ToInt32(discount) / 100);
            //            vs[2] = afterDiscount.ToString();
            //            dataGridView1.Rows.Add(vs);
            //        }
            //        else
            //        {
            //            dataGridView1.Rows.Add(vs);
            //        }
            //    }
            //    calculationTotal();
            //}

        }

       



        #region Getting Orders (Last ,recent Clear, delete)
        private void lastOrder_PictureBox_Click(object sender, EventArgs e)
        {
            qty_TextBox.Enabled = false;
            discountoOnEachItem_comboBox.Enabled = false;
            deleviryCharges_TextBox.Enabled = false;

            dataGridView1.Rows.Clear();
            clearList();
            OrderViewModel orderViewModel = new OrderViewModel();
            itemViewModel = new ItemViewModel();
            categoriesViewModel = new CategoriesViewModel();
            dealsViewModel = new DealsViewModel();

            int l = orderViewModel.AllfillingData();
            int l2 = itemViewModel.fillingData();
            int l3 = categoriesViewModel.fillingData();
            int l4 =dealsViewModel.fillingData();


            string qrCode = orderViewModel.fillingData();
            if (qrCode == string.Empty)
            {
                MessageBox.Show("Not any record");
                gettinglastOrderLock = false;
            }
            else
            {
                lastOrderInvoice = qrCode;
                gettinglastOrderLock = true;
                foreach (var order in orderViewModel.ordersModel.dataOrders)
                {
                    if (order.QRCode.Contains(qrCode))
                    {
                        foreach (var deals in dealsViewModel.dataDeals.dataDealsModel)
                        {
                            if (order.QRCode.Equals(qrCode + "-" + deals.Name))
                            {

                                gettingReadyForOrderToEnterInDataGridViewStack[0] = deals.Name;
                                gettingReadyForOrderToEnterInDataGridViewStack[1] = order.Qty.ToString();
                                gettingReadyForOrderToEnterInDataGridViewStack[2] = deals.Price.ToString();
                                gettingReadyForOrderToEnterInDataGridViewStack[3] = "0";
                                gettingReadyForOrderToEnterInDataGridViewStack[4] = deals.ID.ToString();
                                dealsLock = true;
                                
                                if (!checkingForDuplicate()) {
                                    
                                    chechingDuplicateList.Add(gettingReadyForOrderToEnterInDataGridViewStack[0].ToString());
                                    getingDataInDataGrid();
                                }
                                Array.Clear(gettingReadyForOrderToEnterInDataGridViewStack, 0, gettingReadyForOrderToEnterInDataGridViewStack.Length);  //Empty ArrayList
                            }
                        }
                        foreach (var item in itemViewModel.itemModel.dataItem)
                        {

                            if (order.QRCode.Equals(qrCode)) {
                                if (item.Id.Equals(order.ItemId))
                                {
                                    gettingReadyForOrderToEnterInDataGridViewStack[0] = item.Item_Name;
                                    gettingReadyForOrderToEnterInDataGridViewStack[1] = order.Qty.ToString();
                                    gettingReadyForOrderToEnterInDataGridViewStack[2] = item.Price.ToString();
                                    gettingReadyForOrderToEnterInDataGridViewStack[3] = item.Cat_ID.ToString();
                                    gettingReadyForOrderToEnterInDataGridViewStack[4] = item.Id.ToString();

                                    string headerText = "";
                                    foreach (var cat in categoriesViewModel.catModel.dataCat)
                                    {
                                        if (cat.CategoriesID.Equals(order.CatId))
                                        {
                                            headerText = cat.CategoriesName;
                                        }
                                    }
                                    string concat = gettingReadyForOrderToEnterInDataGridViewStack[0] + "-" + headerText;
                                    gettingReadyForOrderToEnterInDataGridViewStack[0] = concat;
                                    chechingDuplicateList.Add(gettingReadyForOrderToEnterInDataGridViewStack[0].ToString());
                                    getingDataInDataGrid();
                                    Array.Clear(gettingReadyForOrderToEnterInDataGridViewStack, 0, gettingReadyForOrderToEnterInDataGridViewStack.Length);  //Empty ArrayList
                                }
                            }

                        }
                        discountoOnEachItem_comboBox.SelectedItem=(order.DiscOnEach + "%");
                        deleviryCharges_TextBox.Text = order.DelevieryCharges.ToString();
                    }

                }
                dealsLock = false;
                itemLock = false;
            }

           
            calculationTotal();


        }

        private void deleteAfterRecivingOrder_pictureBox_Click(object sender, EventArgs e)
        {
            if (!gettinglastOrderLock) return;
            else
            {
                Delete delete = new Delete();
                delete.DeleteOrder(lastOrderInvoice);
                lastOrderInvoice = "";
                dataGridView1.Rows.Clear();
                clearList();
                gettinglastOrderLock = false;
                qty_TextBox.Enabled = true;
                discountoOnEachItem_comboBox.Enabled = true;
                deleviryCharges_TextBox.Enabled = true;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            clearList();
            gettinglastOrderLock = false;
            qty_TextBox.Enabled = true;
            discountoOnEachItem_comboBox.Enabled = true;
            deleviryCharges_TextBox.Enabled = true;
            custName_TextBox.Text = "";
            custAddress_TextBox.Text = "";
            custPhone_TextBox.Text = "";
            custMail_TextBox.Text = "";
        }

        private void orderType_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (orderType_ComboBox.SelectedIndex == 2)
            {
                deleviryCharges_TextBox.Enabled = true;
            }
            else {
                deleviryCharges_TextBox.Enabled = false;
            }
        }

        private void recentOrders_PictureBox_Click(object sender, EventArgs e)
        {

            
            RecentOrder recentOrder;
            qty_TextBox.Enabled = false;
            discountoOnEachItem_comboBox.Enabled = false;
            deleviryCharges_TextBox.Enabled = false;

            dataGridView1.Rows.Clear();
            clearList();
            OrderViewModel orderViewModel = new OrderViewModel();
            itemViewModel = new ItemViewModel();
            categoriesViewModel = new CategoriesViewModel();
            dealsViewModel = new DealsViewModel();

            int l = orderViewModel.AllfillingData();
            int l2 = itemViewModel.fillingData();
            int l3 = categoriesViewModel.fillingData();
            int l4 = dealsViewModel.fillingData();

            

            int lenght = orderViewModel.AllfillingData();
            if (lenght > 0)
            {
                ArrayList array = new ArrayList();
                itemViewModel = new ItemViewModel();
                int length2 = itemViewModel.fillingData();

                categoriesViewModel = new CategoriesViewModel();
                int length3 = categoriesViewModel.fillingData();

                using (recentOrder = new RecentOrder())
                {
                    recentOrder.ShowDialog();
                    invoice = Convert.ToInt32(recentOrder.getValue());
                }
                lastOrderInvoice = invoice.ToString();
                gettinglastOrderLock = true;
                foreach (var order in orderViewModel.ordersModel.dataOrders)
                {
                    array.Add(order.QRCode);
                }
                if (array.Contains(lastOrderInvoice))
                {
                    gettinglastOrderLock = true;
                    foreach (var order in orderViewModel.ordersModel.dataOrders)
                    {
                        if (order.QRCode.Contains(invoice.ToString()))
                        {
                            foreach (var deals in dealsViewModel.dataDeals.dataDealsModel)
                            {
                                if (order.QRCode.Equals(invoice.ToString() + "-" + deals.Name))
                                {

                                    gettingReadyForOrderToEnterInDataGridViewStack[0] = deals.Name;
                                    gettingReadyForOrderToEnterInDataGridViewStack[1] = order.Qty.ToString();
                                    gettingReadyForOrderToEnterInDataGridViewStack[2] = deals.Price.ToString();
                                    gettingReadyForOrderToEnterInDataGridViewStack[3] = "0";
                                    gettingReadyForOrderToEnterInDataGridViewStack[4] = deals.ID.ToString();
                                    dealsLock = true;

                                    if (!checkingForDuplicate())
                                    {

                                        chechingDuplicateList.Add(gettingReadyForOrderToEnterInDataGridViewStack[0].ToString());
                                        getingDataInDataGrid();
                                    }
                                    Array.Clear(gettingReadyForOrderToEnterInDataGridViewStack, 0, gettingReadyForOrderToEnterInDataGridViewStack.Length);  //Empty ArrayList
                                }
                            }
                            foreach (var item in itemViewModel.itemModel.dataItem)
                            {

                                if (order.QRCode.Equals(invoice.ToString()))
                                {
                                    if (item.Id.Equals(order.ItemId))
                                    {
                                        gettingReadyForOrderToEnterInDataGridViewStack[0] = item.Item_Name;
                                        gettingReadyForOrderToEnterInDataGridViewStack[1] = order.Qty.ToString();
                                        gettingReadyForOrderToEnterInDataGridViewStack[2] = item.Price.ToString();
                                        gettingReadyForOrderToEnterInDataGridViewStack[3] = item.Cat_ID.ToString();
                                        gettingReadyForOrderToEnterInDataGridViewStack[4] = item.Id.ToString();

                                        string headerText = "";
                                        foreach (var cat in categoriesViewModel.catModel.dataCat)
                                        {
                                            if (cat.CategoriesID.Equals(order.CatId))
                                            {
                                                headerText = cat.CategoriesName;
                                            }
                                        }
                                        string concat = gettingReadyForOrderToEnterInDataGridViewStack[0] + "-" + headerText;
                                        gettingReadyForOrderToEnterInDataGridViewStack[0] = concat;
                                        chechingDuplicateList.Add(gettingReadyForOrderToEnterInDataGridViewStack[0].ToString());
                                        getingDataInDataGrid();
                                        Array.Clear(gettingReadyForOrderToEnterInDataGridViewStack, 0, gettingReadyForOrderToEnterInDataGridViewStack.Length);  //Empty ArrayList
                                    }
                                }

                            }
                            discountoOnEachItem_comboBox.SelectedItem = (order.DiscOnEach + "%");
                            deleviryCharges_TextBox.Text = order.DelevieryCharges.ToString();
                        }

                    }
                    dealsLock = false;
                    itemLock = false;
                }
                else {
                    MessageBox.Show("Not Found in Database ");
                    gettinglastOrderLock = false;
                }
               
            
                ////foreach (var item in orderViewModel.ordersModel.dataOrders)
                //{
                //    if (invoice.Equals(item.QRCode))
                //    {
                //        foreach (var item1 in itemViewModel.itemModel.dataItem)
                //        {

                //            if (item1.Id.Equals(item.ItemId))
                //            {
                //                gettingReadyForOrderToEnterInDataGridViewStack[0] = item1.Item_Name;
                //                gettingReadyForOrderToEnterInDataGridViewStack[1] = item.Qty.ToString();
                //                gettingReadyForOrderToEnterInDataGridViewStack[2] = item1.Price.ToString();
                //                gettingReadyForOrderToEnterInDataGridViewStack[3] = item1.Cat_ID.ToString();
                //                gettingReadyForOrderToEnterInDataGridViewStack[4] = item1.Id.ToString();
                //                string headerText = "";
                //                foreach (var item2 in categoriesViewModel.catModel.dataCat)
                //                {
                //                    if (item2.CategoriesID.Equals(item.CatId))
                //                    {
                //                        headerText = item2.CategoriesName;
                //                    }
                //                }
                //                string concat = gettingReadyForOrderToEnterInDataGridViewStack[0] + "-" + headerText;
                //                gettingReadyForOrderToEnterInDataGridViewStack[0] = concat;
                //                chechingDuplicateList.Add(gettingReadyForOrderToEnterInDataGridViewStack[0].ToString());
                //                getingDataInDataGrid();
                //                Array.Clear(gettingReadyForOrderToEnterInDataGridViewStack, 0, gettingReadyForOrderToEnterInDataGridViewStack.Length);  //Empty ArrayList
                //            }

                //        }
                //    }

                //}

                calculationTotal();

            }
            else
            {
                MessageBox.Show("Empty Orders table in data base");
            }

        }
        #endregion

        #region Print
        private void printDocumentMethod()
        {
            for (int i = 0; i < 2; i++)
            {
                counterForInvoice++;
                PaperSize psize = new PaperSize("Custom", 280, 800);
                printDocument1.DefaultPageSettings.PaperSize = psize;
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
            dataGridView1.Rows.Clear();
            counterForInvoice = 0;
            specialPriceTrigger = false;
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           
            int y_diff = 8;
            int lenthForLogo = 30;
            int minustocheck = 60;
            int customerdifference = 0;
            int back = 20;
            int moreback = 40;
            int subtotal = 0;
            e.Graphics.DrawString("Spinzer", new Font("Arial", 27, FontStyle.Regular), Brushes.Black, new Point(130 - minustocheck, 0));
            e.Graphics.DrawString(date_Label.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(120 - minustocheck, 20 + y_diff + lenthForLogo));

            Pen pen = new Pen(Brushes.Black, 1);
            Pen penForRectangle = new Pen(Brushes.Black, 2);
            e.Graphics.DrawLine(pen, 0, 55 + y_diff + lenthForLogo, 400, 55 + y_diff + lenthForLogo);
            if (counterForInvoice == 2)
            {
                e.Graphics.DrawString("Customer", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(120 - 30, 60 + y_diff + lenthForLogo));
                customerdifference = 20;
            }
            e.Graphics.DrawString("Invoice Number", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(120 - minustocheck, 60 + y_diff + lenthForLogo + customerdifference));
            e.Graphics.DrawString(invoice.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(190 - minustocheck, 90 + y_diff + lenthForLogo + customerdifference));
            e.Graphics.DrawRectangle(penForRectangle, 130 - minustocheck, 155 + customerdifference, 140, 30);
            e.Graphics.DrawString(orderType_ComboBox.SelectedItem.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(156 - minustocheck, 162 + customerdifference));
            if (dataGridView1.Rows.Count > 9)
            {
                e.Graphics.DrawString(dataGridView1.Rows.Count.ToString() + " Items", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(170 - minustocheck, 200 + customerdifference));

            }
            else
            {
                e.Graphics.DrawString(dataGridView1.Rows.Count.ToString() + "  Items", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(170 - minustocheck, 200 + customerdifference));
            }
            e.Graphics.DrawLine(pen, 0, 220 + customerdifference, 400, 220 + customerdifference);
            int lengthBetweenItems = 80;
            int i=0 ,j= 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                ArrayList arrayList = new ArrayList();
                foreach (var item in dealsViewModel.dataDeals.dataDealsModel)
                {
                    arrayList.Add(item.Name);
                }
                if (arrayList.Contains(row.Cells[0].Value.ToString()))
                {
                    
                    e.Graphics.DrawString(row.Cells["qtyDGV"].Value.ToString() + " X  ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(5, 190 + lengthBetweenItems + customerdifference-back));
                    e.Graphics.DrawString(dealList[i].ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(38, 194 + lengthBetweenItems + customerdifference - back));

                    e.Graphics.DrawString("PKR", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(200, 182 + lengthBetweenItems + customerdifference - back));
                    e.Graphics.DrawString(row.Cells["itemPriceDGV"].Value.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(200, 198 + lengthBetweenItems + customerdifference - back));
                    subtotal += Convert.ToInt32(row.Cells["itemPriceDGV"].Value)* Convert.ToInt32(row.Cells["qtyDGV"].Value);
                    lengthBetweenItems += 40;
                    i++;
                }
                else
                {
                    i = 0;
                    try
                    {
                        e.Graphics.DrawString(row.Cells["qtyDGV"].Value.ToString() + " X  ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(5, 190 + lengthBetweenItems + customerdifference - back));
                        e.Graphics.DrawString(itemList[j].ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(38, 182 + lengthBetweenItems + customerdifference - back));
                        e.Graphics.DrawString(CategoryList[j].ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(38, 198 + lengthBetweenItems + customerdifference - back));
                        e.Graphics.DrawString("PKR", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(200, 182 + lengthBetweenItems + customerdifference - back));
                        if (discountoOnEachItem_comboBox.SelectedIndex > 0)
                        {
                            itemViewModel = new ItemViewModel();
                            int l = itemViewModel.fillingData();
                            foreach (var item in itemViewModel.itemModel.dataItem)
                            {
                                if (item.Id.Equals(Convert.ToInt32(row.Cells["itemIDGV"].Value))) {
                                    e.Graphics.DrawString(item.Price.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(200, 198 + lengthBetweenItems + customerdifference - back));
                                    subtotal += Convert.ToInt32(item.Price.ToString())*Convert.ToInt32(row.Cells["qtyDGV"].Value);
                                }
                            }
                            
                        }
                        else {
                            e.Graphics.DrawString(row.Cells["itemPriceDGV"].Value.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(200, 198 + lengthBetweenItems + customerdifference - back));
                            subtotal += Convert.ToInt32(row.Cells["itemPriceDGV"].Value)* Convert.ToInt32(row.Cells["qtyDGV"].Value);
                        }
                       
                        lengthBetweenItems += 40;
                        j++;
                    }
                    catch (Exception)
                    {

                    }
                }
               
            }


            e.Graphics.DrawLine(pen, 0, 210 + lengthBetweenItems + customerdifference - back - 20, 400, 210 + lengthBetweenItems + customerdifference - back-20);
            lengthBetweenItems += 20;
            e.Graphics.DrawString("Sub Total ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, 220 + lengthBetweenItems + customerdifference - back - moreback));
            e.Graphics.DrawString(subtotal.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(200, 220 + lengthBetweenItems + customerdifference - back - moreback));
            lengthBetweenItems += 20;
            int final = 0;
            final = Convert.ToInt32(total_label.Text) + Convert.ToInt32(deleviryCharges_TextBox.Text);
            if (!specialPriceTrigger)
            {
                if (!discountoOnEachItem_comboBox.SelectedItem.Equals("0%"))
                {
                    e.Graphics.DrawString("Discount ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(5, 230 + lengthBetweenItems + customerdifference - back - moreback));
                    e.Graphics.DrawString("-" + discountoOnEachItem_comboBox.SelectedItem.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(200, 230 + lengthBetweenItems + customerdifference - back - moreback));
                    lengthBetweenItems += 20;

                    e.Graphics.DrawString("After Discount ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, 230 + lengthBetweenItems + customerdifference - back - moreback));
                    e.Graphics.DrawString(total_label.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(200, 230 + lengthBetweenItems + customerdifference - back - moreback));
                    lengthBetweenItems += 20;
                }
                if (orderType_ComboBox.SelectedIndex == 2)
                {
                    e.Graphics.DrawString("DiliveryCharges ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(5, 230 + lengthBetweenItems + customerdifference - back - moreback));
                    e.Graphics.DrawString("+" + deleviryCharges_TextBox.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(200, 230 + lengthBetweenItems + customerdifference - back - moreback));
                    lengthBetweenItems += 20;
                }

            }
            else {
                e.Graphics.DrawString("Special Customer Discount", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(5, 230 + lengthBetweenItems + customerdifference - back - moreback));
                lengthBetweenItems += 20;
            }
            e.Graphics.DrawString("Total ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(5, 230 + lengthBetweenItems + customerdifference - back - moreback));
            e.Graphics.DrawString(final.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(200, 230 + lengthBetweenItems + customerdifference - back - moreback));
            lengthBetweenItems += 10;
            if (counterForInvoice == 2)
            {
                QR_Code qR_Code = new QR_Code();
                Bitmap resize = new Bitmap(qR_Code.encode("facebook.com/spinzerburger"), new Size(80, 80));
                e.Graphics.DrawImage(resize, new Point(190, 275 + lengthBetweenItems + customerdifference - back - moreback));
                e.Graphics.DrawString("facebook.com/spinzerburger", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 330 + lengthBetweenItems + customerdifference - back - moreback));
                e.Graphics.DrawString("www.spinzerburger.com", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(5, 310 + lengthBetweenItems + customerdifference - back - moreback));
                e.Graphics.DrawString("0314-2020306", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(40, 290 + lengthBetweenItems + customerdifference - back - moreback));
                e.Graphics.DrawLine(pen, 0, 365 + lengthBetweenItems + customerdifference - back - moreback, 400, 365 + lengthBetweenItems + customerdifference - back - moreback);
                e.Graphics.DrawString("All Right Reserved Revoation", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(50, 375 + lengthBetweenItems + customerdifference - back - moreback));
                e.Graphics.DrawString("    revoation@gmail.com", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(50, 390 + lengthBetweenItems + customerdifference - back - moreback));
            }
        }
        #endregion

        private void clearList()
        {
            itemList.Clear();
            CategoryList.Clear();
            dealList.Clear();
            testing.Clear();
            chechingDuplicateList.Clear();
            dateTime = DateTime.Now;
            gettingInvoiceNumber();
            Array.Clear(gettingReadyForOrderToEnterInDataGridViewStack, 0, gettingReadyForOrderToEnterInDataGridViewStack.Length);
            totalPrice = 0;
            total_label.Text = totalPrice.ToString();
            CategoryID = -1;

            dataGridView1.Rows.Clear();
            dealsLock = false;
            itemLock = false;
            heading_Label.Text = "";
            subHeading_Label.Text = "";
            deleviryCharges_TextBox.Text = "0";
            gettingCategoriesAndDealsInFlowLayoutPanelButton();
            notGoFurtherItemsToSelectAnyThingCounter = 0;
            dynamicButton.Focus();


        }
        private void seprateDataGridNameRowToMultipleList() {
            CategoryList.Clear();
            itemList.Clear();
            dealList.Clear();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string removing1stLetterFromString = "";
                string[] seprateList = new string[2];
                ArrayList list = new ArrayList();
                
               
                foreach (var item in dealsViewModel.dataDeals.dataDealsModel)
                {
                    list.Add(item.Name);
                }
                if (list.Contains((row.Cells[0].Value.ToString())))
                {
                    foreach (var item in dealsViewModel.dataDeals.dataDealsModel)
                    {

                        if ((item.Name).Equals(row.Cells[0].Value.ToString()))
                        {
                            removing1stLetterFromString = row.Cells[0].Value.ToString();
                            if (Char.IsDigit(removing1stLetterFromString[0]))
                            {
                                
                                removing1stLetterFromString = removing1stLetterFromString.Substring(1, removing1stLetterFromString.Length - 1);
                                dealList.Add(removing1stLetterFromString);
                            }
                            else {
                               
                                removing1stLetterFromString = removing1stLetterFromString.Substring(1, removing1stLetterFromString.Length - 1);
                                dealList.Add(removing1stLetterFromString);
                            }
                        }
                    }
                }
                else {

                    string toSeprateStringFromDataGridViewRowCells = row.Cells[0].Value.ToString();
                    seprateList = toSeprateStringFromDataGridViewRowCells.Split('-');
                    removing1stLetterFromString = seprateList[0];
                    if (Char.IsDigit(removing1stLetterFromString[0]))
                    {
                        removing1stLetterFromString = removing1stLetterFromString.Substring(1, removing1stLetterFromString.Length - 1);
                        itemList.Add(removing1stLetterFromString);
                    }
                    else {
                        removing1stLetterFromString = removing1stLetterFromString.Substring(1, removing1stLetterFromString.Length - 1);
                        itemList.Add(removing1stLetterFromString);
                    }
                    removing1stLetterFromString = seprateList[1];

                    if (Char.IsDigit(removing1stLetterFromString[1]))
                    {
                        removing1stLetterFromString = removing1stLetterFromString.Substring(1, removing1stLetterFromString.Length - 1);
                        CategoryList.Add(removing1stLetterFromString);
                    }
                    else {
                        removing1stLetterFromString = removing1stLetterFromString.Substring(1, removing1stLetterFromString.Length - 1);
                        CategoryList.Add(removing1stLetterFromString);
                    }
                }
            }

        }
    


        #region DataGridStyle,ButtonStyle
        #region DataGridView Style
        public void mainFormLoad_DataGrid(DataGridView dataGridView)
        {
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        #endregion

        #region Button Style
        private void styleOfButton(string name)
        {
            dynamicButton = new Button();
            dynamicButton.Focus();
            ButtonsflowLayoutPanel.Controls.Add(dynamicButton);
            this.dynamicButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.dynamicButton.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.dynamicButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dynamicButton.Location = new System.Drawing.Point(3, 3);
            this.dynamicButton.Name = name;
            this.dynamicButton.Size = new System.Drawing.Size(205, 80);
            this.dynamicButton.TabIndex = 49;
            this.dynamicButton.Text = name;
            this.dynamicButton.UseVisualStyleBackColor = false;
            this.dynamicButton.KeyDown += DynamicButton_KeyDown;
            this.dynamicButton.MouseClick += DynamicButton_MouseClick;
        }

        #endregion
        #endregion

        private int gettingInvoiceNumber() {
            invoiceViewModel = new InvoiceViewModel();
            invoice = invoiceViewModel.fillingData();
            invoice_Label.Text = invoice.ToString();
            return invoice;
        }
        private void modifyStock() {
            MaterialViewModel materialViewModel = new MaterialViewModel();
            int val = materialViewModel.fillingData();
            StockViewModel stockViewModel = new StockViewModel();
            DataTable va = stockViewModel.fillingData();

           
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                foreach (var materials in materialViewModel.dataToMaterialModel.dataMaterials)
                {
                    if (materials.ItemId.ToString().Equals(row.Cells[4].Value.ToString()))
                    {
                        foreach (var stock in stockViewModel.stockModel.dataStock)
                        {
                            if (stock.Name.Equals(materials.Name)) {
                                var value = minusStockCalculation(materials.Qty,materials.Weight,stock.Qty,stock.Weight);
                                int price = Convert.ToInt32(updateStockPrice(stock.Price, stock.Qty, stock.Weight,materials.Qty,materials.Weight));
                                if (materials.Qty!=null)
                                {
                                    StockViewModel.transactionBegin(value, "qty", stock.Id, Global.userId, stock.Name, stock.ExpiryDate, stock.Description, price, materials.Qty.ToString());
                                }
                                else if (materials.Weight!=null)
                                {
                                    StockViewModel.transactionBegin(value, "weight", stock.Id, Global.userId, stock.Name, stock.ExpiryDate, stock.Description, price, materials.Weight.ToString());
                                }
                            }
                        }
                    }
                }
            }
        }
        private string minusStockCalculation(int? newQty , double? newWeight, Nullable<int> oldQty, Nullable<double> oldWeight)
         {
            
            string returnForm = "";
            
            if (newQty!=null)
            {
                int? resultQty = oldQty - newQty;
                returnForm = resultQty.ToString();

            }
            if (newWeight!=null)
            {
                double? resultWeigth = oldWeight - newWeight;
                returnForm = resultWeigth.ToString();
            }
            return returnForm;

        }
        private int? updateStockPrice(int? price, int? oldQty, double? oldWeight,int? newQty,double? newWeight) {
            if (oldQty != null)
            {
                int? resultPrice = (price / oldQty);
                resultPrice *= newQty;
                price -= resultPrice;

            }
            if (oldWeight != null)
            {
                double? resultWeigth = (price / oldWeight);
                resultWeigth *= newWeight;
                price -= Convert.ToInt32(resultWeigth);
            }
            return price;
        }
    }
}
