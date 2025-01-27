using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PadroesDeProjetosCriacionais.PadraoAbstractFactory.Produto.Interfaces;

namespace PadroesDeProjetosCriacionais.PadraoAbstractFactory.Produto
{
    public class WindowsCheckBox : ICheckBox
    {
        public void Desenhar()
        {
            Console.WriteLine("CheckBox Windows");
        }
    }
}
