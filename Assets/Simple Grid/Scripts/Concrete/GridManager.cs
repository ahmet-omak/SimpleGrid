using UnityEngine;

public class GridManager : MonoBehaviour
{
    public BaseGridSettings grid;

    private void Start()
    {
        grid.InitGrid();
    }
}
