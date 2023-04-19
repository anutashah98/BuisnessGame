using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class ProgressBar : MonoBehaviour
    {
        [SerializeField] private Slider slider;
        [SerializeField] private float delaySecond = 3f;

        private float _minProgressValue = 0.014f;
        private float _maxProgressValue = 0.99f;
        private float _progressSpeed = 1.0f;
        
        private void Update() //SliderValue()
        {
            if (_minProgressValue < _maxProgressValue)
            {
                var speed = _progressSpeed/ delaySecond;
                _minProgressValue += speed * Time.deltaTime;
                _minProgressValue = Mathf.Clamp01(_minProgressValue);
                slider.value = _minProgressValue;
            }
        }
    }
}

/* delaySecond перенести в конфиг для выбора времени каждому префабу
 когда value достигает _maxProgressValue надо её сбить в _minProgressValue и повтр SliderValue()
 при повторении SliderValue() к чему-то доб сумма от панели и она передает общую сумму(сумма за лв и улучшения) к балансу
 
*/