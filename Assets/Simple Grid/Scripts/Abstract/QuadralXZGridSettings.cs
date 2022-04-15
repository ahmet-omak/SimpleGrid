using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Simple Grid/Quadral XZ Grid Settings", fileName = "Quadral XZ Grid Settings", order = 0)]
public class QuadralXZGridSettings : BaseGridSettings
{
    public override void InitGrid()
    {
        var gridParent = new GameObject(ParentName);

        int index = 0;

        Cells = new List<Cell>();

        for (int z = 0; z < Height; z++)
        {
            for (int x = 0; x < Width; x++)
            {
                Vector3 worldPos = InitialPos + new Vector3(x * WidthOffset, 0f, z * HeightOffset);
                var grid = Instantiate(GridPrefab, worldPos, Quaternion.identity);
                grid.SetText(index).SetName(ChildName + $"{index}").SetParent(gridParent.transform);
                Cells.Add(new Cell(index, worldPos));
                index++;
            }
        }
    }
}
