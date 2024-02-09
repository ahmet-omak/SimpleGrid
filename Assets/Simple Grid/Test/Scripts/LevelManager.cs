using UnityEngine;

namespace CPPBENDER.SimpleGrid
{
    public class LevelManager : MonoBehaviour
    {
        public BaseGrid grid;

        private void Start()
        {
            grid.Create();
        }
    }
}