using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Simple Grid/Quadral XY Grid Settings", fileName = "Quadral XY Grid Settings", order = 1)]
public class QuadralXYGridSettings : BaseGridSettings
{
    public override Vector3 GetGridPos(int w, float width, int h, float height)
    {
        return new Vector3(w * width, h * height, 0f);
    }
}
