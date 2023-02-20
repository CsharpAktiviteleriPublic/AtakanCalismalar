using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_RandomFutbolTakim
{
    public interface IRefleks
    {
        int Refleks { get; set; }
        int Kalecilik { get; set; }
        int Degaj { get; set; }
        int Esneklik { get; set; }
        int Atlama { get; set; }
        int OyunBaslatma { get; set; }
    }
}
