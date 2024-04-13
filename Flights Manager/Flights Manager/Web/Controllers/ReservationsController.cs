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
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Data.Enumeration;

namespace Web.Controllers
{
    public class ReservationsController : Controller
    {
        public int PageSize = 10;
        private readonly FlightsManagerDb _context;

        public ReservationsController()
        {
            _context = new FlightsManagerDb();
        }

        // GET-User: Flights
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
                Duration = c.Duration,
                PlaneType = c.PlaneType,
                PilotName = c.PilotName,
                UnoccupiedSeats = c.UnoccupiedSeats,
                UnoccupiedBusinessSeats = c.UnoccupiedBusinessSeats

            }).ToListAsync();

            /*//Removing the flights without unoccupied seats
            for (int i = items.Count-1; i >= 0; i--)
            {
                if (items[i].UnoccupiedBusinessSeats == 0 && items[i].UnoccupiedSeats == 0)
                {
                    items.Remove(items[i]);
                }
            }*/

            model.Items = items;
            model.Pager.PagesCount = (int)Math.Ceiling(await _context.Flights.CountAsync() / (double)PageSize);

            return View(model);
        }

        public async Task<IActionResult> IndexAdmin(ReservationsIndexViewModel model)
        {
            model.Pager ??= new PagerViewModel();
            model.Pager.CurrentPage = model.Pager.CurrentPage <= 0 ? 1 : model.Pager.CurrentPage;

            List<ReservationsViewModel> items = await _context.Reservations.Skip((model.Pager.CurrentPage - 1) * PageSize).Take(PageSize).Select(c => new ReservationsViewModel()
            {
                ReservationId = c.ReservationId,
                FlightId = c.FlightId,
                UserId = c.UserId,
                FirstName = c.FirstName,
                Surname = c.Surname,
                LastName = c.LastName,
                Email = c.Email,
                EGN = c.EGN,
                Address = c.Address,
                PhoneNumber = c.PhoneNumber,
                Nationality = c.Nationality,
                TicketType = c.TicketType,

            }).ToListAsync();

            model.Items = items;
            model.Pager.PagesCount = (int)Math.Ceiling(await _context.Reservations.CountAsync() / (double)PageSize);

            return View(model);
        }

        public async Task<IActionResult> IndexWorker(ReservationsIndexViewModel model)
        {
            model.Pager ??= new PagerViewModel();
            model.Pager.CurrentPage = model.Pager.CurrentPage <= 0 ? 1 : model.Pager.CurrentPage;

            List<ReservationsViewModel> items = await _context.Reservations.Skip((model.Pager.CurrentPage - 1) * PageSize).Take(PageSize).Select(c => new ReservationsViewModel()
            {
                ReservationId = c.ReservationId,
                FlightId = c.FlightId,
                UserId = c.UserId,
                FirstName = c.FirstName,
                Surname = c.Surname,
                LastName = c.LastName,
                Email = c.Email,
                EGN = c.EGN,
                Address = c.Address,
                PhoneNumber = c.PhoneNumber,
                Nationality = c.Nationality,
                TicketType = c.TicketType,

            }).ToListAsync();

            model.Items = items;
            model.Pager.PagesCount = (int)Math.Ceiling(await _context.Reservations.CountAsync() / (double)PageSize);

            return View(model);
        }

        // GET: Reservations
        public IActionResult Create()
        {
            ReservationsCreateViewModel model = new ReservationsCreateViewModel();

            return View(model);
        }

        // POST: Reservations
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ReservationsCreateViewModel createModel)
        {
            if (ModelState.IsValid)
            {
                Reservation reservation = new Reservation
                {
                    ReservationId = createModel.ReservationId,
                    FlightId = createModel.FlightId,
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

                if (reservation.EGN.ToString().Length != 10 || reservation.PhoneNumber.ToString().Length != 10)
                {
                    return View(createModel);
                }
                //Проверка дали има свободни места, ама първо трябва да се свържат полетите
                /*if (reservation.TicketType == TicketTypeEnum.Standart || )
                {

                }*/
                _context.Add(reservation);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(createModel);
        }
    }
}
