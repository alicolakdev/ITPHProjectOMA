using ITPHAcademyOMAWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ITPHAcademyOMAWebAPI.Controllers
{

    [ApiController]
    [Route("roles")]
    public class RolesController : ControllerBase
    {

        private readonly ITPHAcademyOMAContext _context;

        public RolesController(ITPHAcademyOMAContext context)
        {
            _context = context;
        }



        // http://host:port/Roles/GetRoles
        [HttpGet("all")]
        public async Task<ActionResult<IEnumerable<Role>>> GetRolesAsync()
        {
            var roles = await _context.Roles.ToListAsync();
            return roles;
        }

        [HttpPost("all")]
        public async Task<ActionResult<IEnumerable<Role>>> GetRolesAsync2()
        {
            var roles = await _context.Roles.ToListAsync();
            return roles;
        }

        // GET: RolesController/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RolesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RolesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        private ActionResult View()
        {
            throw new NotImplementedException();
        }

        // GET: RolesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RolesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RolesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RolesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}
