public class ProductService
{
    private readonly IRepository<Product> _repo;

    public ProductService(IRepository<Product> repo)
    {
        _repo = repo;
    }

    public Product GetProduct(int id)
    {
        return _repo.GetById(id);
    }
}