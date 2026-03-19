using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneWinForm;
internal class Kiralama : BaseEntity
{
    public int UyeId { get; set; }
    public int KitapId { get; set; }
    public DateTime BaslangicTarihi { get; set; }
    public DateTime TeslimTarihi { get; set; }
}
