using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryPattern
{
    public class InvoiceType2:IInvoice
    {
        public void Print()
        {
            Debug.WriteLine("inside invoice type2");
        }
    }
}
