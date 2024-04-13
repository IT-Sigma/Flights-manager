using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Data;
using Data.Entity;
using Web.Models.Flights;
using Web.Models.Shared;

namespace Web.Controllers
{
    public class FlightsController : Controller
    {
        public int PageSize = 10;
        private readonly FlightsManagerDb _context;

        public FlightsController()
        {
            _context = new FlightsManagerDb();
        }

        // GET: Flights
        public async Task<IActionResult> Index(FlightsIndexViewModel model)
        {
            model.Pager ??= new PagerViewModel();
            model.Pager.CurrentPage = model.Pager.CurrentPage <= 0 ? 1 : model.Pager.CurrentPage;

            List<FlightsViewModel> items = await _context.Flights.Skip((model.Pager.CurrentPage - 1) * PageSize).Take(PageSize).Select(c => new FlightsViewModel()
            {
                FlightId = c.FlightId,
                PlaneNumber = c.PlaneNumber,
                LocationFrom = c.LocationFrom,
                LocationTo = c.LocationTo,
                TakeOff = c.TakeOff,
                Landing = c.Landing,
                Duration = c.Landing - c.TakeOff,
                PlaneType = c.PlaneType,
                PilotName = c.PilotName,
                UnoccupiedSeats = c.UnoccupiedSeats,
                UnoccupiedBusinessSeats = c.UnoccupiedBusinessSeats,

            }).ToListAsync();

            model.Items = items;
            model.Pager.PagesCount = (int)Math.Ceiling(await _context.Flights.CountAsync() / (double)PageSize);

            return View(model);
        }

        // GET: Flights-Worker
        public async Task<IActionResult> IndexWorker(FlightsIndexViewModel model)
        {
            model.Pager ??= new PagerViewModel();
            model.Pager.CurrentPage = model.Pager.CurrentPage <= 0 ? 1 : model.Pager.CurrentPage;

            List<FlightsViewModel> items = await _context.Flights.Skip((model.Pager.CurrentPage - 1) * PageSize).Take(PageSize).Select(c => new FlightsViewModel()
            {
                FlightId = c.FlightId,
                PlaneNumber = c.PlaneNumber,
                LocationFrom = c.LocationFrom,
                LocationTo = c.LocationTo,
                TakeOff = c.TakeOff,
                Landing = c.Landing,
                Duration = c.Landing - c.TakeOff,
                PlaneType = c.PlaneType,
                PilotName = c.PilotName,
                UnoccupiedSeats = c.UnoccupiedSeats,
                UnoccupiedBusinessSeats = c.UnoccupiedBusinessSeats,

            }).ToListAsync();

            model.Items = items;
            model.Pager.PagesCount = (int)Math.Ceiling(await _context.Flights.CountAsync() / (double)PageSize);

            return View(model);
        }

        // GET: Flights/Create
        public IActionResult Create()
        {
            FlightsCreateViewModel model = new FlightsCreateViewModel();

            return View(model);
        }

        // POST: Flights/Create        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(FlightsCreateViewModel createModel)
        {
            if (ModelState.IsValid)
            {
                Flight flight = new Flight
                {
                    FlightId = createModel.FlightId,
                    PlaneNumber = createModel.PlaneNumber,
                    LocationFrom = createModel.LocationFrom,
                    LocationTo = createModel.LocationTo,
                    TakeOff = createModel.TakeOff,
                    Landing = createModel.Landing,
                    PlaneType = createModel.PlaneType,
                    PilotName = createModel.PilotName,
                    UnoccupiedSeats = createModel.UnoccupiedSeats,
                    UnoccupiedBusinessSeats = createModel.UnoccupiedBusinessSeats,
                };

                if (flight.Landing > flight.TakeOff)
                {
                    _context.Add(flight);
                    await _context.SaveChangesAsync();

                    return RedirectToAction(nameof(Index));
                }
            }
            return View(createModel);
        }

        // GET: Flights/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Flight flight = await _context.Flights.FindAsync(id);
            if (flight == null)
            {
                return NotFound();
            }

            FlightsEditViewModel model = new FlightsEditViewModel
            {
                FlightId = flight.FlightId,
                PlaneNumber = flight.PlaneNumber,
                LocationFrom = flight.LocationFrom,
                LocationTo = flight.LocationTo,
                TakeOff = flight.TakeOff,
                Landing = flight.Landing,
                PlaneType = flight.PlaneType,
                PilotName = flight.PilotName,
                UnoccupiedSeats = flight.UnoccupiedSeats,
                UnoccupiedBusinessSeats = flight.UnoccupiedBusinessSeats,
            };

            return View(model);
        }

        // POST: Flights/Edit/5       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(FlightsEditViewModel editModel)
        {
            if (ModelState.IsValid)
            {
                Flight flight = new Flight()
                {
                    FlightId = editModel.FlightId,
                    PlaneNumber = editModel.PlaneNumber,
                    LocationFrom = editModel.LocationFrom,
                    LocationTo = editModel.LocationTo,
                    TakeOff = editModel.TakeOff,
                    Landing = editModel.Landing,
                    PlaneType = editModel.PlaneType,
                    PilotName = editModel.PilotName,
                    UnoccupiedSeats = editModel.UnoccupiedSeats,
                    UnoccupiedBusinessSeats = editModel.UnoccupiedBusinessSeats,
                };

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

            return View(editModel);
        }

        // GET: Flights/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            Flight flight = await _context.Flights.FindAsync(id);
            _context.Flights.Remove(flight);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        private bool FlightExists(int id)
        {
            return _context.Flights.Any(e => e.FlightId == id);
        }
    }
}
