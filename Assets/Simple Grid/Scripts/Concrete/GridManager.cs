using UnityEngine;

public class GridManager : BaseGridManager
{
    public BaseGridSettings gridSettings;

    private void Awake()
    {
        InitGrid(gridSettings);
    }

    /// <summary>
    /// Initialize grid according to the given grid settings
    /// </summary>
    /// <param name="gridSettings"></param>
    public  void InitGrid(BaseGridSettings gridSettings)
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
}
