namespace listaAlunos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                List<string> alunos = new List<string>();

                alunos.Add("Maria");
                alunos.Add("João");
                alunos.Add("Ana");

                Console.WriteLine("Primeiro aluno: " + alunos[0]);

                Console.WriteLine("Quantidade de alunos: " + alunos.Count);

                Console.WriteLine("==================================");

                bool existeAna = alunos.Contains("Ana");
                Console.WriteLine("Ana está na lista? " + existeAna);

                int posicaoAna = alunos.IndexOf("Ana");
                Console.WriteLine("Posição da Ana: " + posicaoAna);

                int indiceJoao = alunos.FindIndex(aluno => aluno == "João");
                Console.WriteLine("Índice do João: " + indiceJoao);

                Console.WriteLine("==================================");

                alunos.Sort();

                Console.WriteLine("\nLista ordenada:");
                foreach (string aluno in alunos)
                {
                    Console.WriteLine(aluno);
                }

                Console.WriteLine("==================================");

                alunos.Reverse();

                Console.WriteLine("\nLista invertida:");
                foreach (string aluno in alunos)
                {
                    Console.WriteLine(aluno);
                }

                Console.WriteLine("==================================");

                alunos.Remove("João");

                Console.WriteLine("\nDepois de remover João:");
                foreach (string aluno in alunos)
                {
                    Console.WriteLine(aluno);
                }

                alunos.RemoveAt(0);

                Console.WriteLine("\nDepois de remover o índice 0:");
                foreach (string aluno in alunos)
                {
                    Console.WriteLine(aluno);
                }

                alunos.Insert(0, "Carlos");

                Console.WriteLine("\nDepois de inserir Carlos:");
                foreach (string aluno in alunos)
                {
                    Console.WriteLine(aluno);
                }

                alunos.Clear();

                Console.WriteLine("\nLista depois do Clear:");
                Console.WriteLine("Quantidade de alunos: " + alunos.Count);
            }
        }
    }
}
