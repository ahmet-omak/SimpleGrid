using UnityEngine;

public class GridManager : MonoBehaviour
{
    public BaseGridSettings gridSettings;

    private void Start()
    {
        gridSettings.InitGrid();
    }
}
