namespace CentraldeChamados
{
    using System;
    using System.Collections.Generic;

    abstract class Chamado
    {
        public string Titulo { get; private set; }
        protected Chamado(string titulo) => Titulo = titulo;
        public abstract void Atender();
    }

    abstract class Personagem : Chamado
    {
        public string Nome => Titulo;

        protected Personagem(string nome) : base(nome) { }

        public abstract void UsarHabilidade();

        public override void Atender()
        {
            UsarHabilidade();
        }
    }

    class Guerreiro : Personagem
    {
        public Guerreiro(string nome) : base(nome) { }

        public override void UsarHabilidade()
        {
            Console.WriteLine($"{Nome} ergue seu escudo e desfere uma **Investida Brutal**!");
        }
    }

    class Mago : Personagem
    {
        public Mago(string nome) : base(nome) { }

        public override void UsarHabilidade()
        {
            Console.WriteLine($"{Nome} canaliza mana e conjura uma **Bola de Fogo Destruidora**!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("========================================");
            Console.WriteLine("      🏰 BEM-VINDO À GUILDA DE HERÓIS 🏰");
            Console.WriteLine("========================================\n");

            Dictionary<string, Personagem> guilda = new Dictionary<string, Personagem>
        {
            { "G-001", new Guerreiro("Thorin Punho de Ferro") },
            { "M-001", new Mago("Elminster das Sombra") },
            { "G-002", new Guerreiro("Valeria Coração Valente") },
            { "M-002", new Mago("Lyra Sábia da Lua") }
        };

            Console.WriteLine($"Total de heróis registrados na guilda: {guilda.Count}\n");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("        CHAMADA DOS HEROIS EM AÇÃO");
            Console.WriteLine("----------------------------------------\n");

            foreach (KeyValuePair<string, Personagem> par in guilda)
            {
                string chave = par.Key;
                Personagem heroi = par.Value;

                Console.WriteLine($"🔑 Chave de Registro: {chave}");
                Console.WriteLine($"👤 Nome do Herói:     {heroi.Nome}");
                Console.Write($"⚡ Ação de Combate:   ");

                heroi.UsarHabilidade();

                Console.WriteLine("----------------------------------------");
            }

            Console.WriteLine("\n[Missão Concluída com Sucesso!]");
        }
    }

}
