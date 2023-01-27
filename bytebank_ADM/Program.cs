using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;

#region 
// Funcionario pedro = new Funcionario("123451234", 2000);
// pedro.Nome = "Pedro Henrique";

// System.Console.WriteLine(pedro.Nome);
// System.Console.WriteLine(pedro.GetBonificacao());

// Diretor roberta = new Diretor("543211234");
// roberta.Nome = "Roberta Arcoverde";

// System.Console.WriteLine(roberta.Nome);
// System.Console.WriteLine(roberta.GetBonificacao());

// GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
// gerenciador.Registrar(pedro);
// gerenciador.Registrar(roberta);

// pedro.AumentarSalario();
// roberta.AumentarSalario();

// System.Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacao);
// System.Console.WriteLine("Total de funcionarios:" + Funcionario.TotalDeFuncionarios);

// System.Console.WriteLine("Novo salario do Pedro é " + pedro.Salario);
// System.Console.WriteLine("Novo salario da Roberta é " + roberta.Salario);
#endregion
//CalcularBonificacao();
UsarSistema();

void CalcularBonificacao()
{
  GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

  Designer cintia = new Designer("123456");
  cintia.Nome = "Cintia Maria";

  Diretor bianca = new Diretor("111111");
  bianca.Nome = "Bianca Castro";

  GerenteDeContas miguel = new GerenteDeContas("111222");
  miguel.Nome = "Miguel Santos";

  Auxiliar luiz = new Auxiliar("222222");
  luiz.Nome = "Luiz Santos";

  gerenciador.Registrar(cintia);
  gerenciador.Registrar(bianca);
  gerenciador.Registrar(miguel);
  gerenciador.Registrar(luiz);

  System.Console.WriteLine("Total de Bonificação = " + gerenciador.TotalDeBonificacao);
}

void UsarSistema()
{
  SistemaInterno sistema = new SistemaInterno();

  Diretor ingrid = new Diretor("543235");
  ingrid.Nome = "Ingrid Novaes";
  ingrid.Senha = "123";

  GerenteDeContas chico = new GerenteDeContas("554667");
  chico.Nome = "Chico Buarque";
  chico.Senha = "321";

  sistema.Logar(ingrid, "123");
  sistema.Logar(chico, "123");
}