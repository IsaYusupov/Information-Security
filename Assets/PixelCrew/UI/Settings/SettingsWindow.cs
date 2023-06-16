using PixelCrew.Model.Data;
using PixelCrew.UI.Widgets;
using UnityEngine;

namespace PixelCrew.UI.Settings
{
    public class SettingsWindow : AnimatedWindow
    {
        [SerializeField] private AudioSettingsWidget _music; 
        protected override void Start()
        {
            base.Start();
            
            _music.SetModel(GameSettings.I.Music); 
        }
    }
}