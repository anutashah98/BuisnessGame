
using System;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class BusinessModel : MonoBehaviour
    {
        [SerializeField] private BusinessName busName;
        
        [SerializeField] private int incomePerSecond;
        
        [SerializeField] private TextMeshProUGUI _levelText;
        [SerializeField] private TextMeshProUGUI _name;
        [SerializeField] private TextMeshProUGUI _cashText;
        [SerializeField] private TextMeshProUGUI _costText;

        [SerializeField] private Button upgrade1Button;
        [SerializeField] private Button upgrade2Button;
        [SerializeField] private Button levelButton;

        [SerializeField] private BusinessConfigs businessConfig;
        [SerializeField] private IncomeConfigs _incomeConfig;
        
        


        private void Start()
        {
            foreach (var Name in businessConfig.Business)
            {
                foreach (var Cost in _incomeConfig.Income)
                {
                    if (Name.businessName == busName && Cost.businessName == busName)
                    {
                        _name.text = Name.businessName.ToString();
                        _levelText.text = "LV " + Name.level;
                        _cashText.text = Cost.baseIncome.ToString() + " $";
                        _costText.text = Cost.baseCostLevel.ToString();
                    }
                }
               
            }
        }
        
    }
}