using LoginIdentity.Models;

namespace LoginIdentity.Repository.IProductRepo
{
    public interface IProdRepo
    {
        public ICollection<Producto> GetProductos();
        public Producto GetProducto(int productoId);
        public bool CreateProducto(Producto producto);
        public bool UpdateProducto(Producto producto);
        public bool DeleteProducto(Producto producto);
        public bool Save();
    }
}
