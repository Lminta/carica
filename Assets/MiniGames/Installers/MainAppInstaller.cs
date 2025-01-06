using MiniGames.Core.UI;
using UnityEngine;
using Zenject;

namespace MiniGames.Installers
{
    public class MainAppInstaller : MonoInstaller
    {
        [SerializeField] private UIManager _uiManagerPrefab;
        public override void InstallBindings()
        {
            BindCustomFactories();
            BindServices();
            BindGOs();
        }

        private void BindGOs()
        {
            Container.Bind<UIManager>().FromComponentInNewPrefab(_uiManagerPrefab)
                .WithGameObjectName("UIManager")
                .AsSingle()
                .NonLazy();
        }

        private void BindServices()
        {
            
        }

        void BindCustomFactories()
        {
            Container.BindInterfacesAndSelfTo<ScreenFactory>().AsSingle().NonLazy();
        }
    }
}
;;;;;;;;;'