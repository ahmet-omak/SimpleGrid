using UnityEngine;

[CreateAssetMenu(menuName = "Hyper Utilities/Quadral Grid Settings", fileName = "Quadral Grid Settings")]
public class QuadralGridSettings : BaseGridSettings
{
    public override void InitGrid()
    {
        var gridManager = FindObjectOfType<GridManager>();

        var gridParent = new GameObject("Grid Objects");
        for (int z = 0; z < Height; z++)
        {
            for (int x = 0; x < Width; x++)
            {
                Vector3 worldPos = InitialPos + new Vector3(x * WidthThreshold, 1f, z * HeightThreshold);
                Vector2 gridPos = new Vector2(x, z);
                var gridObj = Instantiate(GridPrefab, worldPos, Quaternion.identity);
                gridObj.transform.SetParent(gridParent.transform);
            }
        }
    }
}
