using UnityEngine;
using System;

[Serializable]
public class Cell 
{
    public int index;
    public Vector3 worldPos;

    public Cell SetIndex(int index)
    {
        this.index = index;
        return this;
    }

    public Cell SetWorldPos(Vector3 worldPos)
    {
        this.worldPos = worldPos;
        return this;
    }
}
