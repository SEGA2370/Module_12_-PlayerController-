    using UnityEngine;

    namespace WildBall.Inputs
    {
        [RequireComponent(typeof(Rigidbody))]

        public class PlayerMovement : MonoBehaviour
        {
            [SerializeField, Range(0, 10)] private float speed = 2.0f;
            [SerializeField] private float jumpForce = 5.0f;

            private Rigidbody playerRigidbody;
            private bool floorCollider = true;

            private void Awake()
            {
                playerRigidbody = GetComponent<Rigidbody>();
            }

            public void MoveCharacter(Vector3 movement)
            {
                if (Input.GetButtonDown(GlobalStringVariable.JUMP_BUTTON) && floorCollider == true)
                {
                    playerRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                    floorCollider = false;
                }
                playerRigidbody.AddForce(movement * speed);
            }

            private void OnCollisionEnter(Collision collision)
            {
                if (collision.gameObject.CompareTag("FloorCollider")) 
                {
                    floorCollider = true;
                }
            }

    #if UNITY_EDITOR
            [ContextMenu("Reset Values")]
            public void ResetValues()
            {
                speed = 2.0f;
            }
    #endif

        }
    }