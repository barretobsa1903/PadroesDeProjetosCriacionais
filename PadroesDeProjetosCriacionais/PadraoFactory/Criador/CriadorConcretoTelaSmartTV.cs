
using PadroesDeProjetosCriacionais.PadraoFactory.Class;
using PadroesDeProjetosCriacionais.PadraoFactory.Produto;

namespace PadroesDeProjetosCriacionais.PadraoFactory.Criador
{
    public class CriadorConcretoTelaSmartTV : TelaCriador
    {
        public override Tela TelaFactory()
        {
            return new TelaSmartTV();
        }
    }
}
