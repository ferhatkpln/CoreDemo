using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact // iletişim sınıfı
    {
        public int ContactID { get; set; } //mesaj ıd
        public string ContactUserName { get; set; } //mesaj gönderen kişi
        public string ContactUserMail { get; set; } //mesaj gönderen mail
        public string ContactSubject { get; set; } //mesaj başlık
        public string ContactMessage { get; set; } //mesaj içerik
        public DateTime ContactCreateDate { get; set; } //mesaj oluşturulma zamanı
        public bool ContactStatus { get; set; } //mesaj durumu
    }
}
