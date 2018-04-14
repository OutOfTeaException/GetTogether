using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetTogether.Models
{
    public class Group
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public User CreatedBy { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public ICollection<User> Users { get; private set; }
        public ICollection<Invitation> Invitations { get; private set; }

        private Group() { }

        public Group(string name, User createdBy)
        {
            Name = name;
            CreatedBy = createdBy;

            CreatedAt = DateTime.Now;
            Users = new List<User>();
            Invitations = new List<Invitation>();
        }

        public void InviteUser(string email, string message, User invitedBy)
        {
            var invitation = new Invitation(email, message, invitedBy, this);
            Invitations.Add(invitation);    
        }
    }
}
