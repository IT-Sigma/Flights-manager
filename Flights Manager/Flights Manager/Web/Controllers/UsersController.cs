using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Data;
using Data.Entity;
using Web.Models.Users;
using Web.Models.Shared;
using Microsoft.AspNetCore.Identity;
using System.Net;
using System.Data;
using Data.Enumeration;
using Web.Models.Flights;
using Web.Controllers;
using Web.Models.Reservations;

namespace Web.Controllers
{
    public class UsersController : Controller
    {
        private const int PageSize = 10;
        private readonly FlightsManagerDb _context;

        public UsersController()
        {
            _context = new FlightsManagerDb();
        }

        // GET: Users
        public async Task<IActionResult> Index(UsersIndexViewModel model)
        {
            model.Pager ??= new PagerViewModel();
            model.Pager.CurrentPage = model.Pager.CurrentPage <= 0 ? 1 : model.Pager.CurrentPage;

            List<UsersViewModel> items = await _context.Users.Skip((model.Pager.CurrentPage - 1) * PageSize).Take(PageSize).Select(c => new UsersViewModel()
            {
                UserId = c.Id,
                Username = c.Username,
                Password = c.Password,
                Email = c.Email,
                FirstName = c.FirstName,
                LastName = c.LastName,
                EGN = c.EGN,
                Address = c.Address,
                PhoneNumber = c.PhoneNumber,
                Role = c.Role

            }).ToListAsync();

            model.Items = items;
            model.Pager.PagesCount = (int)Math.Ceiling(await _context.Users.CountAsync() / (double)PageSize);

            return View(model);
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            UsersCreateViewModel model = new UsersCreateViewModel();

            return View(model);
        }

        // POST: Users/Create        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(UsersCreateViewModel createModel)
        {
            if (ModelState.IsValid)
            {
                User user = new User
                {
                    Id = createModel.UserId,
                    Username = createModel.Username,
                    Password = createModel.Password,
                    Email = createModel.Email,
                    FirstName = createModel.FirstName,
                    LastName = createModel.LastName,
                    EGN = createModel.EGN,
                    Address = createModel.Address,
                    PhoneNumber = createModel.PhoneNumber,
                    Role = createModel.Role
                };
                if (_context is null)
                {
                    user.Role = createModel.Role = RoleEnum.Admin;
                }
                else user.Role = createModel.Role;

                _context.Add(user);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(createModel);
        }



        public IActionResult LogInForm()
        {
            UsersViewModel model = new UsersViewModel();

            return View(model);
        }

        //Dava null na UsersViewModel model
        public async Task<IActionResult> LogIn(int? UserId, string Password)
        {
            /*if (model.UserId == null)
            {
                return View(model);
            }
*/
            User user = await _context.Users.FindAsync(UserId);

            if (user == null)
            {
                return View(nameof(LogInForm));
            }

            if (user.Password == Password)
            {
                if (user.Role == RoleEnum.Admin)
                {
                    return View(nameof(FlightsController.Index));
                }
                return View(nameof(FlightsController.IndexWorker));
            }
            return View(nameof(LogInForm));
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            User user = await _context.Users.FindAsync(id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
