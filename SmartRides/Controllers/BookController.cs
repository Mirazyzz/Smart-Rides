using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartRides.Data;
using SmartRides.Helpers;
using SmartRides.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SmartRides.Controllers
{
    public class BookController : Controller
    {
        private readonly RidesDbContext _context;

        public BookController(RidesDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int? pageNumber)
        {
            var locations = _context.Locations.ToList();
            var busTypes = GetBusTypeItems();
            var rides = _context.RideSchedules
                .Include(s => s.RideDate)
                .ThenInclude(rd => rd.Ride)
                .ThenInclude(r => r.DestinationPoint)
                .Include(rs => rs.Schedule)
                .Include(rs => rs.AvailableSeats);

            ViewBag.data = locations;
            ViewBag.busTypes = busTypes;
            ViewBag.sort = "Ascending";

            int pageSize = 15;
            
            return View(PaginatedList<RideSchedule>
                .CreateList(rides, pageNumber ?? 1, pageSize));
        }

        static List<BusTypeItem> GetBusTypeItems()
        {
            var result = Enum.GetValues(typeof(BusType))
                .Cast<BusType>()
                .Select(s => new BusTypeItem
                {
                    Value = (int)Enum.Parse(typeof(BusType), s.ToString()),
                    Name = s.ToString()
                })
                .OrderByDescending(s => s.Value)
                .ToList();

            return result;
        }
            
    }

    class BusTypeItem
    {
        public int Value { get; set; }
        public string Name { get; set; }
    }
}
