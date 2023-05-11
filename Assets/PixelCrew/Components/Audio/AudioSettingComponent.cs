using System;
using PixelCrew.Model.Data;
using PixelCrew.Model.Data.Properties;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace PixelCrew.Components.Audio
{
    [RequireComponent(typeof(AudioSource))]
    public class AudioSettingComponent : MonoBehaviour
    {
        [SerializeField] private GameSettings.SoundSetting _mode;
        private FloatPersistentProperty _model;
        private AudioSource _source;
        private void Start()
        {
            _source = GetComponent<AudioSource>();
            _model = FindProperty();
            _model.OnChanged += OnSoundSettingChanged;
            OnSoundSettingChanged(_model.Value, _model.Value);

        }

        private void OnSoundSettingChanged(float newValue, float oldValue)
        {
            _source.volume = newValue;

        }

        private FloatPersistentProperty FindProperty()
        {
            switch (_mode)
            {
                case GameSettings.SoundSetting.Music :
                    return GameSettings.I.Music;
                case GameSettings.SoundSetting.Sfx :
                    return   GameSettings.I.Sfx;
            }

            throw new ArgumentException("Undefined mode");
        }
    }
}


