﻿using NetPincerApp.DataContext.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetpincerApp.DataContext.Entities
{
    public class HotelGuru
    {
        public Users Users { get; set; }
        public Rooms Rooms { get; set; }
        public Bookings Bookings { get; set; }
    }
}
