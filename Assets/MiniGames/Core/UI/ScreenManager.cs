using UnityEngine;
using Zenject;

namespace MiniGames.Core.UI
{
    public class ScreenManager : MonoBehaviour
    {
        private ScreenFactory _screenFactory;
        
        public Transform Root => gameObject.transform;

        [Inject]
        private void Construct(ScreenFactory screenFactory)
        {
            _screenFactory = screenFactory;
        }
    }
}