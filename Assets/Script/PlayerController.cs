using UnityEngine;

namespace WildBall.Inputs
{

    [RequireComponent(typeof(PlayerMovement))]

    public class PlayerController : MonoBehaviour
    {
        private Vector3 movement;
        private PlayerMovement playerMovement;

        private void Awake()
        {
            playerMovement = GetComponent<PlayerMovement>();
        }

        void FixedUpdate()
        {
            float horizontal = Input.GetAxis(GlobalStringVariable.HORIZONTAL_AXIS);
            float vertical = Input.GetAxis(GlobalStringVariable.VERTICAL_AXIS);        
            movement = new Vector3(-horizontal, 0, -vertical).normalized;
            playerMovement.MoveCharacter(movement);
        }
    }
}
