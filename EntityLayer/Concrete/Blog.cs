using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog //blog sınıfı
    {
        public int BlogID { get; set; } //blog Id
        public string BlogTitle { get; set; } //blog başlık
        public string BlogContent { get; set; } //blog içerik
        public string BlogThumbnailImage { get; set; } //blog küçük resim
        public string BlogImage { get; set; } //blog büyük resim
        public DateTime BlogCreateDate { get; set; } //blog oluşturulma zamanı
        public bool BlogStatus { get; set; } // blog durumu
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
