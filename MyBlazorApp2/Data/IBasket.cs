namespace MyBlazorApp2.Data
{
    public interface IBasket
    {
        public List<Product> GetProducts();
        void AddProductToBasket(Product product);

        void DeleteProductFromBasket(Product product);

        void ClearAllBasket();
        
    }
}
