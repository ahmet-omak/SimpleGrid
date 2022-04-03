using UnityEngine;

[CreateAssetMenu(menuName = "Hyper Utilities/Hexagonal Grid Settings", fileName = "Hexagonal Grid Settings")]
public class HexagonalGridSettings : BaseGridSettings
{
    [Header("HEXAGONAL SETTINGS")]
    [SerializeField, Space(2f)] GameObject gridPrefab = null;
    [SerializeField, Space(2f)] string parentName = "Grid Parent";
    [SerializeField, Space(2f)] string childName = "Grid Child";
    [SerializeField] float hexagonalOffset = 1f;

    public GameObject GridPrefab { get => gridPrefab; }
    public string ParentName { get => parentName; }
    public string ChildName { get => childName; }
    public float HexagonalOffset { get => hexagonalOffset; }
}
