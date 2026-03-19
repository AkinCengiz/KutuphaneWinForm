using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneWinForm;
internal class Yazar : BaseEntity
{
    public string Adi { get; set; }
    public string Soyadi { get; set; }
    public DateTime DogumYili { get; set; }
    public string DogumYeri { get; set; }
    public List<Kitap> Kitaplar { get; set; }
}
