namespace MiniGames.Core.UI
{
    public interface IScreenController
    {
        void Setup<TPayload>(TPayload payload) where TPayload : IScreenPayload;
        void Open();
        void Close();
    }
}