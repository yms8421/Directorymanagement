namespace BilgeAdam.DirectoryManagement.Contracts
{
    public interface IPrinciple
    {
        string UserName { get; set; }
        IPrinciple Parent { get; set; }
        void AddToGroup(IContainer group);
    }
}