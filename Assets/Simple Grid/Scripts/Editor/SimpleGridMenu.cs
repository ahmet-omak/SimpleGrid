#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

namespace CPPBENDER.SimpleGrid
{
    public static class SimpleGridMenu
    {
        [MenuItem("Window/Simple Grid/Create a test grid", false, 200)]
        public static void AddSimpleGridObject()
        {
            var grid = (BaseGrid)AssetDatabase.LoadAssetAtPath(WhereIs("Test Grid"), typeof(BaseGrid));
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
#endif
}