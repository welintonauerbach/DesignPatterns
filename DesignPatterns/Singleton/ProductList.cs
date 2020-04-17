using System.Collections.Generic;

namespace DesignPatterns.Singleton
{
    /// <summary>
    /// Classe de lista de produtos
    /// </summary>
    public sealed class ProductList
    {
        private static List<string> _products;
        private static ProductList _productListInstance;
        private static readonly object SyncOjb = new object();

        private ProductList()
        {
            _products = new List<string>();
        }

        /// <summary>
        /// Retorna única instância de ProductList
        /// </summary>
        /// <returns></returns>
        public static ProductList GetProductList()
        {
            // Verifica se a instância é nula
            if (_productListInstance != null) return _productListInstance;

            // Lock para Thread Safe
            lock (SyncOjb)
            {
                if (_productListInstance == null)
                    // ReSharper disable once PossibleMultipleWriteAccessInDoubleCheckLocking
                    _productListInstance = new ProductList();
            }
            
            return _productListInstance;
        }

        public void AddProduct(string name)
        {
            _products.Add(name);
        }

        public void RemoveProduct(string name)
        {
            _products.Remove(name);
        }

        public List<string> GetAllProduts()
        {
            return _products;
        }
        
    }
}