using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetTogether.Models
{
    public class DateSearch
    {
        public int Id { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public User CreatedBy { get; private set; }
        public IEnumerable<DateProposal> Proposals { get; private set; }
        public Date FinalDate { get; private set; }
        public Group Group { get; private set; }

        private DateSearch() {}

        public DateSearch(User createdBy, Group belongsTo)
        {
            CreatedBy = createdBy;
            Group = belongsTo;

            CreatedAt = DateTime.Now;
            Proposals = new List<DateProposal>();
        }

        public void Finish(DateTime finalDate, DateSearch dateSearch)
        {
            FinalDate = new Date(finalDate, dateSearch);
        }
    }
}
