using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class Candy : MonoBehaviour
{

    #region Components
    [FoldoutGroup("Components", true, 0, GroupID = "Component")]
    [SerializeField]
    private CandyStatComponent statComp;
    #endregion

    public float GetRatio
    {
        get => statComp.Ratio;
    }
    public CandyType GetCandyType
    {
        get => statComp.Type;
    }
}
