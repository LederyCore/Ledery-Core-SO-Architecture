using UnityEngine;


namespace LederyCore.Core.SOArchitecture
{
    /// <summary>
    /// KOR : EnumSO 필드를 추가하는 기본 ScriptableObject 입니다.
    /// ENG : This is a base ScriptableObject that adds an EnumSO field.
    /// </summary>
    public abstract class BaseSO : DescriptionSO
    {
        [SerializeField] private EnumSO m_EnumSO;
    }
}