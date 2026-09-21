namespace ListaTarefas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> tarefas = new List<string>();
            int opcao = -1;
            while (opcao != 0)
            {
                Console.WriteLine("1 - Adicionar tarefa");
                Console.WriteLine("2 - Listar tarefas");
                Console.WriteLine("3 - Apagar tarefa");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha: ");
                opcao = int.Parse(Console.ReadLine());
                if (opcao == 1)
                {
                    Console.WriteLine("Digite a tarefa: ");
                    string tarefa = Console.ReadLine();
                    AdicionarTarefa(tarefas, tarefa);
                    Console.WriteLine("Tarefa adicionada!");
                }
                else if (opcao == 2)
                {
                    ListarTarefas(tarefas);
                }
                else if (opcao == 3)
                {
                    RemoveAt(tarefas);
                }
                else if (opcao != 0)
                {
                    Console.WriteLine("Opção inválida.");
                }
            }
            static void AdicionarTarefa(List<string> tarefas, string tarefa)
            {
                tarefas.Add(tarefa);
            }
            static void ListarTarefas(List<string> tarefas)
            {
                if (tarefas.Count == 0)
                {
                    Console.WriteLine("Nenhuma tarefa cadastrada.");
                    return;
                }
                for (int i = 0; i < tarefas.Count; i++)
                {
                    Console.WriteLine($"{i + 1} - {tarefas[i]}");
                }
            }
            static void RemoveAt(List<string> tarefas)
            {
                if (tarefas.Count == 0)
                {
                    Console.WriteLine("Nenhuma tarefa para apagar.");
                    return;
                }

                ListarTarefas(tarefas);

                Console.WriteLine("Digite o número da tarefa que deseja apagar: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero >= 1 && numero <= tarefas.Count)
                {
                    tarefas.RemoveAt(numero - 1);
                    Console.WriteLine("Tarefa apagada!");
                }
                else
                {
                    Console.WriteLine("Número de tarefa inválido.");
                }
            }
        }
    }
}