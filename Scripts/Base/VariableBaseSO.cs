using UnityEngine;

namespace LederyCore.Core.SOArchitecture
{
    public abstract class VariableBaseSO<T> : BaseSO
    {
        [SerializeField] private T m_Value;
        //[SerializeField] private bool m_

        public T Value => m_Value;
    }
}