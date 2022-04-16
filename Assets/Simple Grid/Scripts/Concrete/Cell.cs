using UnityEngine;
using System;

[Serializable]
public class Cell 
{
    public int index;
    public Vector3 worldPos;
    public Vector2 gridPos;

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

    public Cell SetGridPos(Vector2 gridPos)
    {
        this.gridPos = gridPos;
        return this;
    }
}
