using UnityEngine;

public static class SimpleGridUtility
{
    public static Vector3 GetPlane(GridCoords gridCoords)
    {
        switch (gridCoords)
        {
            case GridCoords.PositiveXZ:
                return PositiveXZ();
            case GridCoords.PositiveXY:
                return PositiveXY();
            case GridCoords.NegativeXZ:
                return NegativeXZ();
            case GridCoords.NegativeXY:
                return NegativeXY();
            default:
                return Vector3.zero;
        }
    }

    public static Vector3 GetCanvasRotation(GridCoords gridCoords)
    {
        switch (gridCoords)
        {
            case GridCoords.PositiveXZ:
                return new Vector3(90f, 0f, 0f);
            case GridCoords.PositiveXY:
                return new Vector3(0f, 0f, 0f);
            case GridCoords.NegativeXZ:
                return new Vector3(90f, 0f, 0f);
            case GridCoords.NegativeXY:
                return new Vector3(0f, 0f, 0f);
            default:
                return Vector3.zero;
        }
    }

    private static Vector3 PositiveXZ()
    {
        return new Vector3(1f, 0f, 1f);
    }

    private static Vector3 PositiveXY()
    {
        return new Vector3(1f, 1f, 0f);
    }

    private static Vector3 NegativeXZ()
    {
        return new Vector3(-1f, 0f, -1f);
    }

    private static Vector3 NegativeXY()
    {
        return new Vector3(-1f, -1f, 0f);
    }
}
