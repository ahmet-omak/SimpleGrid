using UnityEngine;

[CreateAssetMenu(menuName = "Simple Grid/Quadral Grid Settings", fileName = "Quadral Grid Settings", order = 0)]
public class QuadralGridSettings : BaseGridSettings
{
    protected override Vector3 GetPos(int w, float width, int h, float height)
    {
        return new Vector3(w * width, 0f, h * height);
    }
}
