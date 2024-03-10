using Custom_Assets;
using UnityEngine;

namespace Movement
{
    public class PlayerMovement : MonoBehaviour
    {
        
        public CharacterController controller;
        public float playerSpeed = 1f;
        public float gravity = -9.81f;
        public float jumpHeight = 5f;
        
        public ROKVector3 velocity;
        
        public Transform groundCheck;
        public float groundDistance = 0.2f;
        public LayerMask groundMask;
        bool isGrounded;
        
        // Start is called before the first frame update
        void Start()
        {
            // rb =  gameObject.GetComponent<Rigidbody>();
        }

        //ORIGINAL
        void Update()
        {
            
            float  moveZ = Input.GetAxis("Vertical");
            float  moveX = Input.GetAxis("Horizontal");
            
            Vector3 move = transform.right * moveX + transform.forward * moveZ;
            
            controller.Move(move * (playerSpeed * Time.deltaTime));
        
            Jump();
        }
        
        
        // //MyVector
        // void Update()
        // {
        //     ROKVector3 currentPos = transform.position;
        //     ROKVector3 currentRotation = transform.rotation.eulerAngles;
        //     
        //     float  moveZ = Input.GetAxis("Vertical");
        //     float  moveX = Input.GetAxis("Horizontal");
        //     
        //     ROKVector3 move = transform.right * moveX + transform.forward * moveZ;
        //
        //     ROKVector3 jumpVelocity = Jump();
        //     controller.Move(move * (playerSpeed * Time.deltaTime) + jumpVelocity) ;
        //     
        //     
        // }

        // ORIGINAL
        void Jump()
        {
            isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
            
            if (isGrounded && velocity.y < 0)
            {
                velocity.y = -2f;
            }
            if (Input.GetButtonDown("Jump") && isGrounded)
            {
                velocity.y = jumpHeight * +0.1f * -gravity;
            }
            
            velocity.y += gravity * Time.deltaTime;
            controller.Move(velocity * Time.deltaTime);
        }
        
        
        // public ROKVector3 Jump()
        // {
        //     isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        //     
        //     if (isGrounded && velocity.y < 0)
        //     {
        //         velocity.y = +0.1f;
        //     }
        //     if (Input.GetButtonDown("Jump") && isGrounded)
        //     {
        //         velocity.y = jumpHeight * +0.1f * -gravity;
        //     }
        //     
        //     velocity.y += gravity * Time.deltaTime;
        //     return velocity * Time.deltaTime;
        // }
        
    }
}
