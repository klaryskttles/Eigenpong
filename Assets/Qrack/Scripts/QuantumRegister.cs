using System.Collections.Generic;
using UnityEngine;

{
    public class QuantumRegister : QuantumSystem
    {
        public QuantumSystem QuantumSystem;

        public ulong[] QuantumSystemMappings;

        override protected ulong GetSystemIndex(ulong registerIndex)
        {
            return QuantumSystemMappings[registerIndex];
        }

        public override void CheckAlloc(List<ulong> bits)
        {
            QuantumSystem.CheckAlloc(bits);
        }

        void Start()
        {
            lastQubitCount = QubitCount;
        }

        void Update()
        {
            SystemId = QuantumSystem.SystemId;
        }

        void OnDestroy()
        {
            
        }
    }
}
