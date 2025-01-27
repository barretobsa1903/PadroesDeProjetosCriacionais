
using PadroesDeProjetosCriacionais.PadraoAbstractFactory.Produto.Interfaces;

namespace PadroesDeProjetosCriacionais.PadraoAbstractFactory.Produto.FamiliaMac
{
    public class MacCheckBox : ICheckBox
    {
        public void Desenhar()
        {
            Console.WriteLine("CheckBox Mac");
        }
    }
}
