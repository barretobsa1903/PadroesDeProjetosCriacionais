

using PadroesDeProjetosCriacionais.PadraoFactory.Class;
using PadroesDeProjetosCriacionais.PadraoFactory.Criador;

Tela tela1 = new CriadorConcretoTelaCelular().TelaFactory();
Tela tela2 = new CriadorConcretoTelaSmartTV().TelaFactory();
Tela tela3 = new CriadorConcretoTelaWeb().TelaFactory();

Console.WriteLine("Tela de celular : " + tela1.BuscarNome());

Console.WriteLine("Tela de Smart TV :" + tela2.BuscarNome());

Console.WriteLine("Tela de Web : " + tela3.BuscarNome());