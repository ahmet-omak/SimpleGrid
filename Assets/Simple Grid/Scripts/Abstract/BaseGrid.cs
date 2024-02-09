using System.Collections.Generic;
using UnityEngine;

namespace CPPBENDER.SimpleGrid
{
    public abstract class BaseGrid : ScriptableObject
    {
        [SerializeField, Space(5f)] Vector3 initialPos = Vector3.zero;
        [SerializeField, Space(5f)] GameObject gridPrefab = null;
        [SerializeField, Space(5f)] int width = 5;
        [SerializeField, Space(5f)] int height = 5;
        [SerializeField, Space(5f)] float widthOffset = 2f;
        [SerializeField, Space(5f)] float heightOffset = 2f;
        [SerializeField, Space(5f)] string parentName = "Grid";
        [SerializeField, Space(5f)] string childName = "Cell";

        private List<Cell> cells;
        private int size;

        public Vector3 InitialPos { get => initialPos; }
        public int Width { get => width; }
        public int Height { get => height; }
        public float WidthOffset { get => widthOffset; }
        public float HeightOffset { get => heightOffset; }
        public List<Cell> Cells { get => cells; protected set => cells = value; }
        public int Size { get => size; }

        protected abstract Vector3 GetPos(int w, float width, int h, float height);

        public void Create()
        {
            var gridParent = new GameObject(parentName);
            int index = 0;
            Cells = new List<Cell>();
            for (int h = 0; h < Height; h++)
            {
                for (int w = 0; w < Width; w++)
                {
                    Vector3 worldPos = InitialPos + GetPos(w, widthOffset, h, heightOffset);
                    Instantiate(gridPrefab, worldPos, Quaternion.identity, gridParent.transform);
                    var cell = new Cell();
                    cell.SetIndex(index).SetWorldPos(worldPos).SetGridPos(new Vector2(w, h));
                    Cells.Add(cell);
                    index++;
                }
            }
        }
    }
}