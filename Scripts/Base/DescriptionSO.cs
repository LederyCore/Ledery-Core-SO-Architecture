using UnityEngine;

namespace LederyCore.Core.SOArchitecture
{
    /// <summary>
    /// KOR : 설명 필드를 추가하는 기본 ScriptableObject 입니다.
    /// ENG : This is a base ScriptableObject that adds a description field.
    /// </summary>
    public abstract class DescriptionSO : ScriptableObject
    {
        [TextArea(5, 5)]
        [SerializeField] protected string m_Description;
    }
}