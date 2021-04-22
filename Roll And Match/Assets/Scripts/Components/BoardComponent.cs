using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BoardComponent
{
    public byte Width;
    public byte Height;
    public float CellSize;
    public bool DebugLine;
    public Vector3 OriginPosition;
}
