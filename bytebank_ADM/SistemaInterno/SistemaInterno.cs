using bytebank_ADM.Funcionarios;
using bytebank_ADM.SistemaInterno;

public class SistemaInterno
{
  public bool Logar(Autenticavel funcionario, string senha)
  {
    bool usuarioAutenticado = funcionario.Autenticar(senha);
    if (usuarioAutenticado)
    {
      Console.WriteLine("Boas-vindas ao nosso sistema.");
      return true;
    }
    else
    {
      Console.WriteLine("Senha incorreta!");
      return false;
    }
  }
}