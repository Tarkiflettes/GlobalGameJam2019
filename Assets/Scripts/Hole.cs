using System.Collections;
using Assets.Scripts.Player;
using UnityEngine;

namespace Assets.Scripts
{
    public class Hole : MonoBehaviour
    {

        public float PushForce = 100f;

        private Type _type;

        private void Start()
        {
            _type = GetComponent<Type>();
        }

        private void OnTriggerEnter(Collider collision)
        {
            var playerController = collision.gameObject.GetComponent<PlayerController>();
            if (playerController == null)
                return;
            var typePlayerController = playerController.GetComponent<Type>();
            if (_type.Equals(typePlayerController) == false)
                return;
            Open(playerController);

        }

        private void Open(PlayerController playerController)
        {
            var playerCollider = playerController.GetComponent<Collider>();
            if (playerCollider != null)
                playerCollider.enabled = false;
            StartCoroutine(NextPlatform(playerController));
        }

        private IEnumerator NextPlatform(PlayerController playerController)
        {
            var playerRigidbody = playerController.GetComponent<Rigidbody>();
            if (playerRigidbody != null)
                playerRigidbody.AddForce(new Vector3(0, -10, 0), ForceMode.Impulse);
            yield return new WaitForSeconds(0.5f);
            var playerCollider = playerController.GetComponent<Collider>();
            if (playerCollider != null)
                playerCollider.enabled = true;
        }

    }
}
