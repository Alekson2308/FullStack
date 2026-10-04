namespace IEnumerable
{
    internal class Program
    {
        static void Main()
        {
            List<string> alunos = new List<string>
        {
            "Maria",
            "João",
            "Ana",
            "Carlos"
        };

            IEnumerable<string> listaAlunos = alunos;

            Console.WriteLine("Alunos:");

            foreach (string aluno in listaAlunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}