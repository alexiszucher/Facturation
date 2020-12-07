using System;
using System.Collections.Generic;
using System.Text;

namespace Facturation.Shared
{
    public class Facture
    {
        private Client client;
        private int numero;
        private DateTime dateEmission;
        private DateTime dateReglementAttendu;
        private float montantDu;
        private float montantRegle;
    }
}
