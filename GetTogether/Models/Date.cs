using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetTogether.Models
{
    public class Date
    {
        public int Id { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime FinalDate { private get; set; }
        public DateSearch DateSearch { get; private set; }

        private Date() { }

        public Date(DateTime finalDate, DateSearch dateSearch)
        {
            FinalDate = finalDate;
            DateSearch = dateSearch;

            CreatedAt = DateTime.Now;
        }
    }
}
