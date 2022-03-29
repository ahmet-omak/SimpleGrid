using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GridManager gridManager;
    public QuadralGridSettings gridSettings;

    private void Start()
    {
        gridManager.InitQuadralGrid(gridSettings);
    }
}
