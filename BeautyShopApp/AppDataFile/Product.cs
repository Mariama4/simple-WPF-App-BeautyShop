using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyShopApp.AppDataFile
{
    public class Product
    {
        public static int id { get; set; }

        public static string Title { get; set; }

        public static int Cost { get; set; }

        public static string Description { get; set; }

        public static bool IsActive { get; set; }

        public static int ManufactureID { get; set; }
    }
}
