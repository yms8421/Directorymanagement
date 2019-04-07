using BilgeAdam.DirectoryManagement.Contracts;
using System.Collections.Generic;

namespace BilgeAdam.DirectoryManagement.Models
{
    public class Group : IPrinciple, IContainer
    {
        public Group()
        {
            Members = new List<IPrinciple>();
        }
        public string UserName { get; set; }
        public IPrinciple Parent { get; set; }
        public List<IPrinciple> Members { get; set; }

        public void AddToGroup(IContainer group)
        {
            
        }
    }
}
