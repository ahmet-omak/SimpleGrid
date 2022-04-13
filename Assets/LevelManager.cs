using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public BaseGridSettings grid;

    private void Start()
    {
        grid.InitGrid();
    }
}
