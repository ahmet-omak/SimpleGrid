using UnityEngine;
using System;

[Serializable]
public class Cell
{
    public Vector3 worldPos;
    public Vector2 gridPos;
    public uint gridIndex;

    public Cell()
    {

    }

    public Cell(Vector3 worldPos, Vector2 gridPos, uint gridIndex)
    {
        this.worldPos = worldPos;
        this.gridPos = gridPos;
        this.gridIndex = gridIndex;
    }
}
