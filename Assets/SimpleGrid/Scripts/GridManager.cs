using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] BaseGridSettings gridSettings;

    private void Start()
    {
        gridSettings.InitGrid();
    }
}
