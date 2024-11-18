using Gestão_Bancária;

ContaCorrente C = new ContaCorrente("Edson", 100, 100);
ContaPoupanca c = new ContaPoupanca("Claudio", 200, 0.1);

GestaoContas ger = new GestaoContas();
ger.Adicionar(c);
ger.Adicionar(C);
ger.Listar();


c.Transferir(100, C);

ger.Listar();
