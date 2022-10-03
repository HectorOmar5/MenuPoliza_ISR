using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGeneral
{
    internal struct PolizaResultado
    {
        public PolizaResultado(DateTime FechaTermino, decimal Prima)
        {
            this.FechaTermino = FechaTermino;
            this.Prima = Prima;
        }
        public DateTime FechaTermino { get; set; }
        public decimal Prima { get; set; }
    }
}
