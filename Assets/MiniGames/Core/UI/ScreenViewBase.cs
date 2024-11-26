using UnityEngine;

namespace MiniGames.Core.UI
{
    public abstract class ScreenViewBase : MonoBehaviour
    {
        public abstract void Open();
        public abstract void Close();
    }
}