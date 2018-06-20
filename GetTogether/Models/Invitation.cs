using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetTogether.Models
{
    public class Invitation
    {
        public int Id { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public virtual Group IntoGroup { get; private set; }
        public virtual User CreatedBy { get; private set; }
        public string Email { get; private set; }
        public string Message { get; private set; }
        public bool EMailSent { get; set; } = false;

        protected Invitation() { }

        public Invitation(string email, string message, User createdBy, Group intoGroup)
        {
            Email = email;
            Message = message;
            CreatedBy = createdBy;
            IntoGroup = intoGroup;

            CreatedAt = DateTime.Now;
        }
    }
}
