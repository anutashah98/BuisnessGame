using TMPro;
using UnityEngine;

namespace DefaultNamespace
{
    public class MoneyBalanceView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _balanceText;

        private MoneyBalanceController _moneyBalanceController;
        
        private void Update()
        {
            _balanceText.text = _moneyBalanceController + "$";
        }
    }
}