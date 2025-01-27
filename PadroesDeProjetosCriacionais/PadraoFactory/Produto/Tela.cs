
namespace PadroesDeProjetosCriacionais.PadraoFactory.Class
{
    public abstract class Tela
    {
        protected string Nome { get; }
        private readonly string CorDeFundo;

        public Tela(string nome, string corDeFundo) {
            Nome = nome;
            CorDeFundo = corDeFundo;
        }

        public string BuscarNome()
        {
            return Nome;
        }
    }
}
