using UnityEngine;

namespace Movement
{
    public class CameraRotation : MonoBehaviour
    {

    
        public float mouseSensitivity = 100f;
        public Transform playerBody;
        float _xRotation = 0f;
        // float yRotation = 0f;

        // Start is called before the first frame update
        void Start()
        {
            Cursor.lockState = CursorLockMode.Locked;
        }

        // Update is called once per frame
        void Update()
        {
            float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        
        
            _xRotation -= mouseY;
            // yRotation -= mouseX;
            _xRotation = Mathf.Clamp(_xRotation, -90f, 90f);
        
            transform.localRotation = Quaternion.Euler(_xRotation, 0f, 0f);
            playerBody.Rotate(Vector3.up * mouseX);

        }
    }
}
