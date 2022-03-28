using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public QuadralGridSettings gridSettings;

    private void Start()
    {
        FindObjectOfType<GridManager>().InitQuadralGrid(gridSettings);
    }
}
