using Assets.Scripts.Player;
using UnityEngine;

namespace Assets.Scripts
{
    public class Hole : MonoBehaviour
    {

        private Type _type;

        private void Start()
        {
            _type = GetComponent<Type>();
        }
        
        private void Update()
        {
        
        }

        private void OnCollisionEnter(Collision collision)
        {
            var playerController = collision.gameObject.GetComponent<PlayerController>();
            if (playerController == null)
                return;
            var typePlayerController = playerController.GetComponent<Type>();
            if (_type.Equals(typePlayerController))
                return;
            OpenForPlayer(playerController);
        }

        private void OpenForPlayer(PlayerController playerController)
        {
        }

    }
}
