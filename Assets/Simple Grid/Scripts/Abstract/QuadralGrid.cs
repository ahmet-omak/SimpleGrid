using UnityEngine;

[CreateAssetMenu(menuName = "Simple Grid/Quadral Grid", fileName = "Quadral Grid", order = 0)]
public class QuadralGrid : BaseGrid
{
    protected override Vector3 GetPos(int w, float width, int h, float height)
    {
        return new Vector3(w * width, 0f, h * height);
    }
}
