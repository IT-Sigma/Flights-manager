using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BusinessLayer;
using DataLayer;
using PresentationLayer.Models;

namespace PresentationLayer.Controllers
{
    public class FlightsController : Controller
    {
        public int pageSize;
        public int page; 
        private readonly FlightManagerDbContext _context;

        public FlightsController(FlightManagerDbContext context)
        {
            _context = context;
        }

        // GET: Flights
        public async Task<IActionResult> Index()
        {
            try
            {
                ViewData["Pages"] = new List<SelectListItem>() 
                { 
                    new SelectListItem("5","5"), new SelectListItem("10", "10"), new SelectListItem("20", "20") 
                };
                return View(new FlightPageManagerViewModel(await _context.Flights.Take(3).ToListAsync()));
            }
            catch (Exception ex)
            {
                ViewData["Error"] = ex.Message;
                return View(new List<Flight>());
            }
        }

        // GET: Flights/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flight = await _context.Flights
                .FirstOrDefaultAsync(m => m.FlightId == id);
            if (flight == null)
            {
                return NotFound();
            }

            return View(flight);
        }

        // GET: Flights/Create
        public IActionResult Create()
        {
            return View();
        }

        //public IActionResult Create()
        //{
        //    return View();
        //}

        // POST: Flights/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FlightId,PlaneNumber,LocationFrom,LocationTo,TakeOff,Landing,PlaneType,PilotName,UnoccupiedSeats,UnoccupiedBusinessSeats,Duration")] Flight flight)
        {
            if (ModelState.IsValid)
            {
                _context.Add(flight);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(flight);
        }

        // GET: Flights/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flight = await _context.Flights.FindAsync(id);
            if (flight == null)
            {
                return NotFound();
            }
            return View(flight);
        }

        // POST: Flights/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FlightId,PlaneNumber,LocationFrom,LocationTo,TakeOff,Landing,PlaneType,PilotName,UnoccupiedSeats,UnoccupiedBusinessSeats,Duration")] Flight flight)
        {
            if (id != flight.FlightId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(flight);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FlightExists(flight.FlightId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(flight);
        }

        // GET: Flights/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flight = await _context.Flights
                .FirstOrDefaultAsync(m => m.FlightId == id);
            if (flight == null)
            {
                return NotFound();
            }

            return View(flight);
        }

        // POST: Flights/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var flight = await _context.Flights.FindAsync(id);
            if (flight != null)
            {
                _context.Flights.Remove(flight);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FlightExists(int id)
        {
            return _context.Flights.Any(e => e.FlightId == id);
        }

        public async Task<IActionResult> FilterByPageSize(FlightPageManagerViewModel flightViewModel)
        {

            int pageSize = flightViewModel.PageSize;

            ViewData["Pages"] = new List<SelectListItem>()
            {
                new SelectListItem("5","5"), new SelectListItem("10", "10"), new SelectListItem("20", "20")
            };

            return View(nameof(Index), new FlightPageManagerViewModel(await _context.Flights.Skip((flightViewModel.CurrentPage - 1) * flightViewModel.PageSize).Take(pageSize).ToListAsync(), 
                flightViewModel.CurrentPage, flightViewModel.PageSize));
        }

    }
}
