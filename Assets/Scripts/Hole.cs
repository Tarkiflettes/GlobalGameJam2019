using Assets.Scripts.Player;
using UnityEngine;

namespace Assets.Scripts
{
    public class Hole : MonoBehaviour
    {

        private void Start()
        {
        
        }
        
        private void Update()
        {
        
        }

        private void OnCollisionEnter(Collision collision)
        {
            var playerController = collision.gameObject.GetComponent<PlayerController>();
            if (playerController == null)
                return;
            if (SameType(playerController) == false)
                return;
            OpenForPlayer(playerController);
        }

        private void OpenForPlayer(PlayerController playerController)
        {
        }

        private bool SameType(PlayerController playerController)
        {
            return true;
        }

    }
}
