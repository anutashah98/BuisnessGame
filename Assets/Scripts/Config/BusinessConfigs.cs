using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu(menuName = nameof(BusinessConfigs))]
    public class BusinessConfigs : ScriptableObject
    {
        public BusinessConfig[] Business => _businessConfigs;
        
        [SerializeField] private BusinessConfig[] _businessConfigs;
    }
}