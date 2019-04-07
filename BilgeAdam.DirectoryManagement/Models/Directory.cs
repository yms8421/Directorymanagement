using BilgeAdam.DirectoryManagement.Contracts;
using System.Collections.Generic;

namespace BilgeAdam.DirectoryManagement.Models
{
    public class Directory : IContainer
    {
        public Directory(string title)
        {
            Members = new List<IPrinciple>();
            Title = title;
        }
        public List<IPrinciple> Members { get; set; }
        public string Title { get; }
    }
}
