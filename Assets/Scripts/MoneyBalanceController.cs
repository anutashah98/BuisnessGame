using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class MoneyBalanceController : MonoBehaviour
    {
        private int Money { get ; set; }

        private void Start()
        {
            Money = 0;
        }

        private bool BalanceCheck(int amount)
        {
            return amount <= Money;
        }
        
        private void AddMoney(int amount) {
            Money += amount;
        }

        private void Buys(int amount)
        {
            Money -= amount;
        }
    }
}