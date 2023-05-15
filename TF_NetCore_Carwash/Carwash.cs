using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF_NetCore_Carwash
{
    internal class Carwash
    {
        CarwashHandler _handler;

        public Carwash()
        {
            _handler += delegate (Voiture v) { Console.WriteLine($"Je prépare la voiture {v.Plaque}"); };
            _handler += delegate (Voiture v) { Console.WriteLine($"Je lave la voiture {v.Plaque}"); };
            _handler += delegate (Voiture v) { Console.WriteLine($"Je sèche la voiture {v.Plaque}"); };
            _handler += delegate (Voiture v) { Console.WriteLine($"Je finalise la voiture {v.Plaque}"); };

            //_handler += (v) => Console.WriteLine($"Je prépare la voiture {v.Plaque}");
            //_handler += (v) => Console.WriteLine($"Je lave la voiture {v.Plaque}");
            //_handler += (v) => Console.WriteLine($"Je sèche la voiture {v.Plaque}");
            //_handler += (v) => Console.WriteLine($"Je finalise la voiture {v.Plaque}");
        }

        //private void Preparer(Voiture v)
        //{
        //    Console.WriteLine($"Je prépare la voiture {v.Plaque}");
        //}

        //private void Laver(Voiture v)
        //{
        //    Console.WriteLine($"Je lave la voiture {v.Plaque}");
        //}

        //private void Secher(Voiture v)
        //{
        //    Console.WriteLine($"Je sèche la voiture {v.Plaque}");
        //}

        //private void Finaliser(Voiture v)
        //{
        //    Console.WriteLine($"Je finalise la voiture {v.Plaque}");
        //}

        public void Traiter(Voiture v)
        {
            _handler?.Invoke(v);
        }

    }
}
