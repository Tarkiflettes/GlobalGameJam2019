using UnityEngine;

namespace Assets.Scripts
{
    public class Camera : MonoBehaviour
    {

        public float Speed = 100;

        private void Start()
        {

        }

        private void Update()
        {

        }

        public void GoDown()
        {
            transform.position += Vector3.forward * Time.deltaTime * Speed;
        }
    }
}
