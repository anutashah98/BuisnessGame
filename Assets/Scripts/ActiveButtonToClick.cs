using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class ActiveButtonToClick : MonoBehaviour
{
    [SerializeField] private TMP_Text _currentBalanceText;
    [SerializeField] private float _currentBalance;
    [SerializeField] private string _currency = "$";
    [SerializeField] private float _moneyPerClick = 1f;
    
    public void Update()
    {
        _currentBalanceText.text = _currentBalance + _currency;
    }

    public void GenerateBalance()
    {
        _currentBalance += _moneyPerClick;
    }
}