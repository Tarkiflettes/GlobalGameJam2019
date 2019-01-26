using System;
using Assets.Scripts.Manager;
using UnityEngine;

namespace Assets.Scripts
{
    public class Type : MonoBehaviour
    {

        [Header("Equals")]
        public bool Mesh = true;
        public bool Material = true;

        private Mesh _mesh;
        private Material _material;

        private void Start()
        {
            //SetType();

            //_mesh = GetComponentInChildren<Mesh>();
            //_material = GetComponentInChildren<Material>();
            _mesh = GetComponentInChildren<MeshFilter>().mesh;
            _material = GetComponentInChildren<Renderer>().material;
        }
        
        private void SetType()
        {
            _mesh = GameManager.Instance.AssetsManager.GetRandomMesh();
            _material = GameManager.Instance.AssetsManager.GetRandomMaterial();
        }

        public override bool Equals(object obj)
        {
            var type = obj as Type;
            if (type == null)
                return false;
            var mesh = Mesh || (_mesh != null && _mesh.Equals(type._mesh));
            var material = Material || (_material != null && _material.Equals(type._material));
            return mesh && material;
        }

    }
}
