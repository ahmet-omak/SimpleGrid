using UnityEngine;

[CreateAssetMenu(menuName = "Simple Grid/Hexagonal Grid Settings", fileName = "Hexagonal Grid Settings", order = 1)]
public class HexagonalGridSettings : BaseGridSettings
{
    [SerializeField, Space(5f)] float hexagonalOffset = 1f;

    public float HexagonalOffset { get => hexagonalOffset; }

    protected override Vector3 MapToGridPlane(int w, float width, int h, float height)
    {
        return new Vector3(w * width + (h % 2 * hexagonalOffset), h * height, h * height);
    }
}
