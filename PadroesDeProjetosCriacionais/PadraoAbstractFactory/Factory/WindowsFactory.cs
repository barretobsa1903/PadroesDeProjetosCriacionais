using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PadroesDeProjetosCriacionais.PadraoAbstractFactory.Produto;
using PadroesDeProjetosCriacionais.PadraoAbstractFactory.Produto.Interfaces;

namespace PadroesDeProjetosCriacionais.PadraoAbstractFactory.Factory
{
    public class WindowsFactory : IGUIFactory
    {
        public IButton CriarButton()
        {
            return new WindowsButton();
        }

        public ICheckBox CriarCheckBox()
        {
            return new WindowsCheckBox();
        }
    }
}
