using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class BusinessModel : MonoBehaviour
    {
        [SerializeField] private string BusinessName;
        
        [SerializeField] private float baseCashPerRound;
        
        [SerializeField] private TextMeshProUGUI _nameBusiness;
        [SerializeField] private TextMeshProUGUI _levelText;
        [SerializeField] private TextMeshProUGUI _cashText;
        [SerializeField] private TextMeshProUGUI _costText;

        [SerializeField] private Button upgrade1Button;
        [SerializeField] private Button upgrade2Button;
        [SerializeField] private Button levelButton;

        [SerializeField] private BusinessConfig _config;

    }
}