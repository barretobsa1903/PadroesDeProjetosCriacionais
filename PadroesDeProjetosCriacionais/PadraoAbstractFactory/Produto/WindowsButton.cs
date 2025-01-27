using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PadroesDeProjetosCriacionais.PadraoAbstractFactory.Produto.Interfaces;

namespace PadroesDeProjetosCriacionais.PadraoAbstractFactory.Produto
{
    public class WindowsButton : IButton
    {
        public void Desenhar()
        {
            Console.WriteLine("Button windows");
        }
    }
}
