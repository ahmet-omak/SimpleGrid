using UnityEngine;

[CreateAssetMenu(menuName = "Hyper Utilities/Hexagonal Grid Settings", fileName = "Hexagonal Grid Settings")]
public class HexagonalGridSettings : BaseGridSettings
{
    [SerializeField] float hexagonalOffset = 1f;

    public float HexagonalOffset { get => hexagonalOffset; }
}
