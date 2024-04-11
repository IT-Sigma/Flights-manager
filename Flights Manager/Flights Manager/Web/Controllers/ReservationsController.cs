using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Data;
using Data.Entity;
using Web.Models.Reservations;
using Web.Models.Shared;
using Web.Models;
using Web.Models.Flights;

namespace Web.Controllers
{
    public class ReservationsController : Controller
    {
        private const int PageSize = 10;
        private readonly FlightsManagerDb _context;

        public ReservationsController()
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
                PlaneNumber = c.PlaneNumber,
                LocationFrom = c.LocationFrom,
                LocationTo = c.LocationTo,
                TakeOff = c.TakeOff,
                Landing = c.Landing,
                PlaneType = c.PlaneType,
                PilotName = c.PilotName,
                UnoccupiedSeats = c.UnoccupiedSeats,
                UnoccupiedBusinessSeats = c.UnoccupiedBusinessSeats

            }).ToListAsync();

            model.Items = items;
            model.Pager.PagesCount = (int)Math.Ceiling(await _context.Flights.CountAsync() / (double)PageSize);

            return View(model);
        }

        // GET: Reservations/Reserve
        public IActionResult Reserve()
        {
            ReservationsCreateViewModel model = new ReservationsCreateViewModel();

            return View(model);
        }

        // POST: Reservations/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ReservationsCreateViewModel createModel)
        {
            if (ModelState.IsValid)
            {
                Reservation reservation = new Reservation
                {
                    ReservationId = createModel.ReservationId,
                    PlaneNumber = createModel.PlaneNumber,
                    FirstName = createModel.FirstName,
                    Surname = createModel.Surname,
                    LastName = createModel.LastName,
                    Email = createModel.Email,
                    EGN = createModel.EGN,
                    Address = createModel.Address,
                    PhoneNumber = createModel.PhoneNumber,
                    Nationality = createModel.Nationality,
                    TicketType = createModel.TicketType
                };

                _context.Add(reservation);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(createModel);
        }
    }
}
