
// ====================== FACTORY ==============================

//using PadroesDeProjetosCriacionais.PadraoFactory.Class;
//using PadroesDeProjetosCriacionais.PadraoFactory.Criador;

//Tela tela1 = new CriadorConcretoTelaCelular().TelaFactory();
//Tela tela2 = new CriadorConcretoTelaSmartTV().TelaFactory();
//Tela tela3 = new CriadorConcretoTelaWeb().TelaFactory();

//Console.WriteLine("Tela de celular : " + tela1.BuscarNome());

//Console.WriteLine("Tela de Smart TV :" + tela2.BuscarNome());

//Console.WriteLine("Tela de Web : " + tela3.BuscarNome());

// ========================== ABSTRACT FACTORY =====================


using PadroesDeProjetosCriacionais.PadraoAbstractFactory.Factory;

IGUIFactory factory;

factory = new WindowsFactory();

factory.CriarButton().Desenhar();
factory.CriarCheckBox().Desenhar();


factory = new MacFactory();

factory.CriarButton().Desenhar();
factory.CriarCheckBox().Desenhar();