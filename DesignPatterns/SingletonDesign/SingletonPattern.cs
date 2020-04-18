using System;

namespace DesignPatterns.SingletonDesign
{
    public static class SingletonPattern
    {
        /// <summary>
        /// Demonstra o uso do padrão singleton 
        /// </summary>
        public static void Singleton01()
        {
            // Variável pl para pegar a primeira instância
            var pl = ProductList.GetProductList();
            // Adicionando produtos na variável 01
            pl.AddProduct("Banana");
            pl.AddProduct("Melão");
            pl.AddProduct("Maçã");
            pl.AddProduct("Melancia");
            // Imprimindo lista de produtos através da variável 01
            Console.WriteLine("1 - Produtos da primeira variável");
            pl.GetAllProduts().ForEach(
                p => Console.WriteLine($"\tProdutos: {p}"));
            
            // Variável para pegar a instância de ProductList
            var pl2 = ProductList.GetProductList();
            // Adicionando produtos através da variável 02
            pl2.AddProduct("Rabanete");
            pl2.AddProduct("Cebola");
            pl2.AddProduct("Tomate");
            // Não gera lista de produtos...
            // para confirmar a inclusão será impresso usando outra variável que deverá conter estes produtos

            // Imprimindo lista de produtos através da variável 03
            Console.WriteLine("2 - Produtos da terceira variável");
            var pl3 = ProductList.GetProductList();
            pl3.GetAllProduts().ForEach(
                p => Console.WriteLine($"\tProdutos: {p}"));

        }

    }
}
