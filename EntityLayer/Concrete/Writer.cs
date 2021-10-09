using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer //yazarlar sınıfı
    {
        public int WriterID { get; set; } //yazar ıd
        public string WriterName { get; set; } //yazar adı
        public string WriterAbout { get; set; } //yazar hakkında
        public string WriterImage { get; set; } // yazar resmi
        public string WriterMail { get; set; } // yazar mail
        public string WriterPassword { get; set; } // yazar parola
        public bool WriterStatus { get; set; } //yazar durumu
        public List<Blog> Blogs { get; set; }
    }
}
