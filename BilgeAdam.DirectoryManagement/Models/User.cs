using BilgeAdam.DirectoryManagement.Contracts;

namespace BilgeAdam.DirectoryManagement.Models
{
    public class User : IPrinciple
    {
        public string UserName { get; set; }
        public IPrinciple Parent { get; set; }
        public void AddToGroup(IContainer group)
        {
            
        }
    }
}
