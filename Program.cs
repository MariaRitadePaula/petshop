using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        bool continuar = true;
        PetShop pet = new PetShop(); // INSTANCIA O PETSHOP UMA VEZ

        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("=== Sistema de Cadastro de Animais ===");
            Console.WriteLine("1 - Cadastrar Gato");
            Console.WriteLine("2 - Cadastrar Cachorro");
            Console.WriteLine("3 - Cadastrar Vaca");
            Console.WriteLine("4 - Cadastrar Cavalo");
            Console.WriteLine("5 - Listar Animais");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Gato gato = new Gato();
                    Console.Write("Nome: ");
                    gato.Nome = Console.ReadLine();
                    Console.Write("Idade: ");
                    gato.Idade = int.Parse(Console.ReadLine());
                    Console.Write("Cor: ");
                    gato.cor = Console.ReadLine();
                    pet.AdicionarAnimal(gato);
                    break;

                case "2":
                    Cachorro cachorro = new Cachorro();
                    Console.Write("Nome: ");
                    cachorro.Nome = Console.ReadLine();
                    Console.Write("Idade: ");
                    cachorro.Idade = int.Parse(Console.ReadLine());
                    Console.Write("Raça: ");
                    cachorro.raca = Console.ReadLine();
                    pet.AdicionarAnimal(cachorro);
                    break;

                case "3":
                    Vaca vaca = new Vaca();
                    Console.Write("Nome: ");
                    vaca.Nome = Console.ReadLine();
                    Console.Write("Idade: ");
                    vaca.Idade = int.Parse(Console.ReadLine());
                    Console.Write("Cor: ");
                    vaca.cor = Console.ReadLine();
                    pet.AdicionarAnimal(vaca);
                    break;

                case "4":
                    Cavalo cavalo = new Cavalo();
                    Console.Write("Nome: ");
                    cavalo.Nome = Console.ReadLine();
                    Console.Write("Idade: ");
                    cavalo.Idade = int.Parse(Console.ReadLine());
                    Console.Write("Raça: ");
                    cavalo.raca = Console.ReadLine();
                    pet.AdicionarAnimal(cavalo);
                    break;

                case "5":
                    Console.Clear();
                    Console.WriteLine("=== Lista de Animais Cadastrados ===");
                    pet.ListarAnimais();
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    break;

                case "0":
                    continuar = false;
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }

        Console.WriteLine("Encerrando o programa...");
    }

    class Animal
    {
        public string Nome;
        public int Idade;

        public virtual void EmitirSom()
        {
            Console.WriteLine("Barulho genérico.");
        }

        public virtual void ExibirInfo()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }

    class Gato : Animal
    {
        public string cor;

        public override void EmitirSom()
        {
            Console.WriteLine("Miau");
        }

        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine($"Cor: {cor}");
        }
    }

    class Cachorro : Animal
    {
        public string raca;

        public override void EmitirSom()
        {
            Console.WriteLine("Au Au");
        }

        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine($"Raça: {raca}");
        }
    }

    class Vaca : Animal
    {
        public string cor;

        public override void EmitirSom()
        {
            Console.WriteLine("Muuu");
        }

        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine($"Cor: {cor}");
        }
    }

    class Cavalo : Animal
    {
        public string raca;

        public override void EmitirSom()
        {
            Console.WriteLine("Relinchar");
        }

        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine($"Raça: {raca}");
        }
    }

    class PetShop
    {
        List<Animal> Animais = new List<Animal>();

        public void AdicionarAnimal(Animal a)
        {
            Animais.Add(a);
        }

        public void ListarAnimais()
        {
            foreach (Animal a in Animais)
            {
                a.ExibirInfo();
                a.EmitirSom();
                Console.WriteLine();
            }
        }
    }
}
