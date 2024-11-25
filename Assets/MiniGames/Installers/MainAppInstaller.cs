using MiniGames.Core.UI;
using Zenject;

namespace MiniGames.Installers
{
    public class MainAppInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            BindCustomFactories();
        }
        
        void BindCustomFactories()
        {
            Container.BindInterfacesAndSelfTo<ScreenFactory>().AsSingle().NonLazy();
        }
    }
}
