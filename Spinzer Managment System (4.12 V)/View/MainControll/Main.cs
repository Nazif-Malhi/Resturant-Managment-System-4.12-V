
using Spinzer_Managment_System__4._12_V_.View.Grid.Base;
using Spinzer_Managment_System__4._12_V_.View.Grid.Cards;
using Spinzer_Managment_System__4._12_V_.View.Small_Controlls;
using Spinzer_Managment_System__4._12_V_.View.SubMenue;
using Spinzer_Managment_System__4._12_V_.View.UserControll;
using Spinzer_Managment_System__4._12_V_.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spinzer_Managment_System__4._12_V_.View.MainControll
{
    public partial class Main : UserControl
    {

        private SubMenueAuthenticaition subMenueAuthenticaition;
        private SubMenueFood subMenueFood;
        private SubMenueCustomer subMenueCustomer;
        private SubMenueStock subMenueStock;
        private SubMenueDeals subMenueDeals;

        GetUserDataGrid getUserDataGrid;
        GetEmployeeDataGrid getEmployeeDataGrid;
        GetCustomerDataGrid getCustomerDataGrid;
        GetCategoryDataGrid getCategoryDataGrid;
        GetItemsDataGrid getItemsDataGrid;
        GetDealDataGrid getDealDataGrid;
        StockUserController stockUserController;



        


        private bool HomeLock, AuthenticationLock, FoodCategoriesLock, CustomerLock, OrderLock, StockManagmentLock,dealLock;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }


        public Main()
        {
           
            
            InitializeComponent(); 
            subMenueAuthenticaition = new SubMenueAuthenticaition();
            subMenueFood = new SubMenueFood();
            subMenueCustomer = new SubMenueCustomer();
            subMenueStock = new SubMenueStock();
            subMenueDeals = new SubMenueDeals();

            getUserDataGrid = new GetUserDataGrid();
            getEmployeeDataGrid = new GetEmployeeDataGrid();
            getCustomerDataGrid = new GetCustomerDataGrid();
            getCategoryDataGrid = new GetCategoryDataGrid();
            getItemsDataGrid= new GetItemsDataGrid();
            getDealDataGrid = new GetDealDataGrid();
            stockUserController = new StockUserController();

            
            InitializingFormComponents();

            #region Creating Click Events

            subMenueAuthenticaition.newUser_PictureBox.Click += NewUser_PictureBox_Click;
            subMenueAuthenticaition.allUser_PictureBox.Click += AllUser_PictureBox_Click;
            subMenueAuthenticaition.newEmployee_PictureBox.Click += NewEmployee_PictureBox_Click;
            subMenueAuthenticaition.allEmployee_PictureBox.Click += AllEmployee_PictureBox_Click;
            subMenueCustomer.newCustomer_PictureBox.Click += NewCustomer_PictureBox_Click;
            subMenueCustomer.allCustomer_PictureBox.Click += AllCustomer_PictureBox_Click;
            subMenueFood.newCategory_PictureBox.Click += NewCategory_PictureBox_Click;
            subMenueFood.AllCategory_pictureBox.Click += AllCategory_pictureBox_Click;
            subMenueFood.newItem_PictureBox.Click += NewItem_PictureBox_Click;
            subMenueFood.allItems_PictureBox.Click += AllItems_PictureBox_Click;
            subMenueDeals.newDeals_PictureBox.Click += NewDeals_PictureBox_Click;
            subMenueDeals.allDeals_PictureBox.Click += AllDeals_PictureBox_Click;
            subMenueStock.newStock_PictureBox.Click += NewStock_PictureBox_Click;
            subMenueStock.allStock_pictureBox.Click += AllStock_pictureBox_Click;
            stockUserController.update_PictureBox.Click += Update_PictureBox_Click;
            stockUserController.modify_PictureBox.Click += Modify_PictureBox_Click;
            stockUserController.delete_PictureBox.Click += Delete_PictureBox_Click;

           
             


            #endregion

        }

      









        #region Create Click Events From Sub Menue's

        #region Authentication

        #region Users
        private void NewUser_PictureBox_Click(object sender, EventArgs e)
        {

            this.Controls.Remove(getUserDataGrid);
            getUserDataGrid = new GetUserDataGrid();
            
            InitializingFormComponents();
            getUserDataGrid.BringToFront();
            getUserDataGrid.Show();
        }
        private void AllUser_PictureBox_Click(object sender, EventArgs e)
        {
            subMenueAuthenticaition.Hide();
            getUserDataGrid.Show();
            getUserDataGrid.BringToFront();
            
            getEmployeeDataGrid.Hide();
            getCustomerDataGrid.Hide();

            getCategoryDataGrid.Hide();
            getItemsDataGrid.Hide();
            stockUserController.Hide();
            getDealDataGrid.Hide();

            AuthenticationLock = true;
            FoodCategoriesLock = false;
            CustomerLock = false;
            OrderLock = false;
            StockManagmentLock = false;
            dealLock = false;

        }
        #endregion
        #region Employee

        private void NewEmployee_PictureBox_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(getEmployeeDataGrid);
            getEmployeeDataGrid = new GetEmployeeDataGrid();
            InitializingFormComponents();
            getEmployeeDataGrid.BringToFront();
            getEmployeeDataGrid.Show();
        }
        private void AllEmployee_PictureBox_Click(object sender, EventArgs e)
        {
            subMenueAuthenticaition.Hide();
            getEmployeeDataGrid.Show();
            getEmployeeDataGrid.BringToFront();
            getUserDataGrid.Hide();
            getCustomerDataGrid.Hide();

            getCategoryDataGrid.Hide();
            getItemsDataGrid.Hide();
            stockUserController.Hide();
            getDealDataGrid.Hide();

            AuthenticationLock = true;
            FoodCategoriesLock = false;
            CustomerLock = false;
            OrderLock = false;
            StockManagmentLock = false;
            dealLock = false;

        }

        #endregion

        #endregion

        #region Food

        #region Items

        private void NewItem_PictureBox_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(getItemsDataGrid);
            getItemsDataGrid = new GetItemsDataGrid();

            InitializingFormComponents();
            getItemsDataGrid.BringToFront();
            getItemsDataGrid.Show();
        }


        private void AllItems_PictureBox_Click(object sender, EventArgs e)
        {
            subMenueFood.Hide();
            getItemsDataGrid.Show();
            getItemsDataGrid.BringToFront();
            getUserDataGrid.Hide();
            getEmployeeDataGrid.Hide();
            getCustomerDataGrid.Hide();
            getCategoryDataGrid.Hide();
            stockUserController.Hide();
            getDealDataGrid.Hide();

            AuthenticationLock = false;
            FoodCategoriesLock = true;
            CustomerLock = false;
            OrderLock = false;
            StockManagmentLock = false;
            dealLock = false;
        }
        #endregion
        #region Category

        private void NewCategory_PictureBox_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(getCategoryDataGrid);
            getCategoryDataGrid = new GetCategoryDataGrid();

            InitializingFormComponents();
            getCategoryDataGrid.BringToFront();
            getCategoryDataGrid.Show();
        }

        private void AllCategory_pictureBox_Click(object sender, EventArgs e)
        {
            subMenueFood.Hide();
            getCategoryDataGrid.Show();
            getCategoryDataGrid.BringToFront();
            getUserDataGrid.Hide();
            getEmployeeDataGrid.Hide();
            getCustomerDataGrid.Hide();
            getItemsDataGrid.Hide();
            stockUserController.Hide();
            getDealDataGrid.Hide();

            AuthenticationLock = false;
            FoodCategoriesLock = true;
            CustomerLock = false;
            OrderLock = false;
            StockManagmentLock = false;
            dealLock = false;
        }
        #endregion

        #endregion

        #region Customer

        private void NewCustomer_PictureBox_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(getCustomerDataGrid);
            getCustomerDataGrid = new GetCustomerDataGrid();

            InitializingFormComponents();
            getCustomerDataGrid.BringToFront();
            getCustomerDataGrid.Show();
        }

        private void AllCustomer_PictureBox_Click(object sender, EventArgs e)
        {
            subMenueCustomer.Hide();
            getCustomerDataGrid.Show();
            getCustomerDataGrid.BringToFront();

            getUserDataGrid.Hide();
            getEmployeeDataGrid.Hide();
            getCategoryDataGrid.Hide();
            getItemsDataGrid.Hide();
            stockUserController.Hide();
            getDealDataGrid.Hide();


            AuthenticationLock = false;
            FoodCategoriesLock = false;
            CustomerLock = true;
            OrderLock = false;
            StockManagmentLock = false;
            dealLock = false;

        }
        #endregion

        #region Stock
        private void Delete_PictureBox_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(stockUserController);
            stockUserController = new StockUserController();

            InitializingFormComponents();
            stockUserController.BringToFront();
            stockUserController.Show();
        }

        private void Modify_PictureBox_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(stockUserController);
            stockUserController = new StockUserController();

            InitializingFormComponents();
            stockUserController.BringToFront();
            stockUserController.Show();
        }

        private void Update_PictureBox_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(stockUserController);
            stockUserController = new StockUserController();

            InitializingFormComponents();
            stockUserController.BringToFront();
            stockUserController.Show();
        }
        private void NewStock_PictureBox_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(stockUserController);
            stockUserController = new StockUserController();

            InitializingFormComponents();
            stockUserController.BringToFront();
            stockUserController.Show();
        }
        private void AllStock_pictureBox_Click(object sender, EventArgs e)
        {
            subMenueStock.Hide();
            stockUserController.Show();
            stockUserController.BringToFront();

            getEmployeeDataGrid.Hide();
            getCustomerDataGrid.Hide();
            getUserDataGrid.Hide();
            getCategoryDataGrid.Hide();
            getItemsDataGrid.Hide();
            getDealDataGrid.Hide();

            AuthenticationLock = false;
            FoodCategoriesLock = false;
            CustomerLock = false;
            OrderLock = false;
            StockManagmentLock = true;
            dealLock = false;

        }
        #endregion

        #region Deals

        private void NewDeals_PictureBox_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(getDealDataGrid);
            getDealDataGrid = new GetDealDataGrid();

            InitializingFormComponents();
            getDealDataGrid.BringToFront();
            getDealDataGrid.Show();
        }

        private void AllDeals_PictureBox_Click(object sender, EventArgs e)
        {
            subMenueDeals.Hide();
            getDealDataGrid.Show();
            getDealDataGrid.BringToFront();

            getEmployeeDataGrid.Hide();
            getCustomerDataGrid.Hide();

            getCategoryDataGrid.Hide();
            getItemsDataGrid.Hide();
            stockUserController.Hide();
            getUserDataGrid.Hide();

            AuthenticationLock = false;
            FoodCategoriesLock = false;
            CustomerLock = false;
            OrderLock = false;
            StockManagmentLock = false;
            dealLock = true;
        }
        #endregion
        #endregion




        #region Initilizing Main Screen Components On Loading    ✔
        private void InitializingFormComponents()
        {
            this.Controls.Add(getUserDataGrid);
            getUserDataGrid.Location = new Point(258, 68);
            getUserDataGrid.Hide();

            this.Controls.Add(getEmployeeDataGrid);
            getEmployeeDataGrid.Location = new Point(258, 68);
            getEmployeeDataGrid.Hide();

           
            this.Controls.Add(getCustomerDataGrid);
            getCustomerDataGrid.Location = new Point(258, 68);
            getCustomerDataGrid.Hide();


            this.Controls.Add(getCategoryDataGrid);
            getCategoryDataGrid.Location = new Point(258, 68);
            getCategoryDataGrid.Hide();

            this.Controls.Add(getItemsDataGrid);
            getItemsDataGrid.Location = new Point(258, 68);
            getItemsDataGrid.Hide();

            this.Controls.Add(getDealDataGrid);
            getDealDataGrid.Location = new Point(258, 68);
            getDealDataGrid.Hide();



            ////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////

            this.Controls.Add(stockUserController);
            stockUserController.Location = new Point(258, 68);
            stockUserController.Hide();
            ////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////
            //////////////////////////////////
            /////////////////////////////
            this.Controls.Add(subMenueAuthenticaition);
            this.Controls.Add(subMenueFood);
            this.Controls.Add(subMenueCustomer);
            this.Controls.Add(subMenueStock);
            this.Controls.Add(subMenueDeals);

            subMenueAuthenticaition.Location = new Point(243, 89);
            subMenueFood.Location = new Point(243, 151);
            subMenueCustomer.Location = new Point(243, 232);
            subMenueStock.Location = new Point(243, 350);
            subMenueDeals.Location = new Point(241, 407);

            subMenueAuthenticaition.Hide();
            subMenueFood.Hide();
            subMenueCustomer.Hide();
            subMenueStock.Hide();
            subMenueDeals.Hide();

            ///
            ////////
            /////////////////////
            ///////////////////////////////////
        }
        #endregion    


        #region InitialDeninitial Components after Loading Components
        private void DeInitializingMainScreenComponents()
        {
            solidGauge.Hide();
            angularGauge.Hide();
            cartesianChart.Hide();
            pieChart.Hide();
        }
        private void InitializingMainScreenComponents()
        {
            solidGauge.Show();
            angularGauge.Show();
            cartesianChart.Show();
            pieChart.Show();
            //////////////getDataGrid.Hide();
        }
        #endregion


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


       
        private void EntryMainForm_MouseEnter(object sender, EventArgs e)
        {
            subMenueAuthenticaition.Hide();
            subMenueFood.Hide();
            subMenueCustomer.Hide();
            subMenueDeals.Hide();
            subMenueStock.Hide();

            if (AuthenticationLock == true)
            {
                this.BackgroundImage = Properties.Resources.AuthenticationForm;
            }
            else if (CustomerLock == true)
            {
                this.BackgroundImage = Properties.Resources.Customers;
            }
            else if (FoodCategoriesLock == true)
            {
                this.BackgroundImage = Properties.Resources.Food_Categories;
            }
            else if (dealLock==true) {
                this.BackgroundImage = Properties.Resources.Deals;
            }
            else if (StockManagmentLock==true) {
                this.BackgroundImage = Properties.Resources.Stock_Managment;
            }

            else if (StockManagmentLock == false && CustomerLock == false && FoodCategoriesLock == false && AuthenticationLock == false && dealLock == false)
            {
                this.BackgroundImage = Properties.Resources.Home;
            }
        }



        #region Home  ✔
        private void Home_PictureBox_Click(object sender, EventArgs e)
        {

            InitializingMainScreenComponents();
            this.BackgroundImage = Properties.Resources.Home;

            subMenueAuthenticaition.Hide();
            subMenueFood.Hide();
            subMenueStock.Hide();
            subMenueCustomer.Hide();
            subMenueDeals.Hide();


            getUserDataGrid.Hide();
            getItemsDataGrid.Hide();
            getEmployeeDataGrid.Hide();
            getCustomerDataGrid.Hide();
            getCategoryDataGrid.Hide();
            getDealDataGrid.Hide();

           
            //

            AuthenticationLock = false;
            FoodCategoriesLock = false;
            CustomerLock = false;
            OrderLock = false;
            StockManagmentLock = false;
            dealLock = false;



        }

        private void report_PictureBox_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.ShowDialog();
        }

        
        #endregion

        #region Authentication  ✔
        private void authentication_pictureBox_Click(object sender, EventArgs e)
        {
            //getDataGrid.Show();
            this.BackgroundImage = Properties.Resources.AuthenticationForm;
            subMenueAuthenticaition.Show();
            subMenueAuthenticaition.BringToFront();
            subMenueFood.Hide();
            subMenueCustomer.Hide();
            subMenueStock.Hide();
            subMenueDeals.Hide();
        }
        #endregion
        #region Food   ✔
        private void food_PictureBox_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Food_Categories;
            subMenueFood.Show();
            subMenueFood.BringToFront();

            subMenueAuthenticaition.Hide();
            subMenueCustomer.Hide();
            subMenueStock.Hide();
            subMenueDeals.Hide();
        }
        #endregion
        #region Customer  ✔
        private void customer_PictureBox_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Customers;
            subMenueCustomer.Show();
            subMenueCustomer.BringToFront();

            subMenueAuthenticaition.Hide();
            subMenueFood.Hide();
            subMenueDeals.Hide();
            subMenueStock.Hide();
        }
        #endregion
        #region Stock
        private void stock_PictureBox_Click(object sender, EventArgs e)
        {
            subMenueStock.Show();
            subMenueStock.BringToFront();

            subMenueAuthenticaition.Hide();
            subMenueFood.Hide();
            subMenueCustomer.Hide();
            subMenueDeals.Hide();
        }
        #endregion

        private void deals_PictureBox_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Deals;
            subMenueDeals.Show();
            subMenueDeals.BringToFront();
            subMenueFood.Hide();
            subMenueCustomer.Hide();
            subMenueStock.Hide();
            subMenueAuthenticaition.Hide();
        }


      
    }
}

