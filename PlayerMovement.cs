using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 20f;
    public float gravityModifer = 2;
    public CharacterController charCon;

    private Vector3 moveInput;

    public Transform camTransform;
    public float mouseSensitivity;
    public bool invertX;
    public bool invertY;

    public Text playerSpeedText;


    // Start is called before the first frame update
    void Start()
    {
        playerSpeedText.text = "0 km/h";
    }

    // Update is called once per frame
    void Update()
    {
        // moveInput.x = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        // moveInput.z = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;

        float yStore = moveInput.y;

        Vector3 verticalMove = transform.forward * Input.GetAxis("Vertical");
        Vector3 horizontalMove = transform.right * Input.GetAxis("Horizontal");

        moveInput = verticalMove + horizontalMove;
        moveInput.Normalize();
        moveInput = verticalMove * moveSpeed;

        moveInput.y = yStore;
        moveInput.y += Physics.gravity.y * gravityModifer * Time.deltaTime;

        if(charCon.isGrounded)
        {
            moveInput.y = Physics.gravity.y * gravityModifer * Time.deltaTime;
        }

        charCon.Move(moveInput * Time.deltaTime);

        Vector2 mouseInput = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
        if(invertX)
        {
            mouseInput.x = -mouseInput.x;
        }
        if(invertY)
        {
            mouseInput.y = -mouseInput.y;
        }

        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + mouseInput.x, transform.rotation.eulerAngles.z);

        camTransform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(mouseInput.y, 0f, 0f));

        playerSpeedText.text = moveSpeed.ToString() + " km/h";
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collided with: " + collision.gameObject.name);
        if(collision.gameObject.tag == "Obstacle")
        {
            PlayerHealth.instance.DamagePlayer(5);
        }
    }

    
}



