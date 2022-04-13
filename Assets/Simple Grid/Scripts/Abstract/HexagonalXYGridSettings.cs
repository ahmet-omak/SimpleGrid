using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Simple Grid/Hexagonal XY Grid Settings", fileName = "Hexagonal XY Grid Settings", order = 3)]
public class HexagonalXYGridSettings : BaseGridSettings
{
    [SerializeField, Space(5f)] float hexagonalOffset = 1f;

    public float HexagonalOffset { get => hexagonalOffset; }

    public override void InitGrid()
    {
        var gridParent = new GameObject(ParentName);

        int index = 0;

        Cells = new List<Cell>();

        for (int y = 0; y < Height; y++)
        {
            for (int x = 0; x < Width; x++)
            {
                Vector3 worldPos = InitialPos + new Vector3(x * WidthOffset + (y % 2 * hexagonalOffset), y * HeightOffset, 0f);
                GameObject gridObj = Instantiate(GridPrefab, worldPos, Quaternion.identity);
                gridObj.name = ChildName + $"{index}";
                gridObj.transform.SetParent(gridParent.transform);
                Cells.Add(new Cell(index, worldPos));
                index++;
            }
        }
    }
}
