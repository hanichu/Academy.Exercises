using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Exercises.Entities
{
    public enum BedRoomType
    {
        Single,
        Double,
        Triple
    }
    public class BedRoom : Space
    {
        public BedRoomType Type { get; set; }
        public bool HasTelevision { get; set; }
    }
}
