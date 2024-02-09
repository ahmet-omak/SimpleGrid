using UnityEngine;

namespace CPPBENDER.SimpleGrid
{
    [CreateAssetMenu(menuName = "Simple Grid/Hexagonal Grid", fileName = "Hexagonal Grid", order = 1)]
    public class HexagonalGrid : BaseGrid
    {
        [SerializeField, Space(5f)] float hexagonalOffset = 1f;

        public float HexagonalOffset { get => hexagonalOffset; }

        protected override Vector3 GetPos(int w, float width, int h, float height)
        {
            return new Vector3(w * width + (h % 2 * hexagonalOffset), 0f, h * height);
        }
    }
}