using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class ProgressBar : MonoBehaviour
    {
        private TextMeshProUGUI _levelText;
        [SerializeField] private Slider _slider; // вынести в BusinessModel для каждого префаба
        [SerializeField] private float _delaySecond = 3f; // перенести в конфиг для выбора времени каждому префабy(delayIncome)

        private float minProgressValue = 0.014f;
        private float maxProgressValue = 0.99f;
        private float progressSpeed = 1.0f;
        private float Level = 1f; // привязка к лвл 
        
        private void Update()
        {
            _slider.value = minProgressValue;
            
            if (minProgressValue < maxProgressValue && Level >=1)
            {
                var speed = progressSpeed/ _delaySecond;
                minProgressValue += speed * Time.deltaTime;
                minProgressValue = Mathf.Clamp01(minProgressValue);
            }
            else if(Level >= 1)
            {
                minProgressValue = 0.014f;
                
                // baseIncome(значение в панели) прибавить к Money(баланс)
                // Money += baseIncome;
            }
        }
    }
}