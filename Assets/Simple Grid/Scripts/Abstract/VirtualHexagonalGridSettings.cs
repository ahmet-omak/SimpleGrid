using UnityEngine;

[CreateAssetMenu(menuName = "Hyper Utilities/Virtual Hexagonal Grid Settings", fileName = "Virtual Hexagonal Grid Settings")]
public class VirtualHexagonalGridSettings : BaseGridSettings
{
    [Header("Virtual Hexagonal Settings")]
    [SerializeField] float hexagonalOffset = 1f;

    public float HexagonalOffset { get => hexagonalOffset; }
}
