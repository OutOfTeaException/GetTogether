using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetTogether.Models
{
    public class DateProposal
    {
        public int Id { get; private set; }
        public virtual User CreatedBy { get; private set; }
        public virtual DateSearch DateSearch { get; private set; }
        public DateTime ProposedDate { get; private set; }
        public DateTime CreatedAt { get; private set; }

        protected DateProposal() { }

        public DateProposal(DateSearch dateSearch, User createdBy, DateTime proposedDate)
        {
            CreatedBy = createdBy;
            DateSearch = dateSearch;
            ProposedDate = proposedDate;

            CreatedAt = DateTime.Now;
        }
    }
}
