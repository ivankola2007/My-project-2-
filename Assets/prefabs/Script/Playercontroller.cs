using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
     private const float gravityScale = 9.8f, speedScale = 5f, jumpForce = 8f, turnSpeed = 90f;
     private float verticalSpeed, mouseX, mouseY, currentCameraAngLeX;
     private int invesion = -1;
     [SerializeField]
     private CharacterController characterController;
     [SerializeField]
     private GameObject playerCamera;
     
     

}  
        // Start is called before the first frame update
    private void Start()
    {
       Cursor.visible = false;
       Cursor.lockState = CursorLockMode.Locked;
       controller = GetComponent<CharacterController>();
    }
    private void FixedUptade()
    {
        Rotate();
    }

    // Update is called once per frame
    private void Update()
    {
        Move();
    }
    private void Rotate()
    {
    mouseX = Input.GetAxis ("Mouse X");
    mouseY = Input.GetAxis ("Mouse Y");
    transform.Rotate(new Vector3(Of, mouseX * turnSpeed * Time.fixedDeltaTime, Of));

    currentAngleX += mouseY * turnSpeed * Time.deltaTime-1f;
    currentAngleX = Mathf.Clamp(currentCameraAngleX, -60f, 60f);
    goCamera.transform.localEulerAngles = new Vector3(currentAnglex, Of, Of);
    currentCameraAngleX += mouseX * Time.fixedDeltaTime * turnSpeed * inversion;

    }
    private void Move()
    {
        Vector3 velocity = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        velocity = transform.TransformDirection (velocity) * speedScale;
        if (characterController.isGrounded)
        {

        verticalSpeed = 0f;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            verticalSpeed = jumpForce;
        }
        }
        verticalSpeed -= gravityScale * Time.deltaTime;
        velocity.y = verticalSpeed;
        characterController. Move (velocity * Time.deltaTime);
        
        
    }

