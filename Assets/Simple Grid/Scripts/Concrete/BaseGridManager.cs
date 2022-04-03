using System.Collections.Generic;
using UnityEngine;

public class BaseGridManager : MonoBehaviour
{
    public List<Cell> cells;

    /// <summary>
    /// Initialize grid according to the given grid settings
    /// </summary>
    /// <param name="gridSettings"></param>
    public void InitGrid(BaseGridSettings gridSettings)
    {
        if (gridSettings.GetType() == typeof(HexagonalGridSettings))
        {
            //Init hexagonal grid

            switch (gridSettings.GridCoords)
            {
                case GridCoords.XZPlane:
                    GenerateHexagonalXZGrid((HexagonalGridSettings)gridSettings);
                    break;
                case GridCoords.XYPlane:
                    GenerateHexagonalXYGrid((HexagonalGridSettings)gridSettings);
                    break;
            }
        }
        else if (gridSettings.GetType() == typeof(QuadralGridSettings))
        {
            //Init quadral grid

            switch (gridSettings.GridCoords)
            {
                case GridCoords.XZPlane:
                    GenerateQuadralXZGrid((QuadralGridSettings)gridSettings);
                    break;
                case GridCoords.XYPlane:
                    GenerateQuadralXYGrid((QuadralGridSettings)gridSettings);
                    break;
            }
        }
        else if (gridSettings.GetType() == typeof(VirtualQuadralGridSettings))
        {
            //Init virtual quadral grid

            switch (gridSettings.GridCoords)
            {
                case GridCoords.XZPlane:
                    GenerateVirtualQuadralXZGrid((VirtualQuadralGridSettings)gridSettings);
                    break;
                case GridCoords.XYPlane:
                    GenerateVirtualQuadralXYGrid((VirtualQuadralGridSettings)gridSettings);
                    break;
            }
        }
        else if (gridSettings.GetType() == typeof(VirtualHexagonalGridSettings))
        {
            //Init virtual hexagonal grid

            switch (gridSettings.GridCoords)
            {
                case GridCoords.XZPlane:
                    GenerateVirtualHexagonalXZGrid((VirtualHexagonalGridSettings)gridSettings);
                    break;
                case GridCoords.XYPlane:
                    GenerateVirtualHexagonalXYGrid((VirtualHexagonalGridSettings)gridSettings);
                    break;
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
                gridObj.name = gridSettings.ChildName + $"{index}";
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
                gridObj.name = gridSettings.ChildName + $"{index}";
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
                gridObj.name = gridSettings.ChildName + $"{index}";
                gridObj.transform.SetParent(gridParent.transform);
                var cell = new Cell(worldPos, gridPos, index++);
                cells.Add(cell);
            }
        }
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
                gridObj.name = gridSettings.ChildName + $"{index}";
                gridObj.transform.SetParent(gridParent.transform);
                var cell = new Cell(worldPos, gridPos, index++);
                cells.Add(cell);
            }
        }
    }

    protected void GenerateVirtualQuadralXYGrid(VirtualQuadralGridSettings gridSettings)
    {
        uint index = 0;
        int height = gridSettings.Height;
        int width = gridSettings.Width;

        float widthOffset = gridSettings.WidthOffset;
        float heightOffset = gridSettings.HeightOffset;

        Vector3 initialPos = gridSettings.InitialPos;

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                Vector3 worldPos = initialPos + new Vector3(x * widthOffset, y * heightOffset, 0f);
                Vector2 gridPos = new Vector2(x, y);
                var cell = new Cell(worldPos, gridPos, index++);
                cells.Add(cell);
            }
        }
    }

    protected void GenerateVirtualQuadralXZGrid(VirtualQuadralGridSettings gridSettings)
    {
        uint index = 0;
        int height = gridSettings.Height;
        int width = gridSettings.Width;

        float widthOffset = gridSettings.WidthOffset;
        float heightOffset = gridSettings.HeightOffset;

        Vector3 initialPos = gridSettings.InitialPos;

        for (int z = 0; z < height; z++)
        {
            for (int x = 0; x < width; x++)
            {
                Vector3 worldPos = initialPos + new Vector3(x * widthOffset, 0f, z * heightOffset);
                Vector2 gridPos = new Vector2(x, z);
                var cell = new Cell(worldPos, gridPos, index++);
                cells.Add(cell);
            }
        }
    }

    protected void GenerateVirtualHexagonalXYGrid(VirtualHexagonalGridSettings gridSettings)
    {
        uint index = 0;
        int height = gridSettings.Height;
        int width = gridSettings.Width;

        float widthOffset = gridSettings.WidthOffset;
        float heightOffset = gridSettings.HeightOffset;
        float hexagonalOffset = gridSettings.HexagonalOffset;

        Vector3 initialPos = gridSettings.InitialPos;

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                Vector3 worldPos = initialPos + new Vector3(x * widthOffset + (y % 2 * hexagonalOffset), y * heightOffset, 0f);
                Vector2 gridPos = new Vector2(x, y);
                var cell = new Cell(worldPos, gridPos, index++);
                cells.Add(cell);
            }
        }
    }

    protected void GenerateVirtualHexagonalXZGrid(VirtualHexagonalGridSettings gridSettings)
    {
        uint index = 0;
        int height = gridSettings.Height;
        int width = gridSettings.Width;

        float widthOffset = gridSettings.WidthOffset;
        float heightOffset = gridSettings.HeightOffset;
        float hexagonalOffset = gridSettings.HexagonalOffset;

        Vector3 initialPos = gridSettings.InitialPos;

        for (int z = 0; z < height; z++)
        {
            for (int x = 0; x < width; x++)
            {
                Vector3 worldPos = initialPos + new Vector3(x * widthOffset + (z % 2 * hexagonalOffset), 0f, z * heightOffset);
                Vector2 gridPos = new Vector2(x, z);
                var cell = new Cell(worldPos, gridPos, index++);
                cells.Add(cell);
            }
        }
    }
}
