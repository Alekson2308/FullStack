namespace Matematica
{
    internal class Program
    {
        static class MatematicaUtil
        {
            public static int Quadrado(int numero)
            {
                return numero * numero;
            }

            public static int Cubo(int numero)
            {
                return numero * numero * numero;
            }

            public static long Fatorial(int numero)
            {
                if (numero < 0)
                    throw new ArgumentException("O número não pode ser negativo.");

                long resultado = 1;

                for (int i = 1; i <= numero; i++)
                {
                    resultado *= i;
                }

                return resultado;
            }
        }

        class Usuario
        {
            private string senha = "";

            public void DefinirSenha(string novaSenha)
            {
                senha = novaSenha;
            }

            public bool ValidarSenha(string senhaDigitada)
            {
                return senha == senhaDigitada;
            }
        }

        class Animal
        {
            protected string Especie = "Não definida";
        }

        class Cachorro : Animal
        {
            public void MostrarEspecie()
            {
                Especie = "Canina";
                Console.WriteLine("Espécie: " + Especie);
            }
        }

        class Contador
        {
            public static int TotalCriados = 0;

            public Contador()
            {
                TotalCriados++;
            }
        }

        static class Calculadora
        {
            public static int Dobro(int numero)
            {
                return numero * 2;
            }
        }

        class Programa
        {
            static void Main(string[] args)
            {
                Console.WriteLine("=== MatematicaUtil ===");
                Console.WriteLine("Quadrado de 4: " + MatematicaUtil.Quadrado(4));
                Console.WriteLine("Cubo de 3: " + MatematicaUtil.Cubo(3));
                Console.WriteLine("Fatorial de 5: " + MatematicaUtil.Fatorial(5));

                Console.WriteLine("\n=== Usuario ===");
                Usuario usuario = new Usuario();
                usuario.DefinirSenha("12345");

                Console.WriteLine(
                    "Senha correta: " + usuario.ValidarSenha("12345"));

                Console.WriteLine(
                    "Senha incorreta: " + usuario.ValidarSenha("00000"));

                Console.WriteLine("\n=== Animal ===");
                Cachorro cachorro = new Cachorro();
                cachorro.MostrarEspecie();

                Console.WriteLine("\n=== Contador ===");
                Contador c1 = new Contador();
                Contador c2 = new Contador();
                Contador c3 = new Contador();

                Console.WriteLine("Objetos criados: " + Contador.TotalCriados);

                Console.WriteLine("\n=== Calculadora ===");
                Console.WriteLine("Dobro de 10: " + Calculadora.Dobro(10));
            }
        }
    }
}
