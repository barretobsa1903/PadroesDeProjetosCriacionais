
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
