using System;

class Program
{
    static void Main()
    {
        string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%";
        Random random = new Random();

        Console.Write("Digite o tamanho da senha: ");
        int tamanho = int.Parse(Console.ReadLine());

        string senha = "";

        for (int i = 0; i < tamanho; i++)
        {
            int indice = random.Next(caracteres.Length);
            senha += caracteres[indice];
        }

        Console.WriteLine("\nSenha gerada: " + senha);
    }
}
