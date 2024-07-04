using Microsoft.AspNetCore.Mvc;
using modal.Data;
using modal.Models;


namespace modal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var clientes = _context.Cliente.ToList();
            if (clientes == null || !clientes.Any())
            {
                Console.WriteLine("No se encontraron clientes.");
                // Maneja el caso donde no hay datos
            }
            else
            {
                Console.WriteLine($"Se encontraron {clientes.Count} clientes.");
            }
            return View(clientes);
        }

        [HttpPost]
        public IActionResult AddCustomer(string camp1, string camp2, string camp3)
        {
            var customer = new Cliente
            {
                Nombre = camp1,
                Pais = camp2,
                TipoDeEntidad = camp3
            };
            _context.Cliente.Add(customer);
            _context.SaveChanges();
            return Ok();
        }

        [HttpPost]
        public IActionResult DeleteCustomer(int id)
        {
            var customer = _context.Cliente.Find(id);
            if (customer != null)
            {
                _context.Cliente.Remove(customer);
                _context.SaveChanges();
            }
            return Ok();
        }
    }
}
