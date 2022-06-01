using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao controle de estoque");

            bool stop = false;
            List<Product> productsList = new List<Product>();


            while (!stop)
            {
                Console.WriteLine("1 - Cadastrar Produto");
                Console.WriteLine("2 - Lista produtos");
                Console.WriteLine("3 - Editar Produto");
                Console.WriteLine("4 - Sair");

                Console.Write("Digite uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("\nCadastrar Produto\n");

                        Console.Write("Digite o nome do produto: ");
                        string nameProduct = Console.ReadLine();

                        Console.Write("Digite o nome da categoria: ");
                        string nameCategory = Console.ReadLine();

                        int newId = productsList.Count + 1;
                        Product newProduct = new Product(nameProduct, nameCategory, newId);

                        productsList.Add(newProduct);
                        Console.WriteLine("\nCadastrado com sucesso\n");
                        break;
                    case "2":
                        Console.WriteLine("\nListar Produto\n");

                        foreach(Product product in productsList)
                        {
                            Console.WriteLine($"Id: {product.Id} Produto: {product.Name} Categoria: {product.Category}");
                        }

                        //productsList.ForEach(product => {
                        //    Console.WriteLine("Id: " + product.Id);
                        //    Console.WriteLine("Nome: " + product.Name);
                        //    Console.WriteLine("Categoria: " + product.Category);     
                        //});

                        break;
                    case "3":
                        Console.WriteLine("\nEditar Produto\n");

                        Console.Write("Digite o ID do produto: ");
                        string id = Console.ReadLine();

                        int indexProdutc = productsList.FindIndex(product => product.Id.ToString() == id);

                        if (indexProdutc == -1)
                        {
                            Console.WriteLine("Produto não encontrado\n");
                        }
                        else
                        {
                            Console.Write("Digite o novo nome do produto: ");
                            string nameProductEdit = Console.ReadLine();

                            Console.Write("Digite o novo nome da categoria: ");
                            string nameCategoryEdit = Console.ReadLine();

                            productsList[indexProdutc].Name = nameProductEdit;
                            productsList[indexProdutc].Category = nameCategoryEdit;

                            Console.WriteLine("\nProduto editado com sucesso\n");
                        }

                        break;
                    case "4":
                        Console.WriteLine("\nSaindo...\n");
                        stop = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }


            Console.ReadLine();
        }
    }
}
