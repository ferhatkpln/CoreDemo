using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category //kategori sınıfı
    {
        public int CategoryID { get; set; } //kategori Id
        public string CategoryName { get; set; } // kategori adı
        public string CategoryDescription { get; set; } // kategori tanımı
        public bool CategoryStatus{ get; set; } // kategori durumu
        public List<Blog> Blogs { get; set; }
    }
}
