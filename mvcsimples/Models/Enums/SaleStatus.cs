using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvcsimples.Models.Enums
{
    public enum SaleStatus : int
    {//1 - pendente, 2 - faturado, 3 - cancelado

        Pending = 0,
        Billed = 1,
        Canceled = 2
    }
}
