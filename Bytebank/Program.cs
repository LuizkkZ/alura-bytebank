using Bytebank.Conta;
using Bytebank.Titular;

// ContaCorrente contaDoAndre = new ContaCorrente();
// contaDoAndre.titular = "André Silva";
// contaDoAndre.numero_agencia = 15;
// contaDoAndre.conta = "1010-x";
// contaDoAndre.saldo = 100;
// System.Console.WriteLine("Saldo da conta do Andre =" + contaDoAndre.saldo);

// ContaCorrente contaDoAndre2 = new ContaCorrente();
// contaDoAndre2.titular = "André Silva";
// contaDoAndre2.numero_agencia = 15;
// contaDoAndre2.conta = "1010-x";
// contaDoAndre2.saldo = 100;
// System.Console.WriteLine("Saldo da conta do Andre =" + contaDoAndre2.saldo);

// System.Console.WriteLine(contaDoAndre == contaDoAndre2);

// System.Console.WriteLine("Saldo da conta do André = " + contaDoAndre.saldo);

// ContaCorrente contaDaMaria = new ContaCorrente();
// contaDaMaria.titular = "Maria Souza";
// contaDaMaria.numero_agencia = 17;
// contaDaMaria.conta = "1010-5";
// contaDaMaria.saldo = 350;

// System.Console.WriteLine("Saldo na conta da Maria = " + contaDaMaria.saldo);

// contaDoAndre.Transferir(50, contaDaMaria);
// System.Console.WriteLine("Saldo do Andre = " + contaDoAndre.saldo);
// System.Console.WriteLine("Saldo da Maria = " + contaDaMaria.saldo);

// ContaCorrente contaDoPedro = new ContaCorrente();
// contaDoPedro.titular = "Pedro Silva";
// System.Console.WriteLine(contaDoPedro.titular);
// System.Console.WriteLine(contaDoPedro.saldo);
// System.Console.WriteLine(contaDoPedro.numero_agencia);
// System.Console.WriteLine(contaDoPedro.conta);

// double valor = 300;
// double valor2 = valor;

// System.Console.WriteLine(valor == valor2);

//ContaCorrente conta = new ContaCorrente();

// Cliente cliente = new Cliente();
// cliente.nome = "Luiz Santos";
// cliente.cpf = "123456789";
// cliente.profissao = "Back-end Developer";

// ContaCorrente conta = new ContaCorrente();
// conta.titular = cliente;
// conta.conta = "1010-X";
// conta.numero_agencia = 15;
// conta.saldo = 100;

// System.Console.WriteLine("Titular = " + conta.titular.nome);
// System.Console.WriteLine("CPF = " + conta.titular.cpf);
// System.Console.WriteLine("Profissão = " + conta.titular.profissao);
// System.Console.WriteLine("Numero da conta = " + conta.conta);
// System.Console.WriteLine("Saldo = " + conta.saldo);
// System.Console.WriteLine("Numero Agencia = " + conta.numero_agencia);

// ContaCorrente conta2 = new ContaCorrente();
// conta2.titular = new Cliente();
// conta2.titular.nome = "Cintia Maria";
// conta2.titular.cpf = "098763741";
// conta2.titular.profissao = "Analista de RH";
// conta2.conta = "9999-X";
// conta2.numero_agencia = 18;
// conta2.saldo = 500;

// System.Console.WriteLine(conta2.titular.nome);

// ContaCorrente conta3 = new ContaCorrente();
// conta3.Numero_agencia = 18;
// conta3.SetSaldo(1000000);
// conta3.Conta = "0801-J";

// System.Console.WriteLine(conta3.GetSaldo());
// System.Console.WriteLine(conta3.Numero_agencia);
// System.Console.WriteLine(conta3.Conta);

// ContaCorrente conta4 = new ContaCorrente(18, "1010-X");
// conta4.SetSaldo(500);
// conta4.Titular = new Cliente();

ContaCorrente conta5 = new ContaCorrente(283, "1234-X");
System.Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
ContaCorrente conta6 = new ContaCorrente(284, "9874-Z");
System.Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
ContaCorrente conta7 = new ContaCorrente(284, "3564-u");
System.Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
