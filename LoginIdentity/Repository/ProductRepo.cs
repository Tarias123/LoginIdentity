
using LoginIdentity.Models;
using LoginIdentity.Repository.IProductRepo;

namespace LoginIdentity.Repository 
{
    public class ProductRepo : IProdRepo
    {
        private readonly Data.AppDbContext _db;
        public ProductRepo(Data.AppDbContext db)
        {
            _db = db;
        }

        public bool CreateProducto(Producto producto)
        {
            _db.Productos.Add(producto);
            return Save();
        }

        public bool DeleteProducto(Producto producto)
        {
            _db.Productos.Remove(producto);
            return Save();
        }

        public Producto GetProducto(int productoId)
        {
            return _db.Productos.Find(productoId);
        }

        public ICollection<Producto> GetProductos()
        {
            return _db.Productos.OrderBy(p => p.Nombre).ToList();
        }

        public bool Save()
        {
            return _db.SaveChanges() > 0;

        }

        public bool UpdateProducto(Producto producto)
        {
            _db.Productos.Update(producto);
            return Save();
        }
    }
}
