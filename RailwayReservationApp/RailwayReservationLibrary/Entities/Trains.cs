﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayReservationLibrary.Entities
{
    public class Trains
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DepartureFrom { get; set; }
        public string Destination { get; set; }
        public Datetime DepartureTime { get; set; }
        public Datetime ArrivalTime { get; set; }
    }
}
