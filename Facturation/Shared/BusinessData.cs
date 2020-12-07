using System;
using System.Collections.Generic;
using System.Text;

namespace Facturation.Shared
{
    public class BusinessData : IBusinessData
    {
        public IEnumerable<Facture> Factures => throw new NotImplementedException();
    }
}
