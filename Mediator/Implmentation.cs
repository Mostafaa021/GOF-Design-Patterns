using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    /// <summary>
    /// Mediator
    /// </summary>
    public interface IChatRoom
    {
        public void Register(TeamMember teamMember);
        public void Send(string from, string message);

    }
    /// <summary>
    /// ConcreteMediator
    /// </summary>
    public class ChatRoom : IChatRoom
    {
        private readonly Dictionary<string, TeamMember> teamMembers = new Dictionary<string, TeamMember>();
        public void Register(TeamMember teamMember)
        {
            teamMember.setChatRoom(this);
            if (!teamMembers.ContainsKey(teamMember.Name))
            {
                teamMembers.Add(teamMember.Name, teamMember);
            }
        }

        public void Send(string from, string message)
        {
            // Scenarioa all Members must recive it
            foreach (var teammember in teamMembers.Values)
            {
                teammember.Recive(from, message);
            }
        }
    }    /// <summary>
         /// Abstract Context
         /// </summary>
    public abstract class TeamMember
    {
        private IChatRoom? _chatRoom;
        public string Name { get; set; }
        public TeamMember(string name)
        {
            Name = name;
        }

        internal void setChatRoom(IChatRoom room)
        {
            _chatRoom = room;
        }
        public void Send(string messsage)
        {
            _chatRoom?.Send(Name, messsage);
        }
        public virtual void Recive(string from, string message)
        {
            Console.WriteLine($"Message {from} to {Name} : {message}");
        }
    }
    /// <summary>
    /// Concrete Context
    /// </summary>
    public class AccountManager : TeamMember
    {
        public AccountManager(string name) : base(name)
        {

        }
        public override void Recive(string from, string message)
        {
            Console.WriteLine($"{nameof(AccountManager)} {Name} Recieved");
            base.Recive(from, message);
        }
    }
    /// <summary>
    /// Concrete Context
    /// </summary>
    public class Lawyer : TeamMember
    {
        public Lawyer(string name) : base(name)
        {

        }
        public override void Recive(string from, string message)
        {
            Console.WriteLine($"{nameof(Lawyer)} {Name} Recieved");
            base.Recive(from, message);
        }
    }
}
