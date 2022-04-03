using UnityEditor;
using UnityEngine;

public static class SimpleGridMenu
{
    [MenuItem("Window/Simple Grid/Create Simple Grid Object", false, 200)]
    public static void AddSimpleGridObject()
    {
        if (Object.FindObjectOfType(typeof(GridManager)) == null)
        {
            GameObject go = PrefabUtility.InstantiatePrefab(AssetDatabase.LoadAssetAtPath(WhereIs("GridManager.prefab", "Prefab"), typeof(GameObject))) as GameObject;
            go.name = "Grid Manager";
            Selection.activeObject = go;
            Undo.RegisterCreatedObjectUndo(go, "Created Simple Grid Object");
        }
        else
        {
            Debug.LogWarning("A Simple Grid object already exists in this scene - you should never have more than one per scene!");
        }
    }

    private static string WhereIs(string file, string type)
    {
        string[] guids = AssetDatabase.FindAssets("t:" + type);
        foreach (string guid in guids)
        {
            string prefab = AssetDatabase.GUIDToAssetPath(guid);
            if (prefab.EndsWith(file))
            {
                return prefab;
            }
        }
        return "";
    }
}
