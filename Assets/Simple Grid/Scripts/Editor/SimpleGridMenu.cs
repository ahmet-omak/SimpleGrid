using UnityEditor;
using UnityEngine;

public static class SimpleGridMenu
{
    [MenuItem("Window/Simple Grid/Create SimpleGrid Object", false, 200)]
    public static void AddSimpleGridObject()
    {
        var grid = (BaseGridSettings)AssetDatabase.LoadAssetAtPath(WhereIs("test-grid-settings"), typeof(BaseGridSettings));
        grid.Create();
    }

    private static string WhereIs(string fileName)
    {
        string[] guids = AssetDatabase.FindAssets(fileName);

        foreach (string guid in guids)
        {
            string path = AssetDatabase.GUIDToAssetPath(guid);
            if (path.EndsWith(".asset"))
            {
                return path;
            }
        }
        Debug.Log("Could not find the asset");
        return "";
    }
}
