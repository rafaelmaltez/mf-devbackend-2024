using mf_devbackend_2024.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace mf_devbackend_2024.Controllers
{
    public class VehiclesController : Controller
    {
        private readonly AppDbContext _context;
        public VehiclesController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var vehicles = await _context.Vehicles.ToListAsync();
            return View(vehicles);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                _context.Vehicles.Add(vehicle);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(vehicle);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var vehicleData = await _context.Vehicles.FindAsync(id);

            if (vehicleData == null)
                return NotFound();

            return View(vehicleData);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Vehicle vehicle)
        {
            if (id != vehicle.Id)
                return NotFound();
            if (ModelState.IsValid)
            {
                _context.Vehicles.Update(vehicle);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(vehicle);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var vehicleData = await _context.Vehicles.FindAsync(id);

            if (vehicleData == null)
                return NotFound();

            return View(vehicleData);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var vehicleData = await _context.Vehicles.FindAsync(id);

            if (vehicleData == null)
                return NotFound();

            return View(vehicleData);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null)
                return NotFound();

            var vehicleData = await _context.Vehicles.FindAsync(id);

            if (vehicleData == null)
                return NotFound();

            _context.Vehicles.Remove(vehicleData);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
