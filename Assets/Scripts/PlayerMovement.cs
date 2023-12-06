using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //public CharacterController characterController;
    //public Transform camera;
    //public float turnSmoothTime = 0.1f;
    //float turnSmoothVelocity;

    public Transform orientation;
    float horInput;
    float vertInput;
    Vector3 moveDirect;
    //public float playerHeight;
   // bool grounded;
   // public float groundDrag;

    public float speed;
    public float jumpForce;
    Rigidbody rb;

    public float minfloorDistance;
    public Vector3 raycastOriginOffSet;

    public static bool LightEmitting;

    //public static float xMov;
    //public static float zMov;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        /*grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.2f);
        if (grounded)
        {
            rb.drag = groundDrag;
        }
        else
            rb.drag = 0;*/

        if (LightEmitting == false)
        {
            PlayerMoveRelative();
            /*float xMov = Input.GetAxis("Horizontal");
            float zMov = Input.GetAxis("Vertical");



            rb.velocity = new Vector3(xMov * speed, rb.velocity.y, zMov * speed); */
        }
        if (LightEmitting == true)
        {
            rb.velocity = new Vector3(0, rb.velocity.y, 0);
        }
        /*if(Input.GetAxis("Horizontal") == 0)
        {
            rb.velocity = new Vector3(0, rb.velocity.y, rb.velocity.z);
        }
        if(Input.GetAxis("Vertical") == 0)
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, 0);
        }*/
        
        //no slidey movement
        if (Physics.Raycast(this.transform.position + raycastOriginOffSet, -Vector3.up, minfloorDistance))
        {
            rb.drag = 5;
        }
        else
            rb.drag = 0;
        

        if (Input.GetButtonDown("Jump") &&
            Physics.Raycast(this.transform.position + raycastOriginOffSet, -Vector3.up, minfloorDistance))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    void PlayerMoveRelative(/*float SPD*/)
    {
        /* First Try
         float xMovInput = Input.GetAxis("Horizontal");
         float zMovInput = Input.GetAxis("Vertical");

         Vector3 forward = Camera.main.transform.forward;
         Vector3 right = Camera.main.transform.right;
         forward.y = 0;
         right.y = 0;
         forward = forward.normalized;
         right = right.normalized;

         Vector3 rightRxMov = xMovInput * right;
         Vector3 forwardRzMov = zMovInput * forward;

         Vector3 camRelMov = ((forwardRzMov + rightRxMov)/250) * SPD;
         camRelMov.y = 0;

         this.transform.Translate(camRelMov, Space.World);*/

        /* Second Try
         float horiz = Input.GetAxisRaw("Horizontal");
         float vert = Input.GetAxisRaw("Vertical");
         Vector3 direction = new Vector3(horiz, 0f, vert).normalized;

         if (direction.magnitude >= 0.1f)
         {
             float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + camera.eulerAngles.y;
             float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
             transform.rotation = Quaternion.Euler(0f, angle, 0f);

             Vector3 movDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
             characterController.Move(movDir.normalized * speed * Time.deltaTime);
         }*/

        horInput = Input.GetAxisRaw("Horizontal");
        vertInput = Input.GetAxisRaw("Vertical");

        moveDirect = (orientation.forward * vertInput) + (orientation.right * horInput);
        rb.AddForce(moveDirect.normalized * speed * 10f, ForceMode.Force);

        Vector3 flatVel = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        if(flatVel.magnitude > speed)
        {
            Vector3 limitedVel = flatVel.normalized * speed;
            rb.velocity = new Vector3(limitedVel.x, rb.velocity.y, limitedVel.z);
        }
    }
}
