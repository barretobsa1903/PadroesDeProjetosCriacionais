using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PadroesDeProjetosCriacionais.PadraoAbstractFactory.Produto.Interfaces;

namespace PadroesDeProjetosCriacionais.PadraoAbstractFactory.Produto.FamiliaMac
{
    public class MacButton : IButton
    {
        public void Desenhar()
        {
            Console.WriteLine("Button do mMac");
        }
    }
}
