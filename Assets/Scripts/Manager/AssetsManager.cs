using UnityEngine;

namespace Assets.Scripts.Manager
{
    public class AssetsManager : MonoBehaviour
    {

        [Header("Types & Materials")]
        public Mesh[] Meshs;
        public Material[] Materials;

        public Mesh GetRandomMesh()
        {
            if (Meshs.Length == 0)
                return null;
            var random = Random.Range(0, Meshs.Length);
            return Meshs[random];
        }

        public Material GetRandomMaterial()
        {
            if (Materials.Length == 0)
               return null;
            var random = Random.Range(0, Materials.Length);
            return Materials[random];
        }

    }
}
