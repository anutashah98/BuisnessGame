using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace DefaultNamespace
{
    [Serializable]
    public class BusinessConfig
    {
        
        public BusinessName businessName => _businesNames;
        public int level => _level;
        public bool checkUpdate1 => _Update1;
        public bool checkUpdate2 => _Update2;
        public int costUpdate1 => _costUpdate1;
        public int costUpdate2 => _costUpdate2;

        [SerializeField] private BusinessName _businesNames;
        [SerializeField] private int _level;
        [SerializeField] private bool _Update1;
        [SerializeField] private bool _Update2;
        [SerializeField] private int _costUpdate1;
        [SerializeField] private int _costUpdate2;

    }
}