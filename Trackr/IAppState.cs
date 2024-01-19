namespace Trackr
{
    public interface IAppState
    {
        Task<string> GetCurrentUser();
    }
}