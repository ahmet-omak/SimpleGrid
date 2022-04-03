using UnityEngine;

[CreateAssetMenu(menuName = "Hyper Utilities/Quadral Grid Settings", fileName = "Quadral Grid Settings")]
public class QuadralGridSettings : BaseGridSettings
{
    [Header("QUADRAL SETTINGS")]
    [SerializeField, Space(2f)] GameObject gridPrefab = null;
    [SerializeField, Space(2f)] string parentName = "Grid Parent";
    [SerializeField, Space(2f)] string childName = "Grid Child";

    public GameObject GridPrefab { get => gridPrefab; }
    public string ParentName { get => parentName; }
    public string ChildName { get => childName; }
}
