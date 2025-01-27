
using PadroesDeProjetosCriacionais.PadraoAbstractFactory.Produto.FamiliaMac;
using PadroesDeProjetosCriacionais.PadraoAbstractFactory.Produto.Interfaces;

namespace PadroesDeProjetosCriacionais.PadraoAbstractFactory.Factory
{
    public class MacFactory : IGUIFactory
    {
        public IButton CriarButton()
        {
            return new MacButton();
        }

        public ICheckBox CriarCheckBox()
        {
            return new MacCheckBox();
        }
    }
}
