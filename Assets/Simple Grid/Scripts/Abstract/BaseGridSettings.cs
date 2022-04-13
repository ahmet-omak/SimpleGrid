using System.Collections.Generic;
using UnityEngine;

public abstract class BaseGridSettings : ScriptableObject
{
    [SerializeField, Space(5f)] Vector3 initialPos = Vector3.zero;
    [SerializeField, Space(5f)] GameObject gridPrefab = null;
    [SerializeField, Space(5f)] int width = 5;
    [SerializeField, Space(5f)] int height = 5;
    [SerializeField, Space(5f)] float widthOffset = 2f;
    [SerializeField, Space(5f)] float heightOffset = 2f;
    [SerializeField, Space(5f)] string parentName = "Grid";
    [SerializeField, Space(5f)] string childName = "Cell";
    [SerializeField, Space(5f)] List<Cell> cells;

    public Vector3 InitialPos { get => initialPos; }
    public int Width { get => width; }
    public int Height { get => height; }
    public float WidthOffset { get => widthOffset; }
    public float HeightOffset { get => heightOffset; }
    public string ParentName { get => parentName; set => parentName = value; }
    public string ChildName { get => childName; set => childName = value; }
    public GameObject GridPrefab { get => gridPrefab; set => gridPrefab = value; }
    public List<Cell> Cells { get => cells; protected set => cells = value; }

    public abstract void InitGrid();
}
