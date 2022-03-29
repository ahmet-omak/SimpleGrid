using UnityEngine;

public class GridManager : MonoBehaviour
{
    public void InitQuadralGrid(QuadralGridSettings gridSettings)
    {
        if (gridSettings.GridCoords == GridCoords.XZPlane)
        {
            GenerateXZGrid(gridSettings);
        }
        else if (gridSettings.GridCoords == GridCoords.XYPlane)
        {
            GenerateXYGrid(gridSettings);
        }
    }

    public void InitHexagonalGrid(HexagonalGridSettings gridSettings)
    {
        var gridParent = new GameObject(gridSettings.ParentName);

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

    private void GenerateXZGrid(QuadralGridSettings gridSettings)
    {
        var gridParent = new GameObject(gridSettings.ParentName);

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

    private void GenerateXYGrid(QuadralGridSettings gridSettings)
    {
        var gridParent = new GameObject(gridSettings.ParentName);

        int height = gridSettings.Height;
        int width = gridSettings.Width;

        float widthOffset = gridSettings.WidthOffset;
        float heightOffset = gridSettings.HeightOffset;

        Vector3 initialPos = gridSettings.InitialPos;

        GameObject gridPrefab = gridSettings.GridPrefab;

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                Vector3 worldPos = initialPos + new Vector3(x * widthOffset, y * heightOffset, 0f);
                Vector2 gridPos = new Vector2(x, y);
                var gridObj = Instantiate(gridPrefab, worldPos, Quaternion.identity);
                gridObj.transform.SetParent(gridParent.transform);
            }
        }
    }
}
