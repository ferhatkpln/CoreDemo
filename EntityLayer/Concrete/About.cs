using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About // hakkında sınıfı
    {
        public int AboutID { get; set; } //hakkında ıd
        public string AboutDetails1 { get; set; } //hakkında detay 1
        public string AboutDetails2 { get; set; } // hakkında detay 2
        public string AboutImage1 { get; set; } // hakkında resim 1
        public string AboutImage2 { get; set; } //hakkında resim 2
        public string AboutMapLocation { get; set; } //hakkında harita bilgisi
        public bool AboutStatus { get; set; } //hakkında durum
    }
}
