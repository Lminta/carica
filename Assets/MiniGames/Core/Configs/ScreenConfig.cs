using System.Collections.Generic;
using AYellowpaper.SerializedCollections;
using MiniGames.Core.UI;
using UnityEngine;

namespace MiniGames.Core.Configs
{
    [CreateAssetMenu(menuName = "Content/Configs/Screen list", fileName = "ScreenList")]
    public class ScreenConfig : ScriptableObject, IScreenConfig
    {
        [SerializeField] private bool _lazyLoad = false;
        [SerializeField] private SerializedDictionary<ScreenID, string> _screenReference = new ();
        
        public Dictionary<ScreenID, string>  ScreenReference => _screenReference;
        public bool LazyLoad => _lazyLoad;
    }
}