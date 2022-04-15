using UnityEngine;
using TMPro;
public class Grid : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textMeshPro;

    public Grid SetText(int count)
    {
        textMeshPro.text = count.ToString();
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
}
