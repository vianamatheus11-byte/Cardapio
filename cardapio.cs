using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {


        List<string> hamburguer = new List<string> { };
        List<string> pizza = new List<string> { };
        List<string> bebidas = new List<string> { };
        List<string> sobremesas = new List<string> { };

        int opcao = -1;
        while (opcao != 0)
        {
            Console.Clear();
            Console.WriteLine("MENU DE OPÇÕES");

            Console.WriteLine("1. Adicionar Item");
            Console.WriteLine("2. Remover Item");
            Console.WriteLine("3. Mostrar Cardápio");
            Console.WriteLine("0. Sair");


            opcao = int.Parse(Console.ReadLine());


            if (opcao == 1)
            {
                Console.Clear();
                Console.WriteLine("Nome do item: ");
                string item = Console.ReadLine();

                Console.WriteLine("Em qual categoria adicionar? ");
                Console.WriteLine("1. Hamburguer");
                Console.WriteLine("2. Pizza");
                Console.WriteLine("3. Bebidas");
                Console.WriteLine("4. Sobremesas");

                int categoria = int.Parse(Console.ReadLine());

                if (categoria == 1)
                {
                    hamburguer.Add(item);
                }
                else if (categoria == 2)
                {
                    pizza.Add(item);
                }
                else if (categoria == 3)
                {
                    bebidas.Add(item);
                }
                else if (categoria == 4)
                {
                    sobremesas.Add(item);

                }
                Console.WriteLine("Item adicionado com sucesso!");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }

            if (opcao == 2)
            {
                Console.Clear();
                Console.WriteLine("Em qual categoria remover? ");
                Console.WriteLine("1. Hamburguer");
                Console.WriteLine("2. Pizza");
                Console.WriteLine("3. Bebidas");
                Console.WriteLine("4. Sobremesas");
                int categoria = int.Parse(Console.ReadLine());
                if (categoria == 1)
                {
                    Console.WriteLine("Nome do item: ");
                    string item = Console.ReadLine();
                    hamburguer.Remove(item);

                }
                else if (categoria == 2)
                {
                    Console.WriteLine("Nome do item: ");
                    string item = Console.ReadLine();
                    pizza.Remove(item);
                }
                else if (categoria == 3)
                {
                    Console.WriteLine("Nome do item: ");
                    string item = Console.ReadLine();
                    bebidas.Remove(item);
                }
                else if (categoria == 4)
                {
                    Console.WriteLine("Nome do item: ");
                    string item = Console.ReadLine();
                    sobremesas.Remove(item);
                }
                Console.WriteLine("Item removido com sucesso!");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }


            if (opcao == 3)
            {
                
                Console.WriteLine("Cardápio");
                Console.WriteLine("---------");

                Console.WriteLine("Hamburguer: ");
                foreach (string item in hamburguer)
                {
                   Console.WriteLine(item);
                }
                Console.WriteLine("Pizza: ");
                foreach (string item in pizza)
                {
                    Console.WriteLine(item);
                }
            
                Console.WriteLine("Bebidas: ");
                foreach (string item in bebidas)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("Sobremesas: ");
                foreach (string item in sobremesas)
                {
                    Console.WriteLine(item);

                }
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();

            }
        }
    }

}



