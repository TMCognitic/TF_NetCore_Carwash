using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF_NetCore_Carwash
{
    internal class Voiture
    {
        public string Plaque { get; init; }

        public Voiture(string plaque)
        {
            Plaque = plaque;
        }
    }
}
