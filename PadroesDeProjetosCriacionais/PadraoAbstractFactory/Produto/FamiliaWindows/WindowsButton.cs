
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
