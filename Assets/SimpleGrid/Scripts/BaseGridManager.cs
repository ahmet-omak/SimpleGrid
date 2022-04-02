using System.Collections.Generic;
using UnityEngine;

public class BaseGridManager : MonoBehaviour
{
    public List<Cell> cells;

    private void Awake()
    {
        cells = new List<Cell>();
    }

    private void Start()
    {
        
    }

    protected void GenerateHexagonalXZGrid(HexagonalGridSettings gridSettings)
    {
        var gridParent = new GameObject(gridSettings.ParentName);

        uint index = 0;
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
                var cell = new Cell(worldPos, gridPos, index++);
                cells.Add(cell);
            }
        }
    }

    protected void GenerateHexagonalXYGrid(HexagonalGridSettings gridSettings)
    {
        var gridParent = new GameObject(gridSettings.ParentName);

        uint index = 0;
        int height = gridSettings.Height;
        int width = gridSettings.Width;

        float widthOffset = gridSettings.WidthOffset;
        float heightOffset = gridSettings.HeightOffset;
        float hexagonalOffset = gridSettings.HexagonalOffset;

        Vector3 initialPos = gridSettings.InitialPos;

        GameObject gridPrefab = gridSettings.GridPrefab;

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                Vector3 worldPos = initialPos + new Vector3(x * widthOffset + (y % 2 * hexagonalOffset), y * heightOffset, 0f);
                Vector2 gridPos = new Vector2(x, y);
                var gridObj = Instantiate(gridPrefab, worldPos, Quaternion.identity);
                gridObj.transform.SetParent(gridParent.transform);
                var cell = new Cell(worldPos, gridPos, index++);
                cells.Add(cell);
            }
        }
    }

    protected void GenerateQuadralXYGrid(QuadralGridSettings gridSettings)
    {
        var gridParent = new GameObject(gridSettings.ParentName);

        uint index = 0;
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
                var cell = new Cell(worldPos, gridPos, index++);
                cells.Add(cell);
            }
        }
    }

    protected void GenerateQuadralXZGrid(QuadralGridSettings gridSettings)
    {
        var gridParent = new GameObject(gridSettings.ParentName);

        uint index = 0;
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
                var cell = new Cell(worldPos, gridPos, index++);
                cells.Add(cell);
            }
        }
    }
}
