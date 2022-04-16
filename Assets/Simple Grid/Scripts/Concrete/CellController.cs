using UnityEngine;
using TMPro;

public class CellController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textMesh;

    public void SetText(int text)
    {
        textMesh.text = text.ToString();
    }
}
