using UnityEngine;

public class GridManager : MonoBehaviour
{
    public void InitQuadralGrid(QuadralGridSettings gridSettings)
    {
        var gridParent = new GameObject("Quadral Grid");

        int height = gridSettings.Height;
        int width = gridSettings.Width;

        float widthOffset = gridSettings.WidthOffset;
        float heightOffset = gridSettings.HeightOffset;

        Vector3 initialPos = gridSettings.InitialPos;

        GameObject gridPrefab = gridSettings.GridPrefab;

        for (int z = 0; z < height; z++)
        {
            for (int x = 0; x < width; x++)
            {
                Vector3 worldPos = initialPos + new Vector3(x * widthOffset, 0f, z * heightOffset);
                Vector2 gridPos = new Vector2(x, z);
                var gridObj = Instantiate(gridPrefab, worldPos, Quaternion.identity);
                gridObj.transform.SetParent(gridParent.transform);
            }
        }
    }

    public void InitHexagonalGrid(HexagonalGridSettings gridSettings)
    {
        var gridParent = new GameObject("Hexagonal Objects");

        int height = gridSettings.Height;
        int width = gridSettings.Width;

        float widthOffset = gridSettings.WidthOffset;
        float heightOffset = gridSettings.HeightOffset;
        float hexagonalOffset = gridSettings.HexagonalOffset;

        Vector3 initialPos = gridSettings.InitialPos;

        GameObject gridPrefab = gridSettings.GridPrefab;

        for (int z = 0; z < height; z++)
        {
            for (int x = 0; x < width; x++)
            {
                Vector3 worldPos = initialPos + new Vector3(x * widthOffset + (z % 2 * hexagonalOffset), 0f, z * heightOffset);
                Vector2 gridPos = new Vector2(x, z);
                var gridObj = Instantiate(gridPrefab, worldPos, Quaternion.identity);
                gridObj.transform.SetParent(gridParent.transform);
            }
        }
    }
}
