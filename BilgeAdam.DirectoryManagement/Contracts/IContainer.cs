using System.Collections.Generic;

namespace BilgeAdam.DirectoryManagement.Contracts
{
    public interface IContainer
    {
        List<IPrinciple> Members { get; set; }
    }
}