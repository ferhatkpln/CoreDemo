using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment // yorum sınıfı
    {
        public int CommentID { get; set; } //yorum ıd
        public string CommentUserName { get; set; } // yorumu yapan kullanıcı
        public string CommentTitle { get; set; } // yorum başlık
        public string CommentContent { get; set; } // yorum içerik
        public DateTime CommentCreateDate { get; set; } // yorum oluşturulma zamanı
        public bool CommentStatus { get; set; } // yorum durumu
        public int BlogID { get; set; }
        public Blog Blog { get; set; }

    }
}
