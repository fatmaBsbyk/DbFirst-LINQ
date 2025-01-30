namespace DBFirstProje.Web.Models
{
    public class ProductRepository
    {
        private static List<Product> _products;
        /*
        public List<Product> Products()
        {
            return _products;
        }
        */
        //yerine
        /// <summary>
        /// Veritabanındaki ürünleri getirir/listeler.
        /// </summary>
        /// <returns>_products</returns>
        public List<Product> Products() => _products;
        /// <summary>
        /// Listedeki ürünleri getirir
        /// </summary>
        /// <returns></returns>
        public List<Product> GetAll()
        {
            return _products;
        }
        /// <summary>
        /// Listeye ürün ekler.
        /// </summary>
        /// <param name="product">product</param>
        public void Add(Product product)
        {
            _products.Add(product);
        }
        /// <summary>
        /// listeden, verilen id ye sahip ürünü siler.
        /// </summary>
        /// <param name="id">int id</param>
        /// <exception cref="Exception"></exception>
        public void Remove(int id)
        {
            var hasProduct = _products.FirstOrDefault(p => p.Id == id);
            if (hasProduct == null)
                throw new Exception($"{id} nolu id ye sahip ürün bulunmamaktadır.");
            _products.Remove(hasProduct);
        }
        /// <summary>
        /// Listeden, verilen ürünün bilgilerini günceller.
        /// </summary>
        /// <param name="upt">Product upt</param>
        /// <exception cref="Exception"></exception>
        public void Update(Product upt)
        {
            var hasProduct = _products.FirstOrDefault(p => p.Id == upt.Id);
            if (hasProduct == null)
            {
                throw new Exception($"{upt.Id} nolu id ye sahip üürn bulunmamaktadır.");
            }
            //ya da
           // var hasProduct = _products.FirstOrDefault(p => p.Id == upt.Id)?? throw new Exception($"{upt.Id} nolu id ye sahip ürün bulunmamaktadır.");

            hasProduct.Name = upt.Name;
            hasProduct.Price = upt.Price;
            hasProduct.Stock = upt.Stock;
            hasProduct.ImageUrl = upt.ImageUrl;
            //sonradan eklendi
            hasProduct.Color = upt.Color;
            hasProduct.Width = upt.Width;
            hasProduct.Height = upt.Height;
            hasProduct.Description = upt.Description;
            //
            var index = _products.FindIndex(x => x.Id == upt.Id);
            _products[index] = hasProduct;
        }

    }
}
