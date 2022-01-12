﻿using Spinzer_Managment_System__4._12_V_.View.Grid.Cards;
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

namespace Spinzer_Managment_System__4._12_V_.View.Grid.Base
{
    public partial class GetCategoryDataGrid : UserControl
    {
        List<ShowCategory> showCategories;
        CategoriesViewModel categoriesViewModel;
        private int start = 0, ends = 8, length = 0,limit =8;
      
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }
        
        public GetCategoryDataGrid()
        {
            
            InitializeComponent();
            loadInitialize();
        }
        private void loadInitialize()
        {
            start = 0; ends = 8; length = 0;
            showCategories = new List<ShowCategory>();
            categoriesViewModel = new CategoriesViewModel();
            gettingExtensionData();
        }

        private void forward_Picturebox_MouseDown(object sender, MouseEventArgs e)
        {
            if (ends >= length) return;
            int cal = length - ends;
            if (cal < limit)
            {
                start = ends;
                ends += cal;
            }
            else
            {
                start += 8;
                ends += 8;
            }

            gettingExtensionData();
            loadGrid();
        }

        private void backward_PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (start == 0) return;
            if (ends == length)
            {
                ends = start;
                start -= 8;
            }
            else
            {
                start -= 8;
                ends -= 8;
            }
            gettingExtensionData();
            loadGrid();
        }
        private void gettingExtensionData()
        {
            length = categoriesViewModel.fillingData();
            for (int i = 0; i < length; i++)
            {
                showCategories.Add(new ShowCategory());
                showCategories[i].id_label.Text = categoriesViewModel.catModel.dataCat[i].CategoriesID.ToString();
                showCategories[i].categoryName_Label.Text = categoriesViewModel.catModel.dataCat[i].CategoriesName;
                showCategories[i].avaulability_Label.Text = categoriesViewModel.catModel.dataCat[i].Availibilty;

                showCategories[i].update_PictureBox.Click += Update_PictureBox_Click;
                showCategories[i].delete_PictureBox.Click += Delete_PictureBox_Click;
            }


            loadGrid();
        }

        private void Delete_PictureBox_Click(object sender, EventArgs e)
        {
            loadInitialize();
        }

        private void Update_PictureBox_Click(object sender, EventArgs e)
        {
            loadInitialize();

        }

        private void loadGrid()
        {
            int index = 0;
            if (length < ends)
            {

                index = length;
            }
            else
            {
                index = ends;
            }

            range_Label.Text = start + " . . . " + ends;
            flowLayoutPanel1.Controls.Clear();
            for (int i = start; i < index; i++)
            {
                flowLayoutPanel1.Controls.Add(showCategories[i]);
            }
        }
    }
}
