using TMPro;
using UnityEngine;

public class ActiveButtonToClick : MonoBehaviour
{
    [SerializeField] private TMP_Text currentBalanceText;
    [SerializeField] private float currentBalance;
    [SerializeField] private string currency = "$";
    [SerializeField] private float moneyPerClick = 1f;
    
    public void Update()
    {
        currentBalanceText.text = currentBalance + currency;
    }

    public void GenerateFlasks()
    {
        currentBalance += moneyPerClick;
    }
}
