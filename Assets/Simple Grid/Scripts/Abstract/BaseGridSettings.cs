using UnityEngine;

public abstract class BaseGridSettings : ScriptableObject
{
    [Header("BASE SETTINGS"), Space(2f)]
    [SerializeField, Space(2f)] Vector3 initialPos = Vector3.zero;
    [SerializeField, Space(2f)] GridCoords gridCoord = GridCoords.XZPlane;
    [SerializeField, Space(2f)] int width = 5;
    [SerializeField, Space(2f)] int height = 5;
    [SerializeField, Space(2f)] float widthOffset = 2f;
    [SerializeField, Space(2f)] float heightOffset = 2f;

    public Vector3 InitialPos { get => initialPos; }
    public int Width { get => width; }
    public int Height { get => height; }
    public float WidthOffset { get => widthOffset; }
    public float HeightOffset { get => heightOffset; }
    public GridCoords GridCoords { get => gridCoord; }
}
