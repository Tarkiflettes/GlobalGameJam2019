using System;
using Assets.Scripts.Manager;
using UnityEngine;

namespace Assets.Scripts
{
    public class Type : MonoBehaviour
    {

        private Mesh _mesh;
        private Material _material;

        private void Start()
        {
            SetType();
        }
        
        private void SetType()
        {
            _mesh = GameManager.AssetsManager.GetRandomMesh();
            _material = GameManager.AssetsManager.GetRandomMaterial();
        }

        public override bool Equals(object obj)
        {
            var type = obj as Type;
            if (type == null)
                return false;
            return _mesh.Equals(type._mesh) && _material.Equals(type._material);
        }

    }
}
