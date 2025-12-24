using LoginIdentity.Models;
using LoginIdentity.Repository;
using LoginIdentity.Repository.IProductRepo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoginIdentity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProdRepo _repo;
        public ProductController(IProdRepo repo)
        {
            _repo = repo;
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetProductos()
        {
            var productos = _repo.GetProductos();
            return Ok(productos);
        }

        [HttpGet("{productoId:int}", Name = "GetProducto")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetProducto(int productoId)
        {
            var producto = _repo.GetProducto(productoId);
            if (producto == null)
            {
                return NotFound();
            }
            return Ok(producto);
        }


        [HttpPost]
        [Authorize]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult CreateProducto([FromBody] Producto producto)
        {
            if (producto == null)
            {
                return BadRequest(ModelState);
            }
            if (!_repo.CreateProducto(producto))
            {
                ModelState.AddModelError("", "Algo salió mal guardando el producto");
                return StatusCode(500, ModelState);
            }
            return CreatedAtRoute("GetProducto", new { productoId = producto.Id }, producto);

        }

        [HttpDelete("{productoId:int}", Name = "EliminarProducto")]
        [Authorize]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult DeleteProducto(int productoId)
        {
            var producto = _repo.GetProducto(productoId);
            if (producto == null)
            {
                return NotFound();
            }
            if (!_repo.DeleteProducto(producto))
            {
                ModelState.AddModelError("", "Algo salió mal borrando el producto");
                return StatusCode(500, ModelState);
            }
            return NoContent();
        }
    }
}
