using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayReservationLibrary.Entities
{
    public class Route
    {
        public int Id { get; set; }
        public string To { get; set; }
        public string From { get; set; }
        public int FixedFare { get; set; }
        public int TrainId { get; set; }
    }
}
