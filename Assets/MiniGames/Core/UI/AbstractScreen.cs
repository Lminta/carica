using UnityEngine;

namespace MiniGames.Core.UI
{
    public abstract class AbstractScreen : MonoBehaviour, IScreenController
    {
        protected IScreenView ScreenView;
        public virtual void Setup<TPayload>(TPayload payload) where TPayload : IScreenPayload
        {
            ScreenView = payload.ScreenView;
        }

        public virtual void Open()
        {
            ScreenView.Open();
        }

        public virtual void Close()
        {
            ScreenView.Close();
        }
    }
}