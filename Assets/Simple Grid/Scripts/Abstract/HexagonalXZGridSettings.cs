using UnityEngine;

[CreateAssetMenu(menuName = "Simple Grid/Hexagonal XZ Grid Settings", fileName = "Hexagonal XZ Grid Settings", order = 2)]
public class HexagonalXZGridSettings : BaseGridSettings
{
    [SerializeField, Space(5f)] float hexagonalOffset = 1f;

    public float HexagonalOffset { get => hexagonalOffset; }

    public override void InitGrid()
    {
        var gridParent = new GameObject(ParentName);

        int index = 0;

        for (int z = 0; z < Height; z++)
        {
            for (int x = 0; x < Width; x++)
            {
                Vector3 worldPos = InitialPos + new Vector3(x * WidthOffset + (z % 2 * hexagonalOffset), 0f, z * HeightOffset);
                var gridObj = Instantiate(GridPrefab, worldPos, Quaternion.identity);
                gridObj.name = ChildName + $"{index}";
                gridObj.transform.SetParent(gridParent.transform);
                index++;
            }
        }
    }
}
