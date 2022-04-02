using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GridManager gridManager;
    public BaseGridSettings gridSettings;

    private void Start()
    {
        gridManager.InitGrid(gridSettings);
    }
}
