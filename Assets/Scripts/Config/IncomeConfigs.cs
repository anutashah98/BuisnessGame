using UnityEngine;
using UnityEngine.Serialization;

namespace DefaultNamespace
{
    [CreateAssetMenu(menuName = nameof(IncomeConfigs))]
    public class IncomeConfigs : ScriptableObject
    {
        public IncomeConfig[] Income => _incomeConfigs;
        
        [SerializeField] private IncomeConfig[] _incomeConfigs;
    }
}