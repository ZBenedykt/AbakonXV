namespace AbakonXVWPF.Infrastructure
{
    public interface IappState
    {
        int ApplicationId { get; }
        string ApplicationName { get; }
        string LoweredApplicationName { get; }
        string Description { get; }
        string Sessions { get; set; }
        string LicenceDescription { get; set; }
    }

}
