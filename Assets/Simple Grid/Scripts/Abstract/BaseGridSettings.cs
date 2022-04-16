using System.Collections.Generic;
using UnityEngine;

public abstract class BaseGridSettings : ScriptableObject
{
    [SerializeField, Space(5f)] Vector3 initialPos = Vector3.zero;
    [SerializeField, Space(5f)] Grid gridPrefab = null;
    [SerializeField, Space(5f)] int width = 5;
    [SerializeField, Space(5f)] int height = 5;
    [SerializeField, Space(5f)] float widthOffset = 2f;
    [SerializeField, Space(5f)] float heightOffset = 2f;
    [SerializeField, Space(5f)] string parentName = "Grid";
    [SerializeField, Space(5f)] string childName = "Cell";
    [SerializeField, Space(5f)] List<Cell> cells;

    private int size;

    public Vector3 InitialPos { get => initialPos; }
    public int Width { get => width; }
    public int Height { get => height; }
    public float WidthOffset { get => widthOffset; }
    public float HeightOffset { get => heightOffset; }
    public string ParentName { get => parentName; }
    public string ChildName { get => childName; }
    public Grid GridPrefab { get => gridPrefab; }
    public List<Cell> Cells { get => cells; protected set => cells = value; }
    public int Size { get => width * height; }

    public abstract Vector3 GetGridPos(int w, float width, int h, float height);

    public void InitGrid()
    {
        var gridParent = new GameObject(ParentName);

        int index = 0;

        Cells = new List<Cell>();

        for (int h = 0; h < Height; h++)
        {
            for (int w = 0; w < Width; w++)
            {
                Vector3 worldPos = InitialPos + GetGridPos(w, widthOffset, h, heightOffset);
                Vector2 gridPos = new Vector2(w, h);

                var grid = Instantiate(GridPrefab, worldPos, Quaternion.identity);
                grid.SetText(index).SetName(ChildName + $"{index}").SetParent(gridParent.transform);

                var cell = new Cell();
                cell.SetIndex(index).SetWorldPos(worldPos).SetGridPos(gridPos);

                Cells.Add(cell);
                index++;
            }
        }
    }
}
