using UnityEngine;

[CreateAssetMenu(menuName = "Simple Grid/Hexagonal XZ Grid Settings", fileName = "Hexagonal XZ Grid Settings", order = 2)]
public class HexagonalXZGridSettings : BaseGridSettings
{
    [SerializeField, Space(5f)] float hexagonalOffset = 1f;

    public float HexagonalOffset { get => hexagonalOffset; }

    public override Vector3 GetGridPos(int w, float width, int h, float height)
    {
       return new Vector3(w * width + (h % 2 * hexagonalOffset), 0f, h * height);
    }
}
