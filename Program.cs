using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio_individual_Tema_Loja_de_Produtos_Polimorfismo_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ProdutoComum> produtos = new List<ProdutoComum>(); //Lista para adcionar todos os produtos
            Console.Write("Entre com número de produtos: ");
            int nProdutos = int.Parse(Console.ReadLine()); //Pede o numero de produtos a ser adcionado
            for (int i = 1; i <= nProdutos; i++) // For para repitir a solicitação de dados dos produtos de acordo com o numero inserido pelo usuario
            {
                Console.Write("PRODUTO #" + i + " :Comum, Usado ou Importado (C/U/I)? "); //Tipo de produto
                char tipo = char.Parse(Console.ReadLine());
                Console.Write("Nome: "); //Nome do produto
                string nome = Console.ReadLine();
                Console.Write("Preço: "); //Preço do produto
                double preco = double.Parse(Console.ReadLine());
                if (tipo == 'U') //Se for usado entra nesse if para adcionar os dados ao produto
                {
                    Console.Write("Fabricação (DD/MM/AAAA): "); //Data de fabricação do produto
                    DateTime fabricacao = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    produtos.Add(new ProdutoUsado(nome, preco, fabricacao)); //Adiciona na lista o novo produtos com seus dados
                }
                else if (tipo == 'I') //Se for importado entra nesse if para adcionar os dados ao produto
                {
                    Console.Write("Taxa: "); //Taxa do produto
                    double taxa = double.Parse(Console.ReadLine());
                    produtos.Add(new ProdutoImportados(nome, preco, taxa)); //Adiciona na lista o novo produtos com seus dados
                }
                else //Se for comum entra nesse if para adcionar os dados ao produto
                {
                    produtos.Add(new ProdutoComum(nome, preco)); //Adiciona na lista o novo produtos com seus dados
                }
            }
            Console.WriteLine(); //Pula linha
            Console.WriteLine("Etiquetas:"); //Imprime a etiqueta de todos os produtos
            foreach (ProdutoComum produto in produtos)
            {
                Console.WriteLine(produto.etiqueta());
            }
            Console.ReadKey();
        }
    }
}
