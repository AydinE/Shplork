using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HotelKamers.Data;
using HotelKamers.Models;
using HotelKamers.Models.BookingViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace HotelKamers.Controllers
{

    [Authorize]
    public class BookingsGuestController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public BookingsGuestController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: BookingsGuest
        public async Task<IActionResult> Index()
        { 
            ApplicationUser user = await _userManager.GetUserAsync(User);
            var applicationDbContext = _context.Booking.Include(b => b.Guest).Include(b => b.Room).Where(b => b.Guest == user);

            return View(await applicationDbContext.ToListAsync());
        }

        // GET: BookingsGuest/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Booking
                .Include(b => b.Guest)
                .Include(b => b.Room)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }

        // GET: BookingsGuest/Create
        public IActionResult Create()
        {
            //ViewData["GuestId"] = new SelectList(_context.Users, "Id", "Id");
            ViewData["RoomId"] = new SelectList(_context.Room, "ID", "Type");
            return View();
        }

        // POST: BookingsGuest/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,RoomId,GuestId,StartDateTime,EndDateTime")] GuestCreateViewModel createViewModel)
        {
            ApplicationUser user = await _userManager.GetUserAsync(User);
            //createViewModel.GuestId = user.Id;

            //Room type validation
            //RoomType roomType = booking.Room.Type;

            var stuff = await _context.Room.ToListAsync();

            List<Room> roomList = new List<Room>();

            foreach (Room r in stuff)
            {
                if (r.Type == createViewModel.RoomType)
                {
                    roomList.Add(r);
                }
            }

            if (ModelState.IsValid)
            {
                //_context.Add(booking);
                //await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            //ViewData["RoomId"] = new SelectList(_context.Room, "ID", "Name", booking.RoomId);
            return View();
        }

        // GET: BookingsGuest/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Booking.SingleOrDefaultAsync(m => m.Id == id);
            if (booking == null)
            {
                return NotFound();
            }
            ViewData["GuestId"] = new SelectList(_context.Users, "Id", "Id", booking.GuestId);
            ViewData["RoomId"] = new SelectList(_context.Room, "ID", "Name", booking.RoomId);
            return View(booking);
        }

        // POST: BookingsGuest/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,RoomId,GuestId,StartDateTime,EndDateTime")] Booking booking)
        {
            if (id != booking.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(booking);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookingExists(booking.Id))
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
            ViewData["GuestId"] = new SelectList(_context.Users, "Id", "Id", booking.GuestId);
            ViewData["RoomId"] = new SelectList(_context.Room, "ID", "Name", booking.RoomId);
            return View(booking);
        }

        // GET: BookingsGuest/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Booking
                .Include(b => b.Guest)
                .Include(b => b.Room)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }

        // POST: BookingsGuest/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var booking = await _context.Booking.SingleOrDefaultAsync(m => m.Id == id);
            _context.Booking.Remove(booking);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookingExists(int id)
        {
            return _context.Booking.Any(e => e.Id == id);
        }
    }
}
