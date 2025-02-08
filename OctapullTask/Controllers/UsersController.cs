using Microsoft.AspNetCore.Mvc;
using OctapullTask.Repositroy.Data;

namespace OctapullTask.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatabaseTestController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DatabaseTestController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("test-connection")]
        public IActionResult TestDatabaseConnection()
        {
            try
            {
                var canConnect = _context.Database.CanConnect();
                return Ok(new { success = canConnect });
            }
            catch (Exception ex)
            {
                return BadRequest(new { success = false, error = ex.Message });
            }
        }
    }
}
