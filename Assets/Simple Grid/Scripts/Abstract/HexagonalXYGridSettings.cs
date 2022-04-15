using UnityEngine;

[CreateAssetMenu(menuName = "Simple Grid/Hexagonal XY Grid Settings", fileName = "Hexagonal XY Grid Settings", order = 3)]
public class HexagonalXYGridSettings : BaseGridSettings
{
    [SerializeField, Space(5f)] float hexagonalOffset = 1f;

    public float HexagonalOffset { get => hexagonalOffset; }

    public override Vector3 GetGridPos(int w, float width, int h, float height)
    {
        return new Vector3(w * width + (h % 2 * hexagonalOffset), h * height, 0f);
    }
}
