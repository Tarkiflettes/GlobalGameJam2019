using UnityEngine;

namespace Assets.Scripts.Player
{
    public class PlayerController : MonoBehaviour
    {

        public float Speed;
        public bool IsMoving;
        public int PlayerNumber;
        public Joystick Joystick { get; private set; }

        private Rigidbody _rigidbody;

        private void Start()
        {
            Joystick = new Joystick(PlayerNumber);
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void FixedUpdate()
        {
            var axisHorizontal = Input.GetAxisRaw(Joystick.Horizontal);
            var axisVertical = Input.GetAxisRaw(Joystick.Vertical);
            Move(axisHorizontal, axisVertical);
        }

        private void Move(float axisHorizontal, float axisVertical)
        {
            var moveDirection = new Vector3(axisHorizontal, 0, axisVertical).normalized;
            var velocity = _rigidbody.velocity;
            velocity.x = moveDirection.x * Speed;
            velocity.z = moveDirection.z * Speed;
            _rigidbody.velocity = velocity;
        }

    }
}
