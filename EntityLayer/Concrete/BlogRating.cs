using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class BlogRating
    {
        public int ID { get; set; }
        public int BlogID { get; set; }
        public int BlogScore { get; set; }
        public int BlogRatingCount { get; set; }
    }
}
