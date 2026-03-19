using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneWinForm;

public class YazarDto
{
    public int Id { get; set; }
    public string Adi { get; set; }
    public string Soyadi { get; set; }
    public string Deneme { get; set; }

    public string FullName
    {
        get
        {
            return Adi + " " + Soyadi;
        }
    }
}
