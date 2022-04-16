using UnityEngine;

public class Grid : MonoBehaviour
{
    [SerializeField] GridCanvas gridCanvas;

    public Grid SetText(int count)
    {
        gridCanvas.TextMesh.text = count.ToString();
        return this;
    }

    public Grid SetName(string name)
    {
        gameObject.name = name;
        return this;
    }

    public Grid SetParent(Transform parent)
    {
        transform.SetParent(parent);
        return this;
    }

    public Grid SetCanvasRotation(Vector3 rot)
    {
        gridCanvas.transform.localRotation = Quaternion.Euler(rot);
        return this;
    }
}
