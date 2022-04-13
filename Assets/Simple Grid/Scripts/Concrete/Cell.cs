using UnityEngine;
using System;

[Serializable]
public class Cell 
{
    public int index;
    public Vector3 worldPos;

    public Cell(int index, Vector3 worldPos)
    {
        this.index = index;
        this.worldPos = worldPos;
    }
}
