using HotelGuru.DataContext.Context;
using HotelGuru.DataContext.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelGuru.Services
{
    public interface IFoodService
    {
        List<Food> List();
    }

    public class FoodService : IFoodService
    {
        private readonly AppDbContext _context;

        public FoodService(AppDbContext context)
        {
            _context = context;
        }

        public List<Food> List()
        {
            return _context.Foods.ToList();
        }
    }
}
