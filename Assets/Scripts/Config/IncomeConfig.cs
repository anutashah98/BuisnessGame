using System;
using UnityEngine;

namespace DefaultNamespace
{
    [Serializable]
    public class IncomeConfig
    {
        public BusinessName businessName => _businesNames;
        public int baseIncome => _baseIncome;
        public int delayIncome => _delayIncome;
        public int baseCostLevel => _baseCostLevel;

        [SerializeField] private BusinessName _businesNames;
        [SerializeField] private int _baseIncome;
        [SerializeField] private int _delayIncome;
        [SerializeField] private int _baseCostLevel;
    }
}