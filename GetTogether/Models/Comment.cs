using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetTogether.Models
{
    public class Comment
    {
        public int Id { get; private set; }

        private string message;
        public string Message
        {
            get => message;
            set
            {
                message = value;
                LastModifiedAt = DateTime.Now;
            }
        }
        public virtual User CreatedBy { get; private set; }
        public virtual DateSearch DateSearch { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? LastModifiedAt { get; private set; }

        public Comment(string message, User user, DateSearch dateSearch)
        {
            Message = message;
            CreatedBy = user;
            DateSearch = dateSearch;

            CreatedAt = DateTime.Now;
        }

        protected Comment() { }
    }
}
