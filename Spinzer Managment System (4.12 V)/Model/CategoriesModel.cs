using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spinzer_Managment_System__4._12_V_.Model
{
    public class DatatoCatModel
    {
        public List<CategoriesModel> dataCat { get; set; }
    }
    public class CategoriesModel
    {
        private int catID;

        public int CategoriesID
        {
            get { return catID; }
            set { catID = value; }
        }
        private string categoriesName;

        public string CategoriesName
        {
            get { return categoriesName; }
            set { categoriesName = value; }
        }

        private string availibilty;
                
        public string Availibilty
        {
            get { return availibilty; }
            set { availibilty = value; }
        }


    }
}
