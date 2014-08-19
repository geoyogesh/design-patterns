using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryPattern
{
    public class InvoiceFactory
    {
        static public IInvoice GetInvoice(String type)
        {
            switch (type)
            {
                case "1":
                    return new InvoiceType1();
                case "2":
                    return new InvoiceType2();
                default:
                    return null;
            }
        }
    }
}
