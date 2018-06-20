using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetTogether.Models
{
    public class DateSearch
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; private set; }
        public virtual User CreatedBy { get; private set; }
        public virtual IEnumerable<DateProposal> Proposals { get; private set; }
        public virtual Date FinalDate { get; private set; }
        public virtual Group Group { get; private set; }

        protected DateSearch() {}

        public DateSearch(User createdBy, Group belongsTo, string name, string description)
        {
            CreatedBy = createdBy;
            Group = belongsTo;
            Name = name;
            Description = description;

            CreatedAt = DateTime.Now;
            Proposals = new List<DateProposal>();
        }

        public void Finish(DateTime finalDate, DateSearch dateSearch)
        {
            FinalDate = new Date(finalDate, dateSearch);
        }
    }
}
