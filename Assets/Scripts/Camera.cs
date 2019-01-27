using Assets.Scripts.Player;
using UnityEngine;

namespace Assets.Scripts
{
    public class Camera : MonoBehaviour
    {
        
        public float Offset = 3.5f;

        private PlayerController _playerController;

        private void Start()
        {
            _playerController = FindObjectOfType<PlayerController>();
        }

        private void Update()
        {
            transform.position = new Vector3(transform.position.x, _playerController.gameObject.transform.position.y + Offset, transform.position.z);
        }
        
    }
}
