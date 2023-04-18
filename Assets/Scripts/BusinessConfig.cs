using System;
using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu(menuName = nameof(BusinessConfig))]
    public class BusinessConfig : ScriptableObject
    {
        public string BusinessName;
        public bool Update1;
        public bool Update2;
        public int UpdateCost1;
        public int UpdateCost2;
        public int UpdateIncome;
        public int delay;
    }
}