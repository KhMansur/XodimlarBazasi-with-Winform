using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XodimlarBazasi.Models
{
    public class Xodim
    {
        public int Id { get; set; }
        public string Fio { get; set; }
        public string Passport { get; set; }
        public DateTime TugilganSana { get; set; }
        public string Manzil { get; set; }
        public string Malumoti { get; set; }
        public string Mutaxasssislik { get; set; }
        public DateTime KirganSana { get; set; }
    }
}
