using System;
using UnityEngine;
using UnityEngine.UI;

namespace PixelCrew.UI.Widgets
{
    public class ProgressBarWidget : MonoBehaviour
    {
       private Image _bar;
        private float progress;


        private void Start()
        {
            _bar = GetComponent<Image>();
            
        }


        public void CorrectAnswer()
        {
            _bar.fillAmount += 0.1f;

        }
        public void InCorrectAnswer()
        {
            _bar.fillAmount -= 0.1f;

        }
    }
}