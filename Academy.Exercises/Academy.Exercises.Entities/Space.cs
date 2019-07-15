using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Exercises.Entities
{
    public class Space
    {
        public Guid Id { get; set; }

        public double SquareMeters { get; set; }

        public Space[] Spaces { get; set; }

        public string Number { get; set; }

        public Space(Guid id)
        {
            this.Id = id;
        }
    }
}
