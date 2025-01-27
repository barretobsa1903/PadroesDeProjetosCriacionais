using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PadroesDeProjetosCriacionais.PadraoAbstractFactory.Produto.Interfaces;

namespace PadroesDeProjetosCriacionais.PadraoAbstractFactory.Factory
{
    public interface IGUIFactory
    {
        public IButton CriarButton();
        public ICheckBox CriarCheckBox();
    }
}
