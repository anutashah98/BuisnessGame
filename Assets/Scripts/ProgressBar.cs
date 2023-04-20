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
        private float Level = 1f; // привязка к лвл 
        
        private void Update()
        {
            slider.value = _minProgressValue;
            
            if (_minProgressValue < _maxProgressValue && Level >=1)
            {
                var speed = _progressSpeed/ delaySecond;
                _minProgressValue += speed * Time.deltaTime;
                _minProgressValue = Mathf.Clamp01(_minProgressValue);
            }
            else if(Level >= 1)
            {
                _minProgressValue = 0.014f;
                // добавить баланс
            }
        }
    }
}

/* delaySecond перенести в конфиг для выбора времени каждому префабу
 
 при повторении SliderValue() к чему-то доб сумма от панели и она передает общую сумму(сумма за лв и улучшения) к балансу
 
*/