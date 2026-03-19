using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneWinForm;
internal class Kitap : BaseEntity
{
    public string Baslik { get; set; }
    public int BasimYili { get; set; }
    public int SayfaSayisi { get; set; }
    public byte Stok { get; set; }
    public int YazarId { get; set; }
    public bool VarMi { get; set; } = true;
    public Yazar Yazar { get; set; }
}
