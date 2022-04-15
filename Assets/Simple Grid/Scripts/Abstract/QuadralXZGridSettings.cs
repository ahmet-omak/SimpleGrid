using UnityEngine;

[CreateAssetMenu(menuName = "Simple Grid/Quadral XZ Grid Settings", fileName = "Quadral XZ Grid Settings", order = 0)]
public class QuadralXZGridSettings : BaseGridSettings
{
    public override Vector3 GetGridPos(int w, float width, int h, float height)
    {
        return new Vector3(w * width, 0f, h * height);
    }
}
