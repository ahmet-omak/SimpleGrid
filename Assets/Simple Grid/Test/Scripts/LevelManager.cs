using UnityEngine;

namespace CPPBENDER.SimpleGrid
{
    public class LevelManager : MonoBehaviour
    {
        public BaseGrid grid0;
        public BaseGrid grid1;

        private void Start()
        {
            grid0.Create();
            grid1.Create();
        }
    }
}