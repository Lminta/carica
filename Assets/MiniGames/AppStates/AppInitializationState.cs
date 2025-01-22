using System.Collections.Generic;
using System.Threading.Tasks;
using MiniGames.Core.StateMachines.AppStateMachine;
using MiniGames.Core.Utility;
using MiniGames.Core.Utility.Interfaces;
using Zenject;

namespace MiniGames.AppStates
{
    public class AppInitializationState : IAppState
    {
        private readonly List<IInitializableAsync> _services;  
        private readonly AppStateMachine _appStateMachine;
        
        
        public AppInitializationState(AppStateMachine appStateMachine, List<IInitializableAsync> services)
        {
            _services = services;
            _appStateMachine = appStateMachine;
        }
        
        public void Enter()
        {
            InitializeServices().OnMainThread(_appStateMachine.Enter<AppInitializationState>).CheckResult();
        }
        
        private async Task InitializeServices()
        {
            foreach (var service in _services)
            {
                await service.InitializeAsync();
            }
            
            _appStateMachine.Enter<AppMainMenuState>();
        }
    }
}