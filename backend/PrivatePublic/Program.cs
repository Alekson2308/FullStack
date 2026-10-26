namespace PrivatePublic
{
    internal class Classe
    {
        private string mensagem = "Veja a conta";

        public void Mensagem()
        {
            Console.WriteLine(mensagem);
        }

        public static int Soma(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Classe objeto = new Classe();

            objeto.Mensagem();

            int resultado = Classe.Soma(180, 180);

            Console.WriteLine("Resultado da soma: " + resultado);
        }
    }
}