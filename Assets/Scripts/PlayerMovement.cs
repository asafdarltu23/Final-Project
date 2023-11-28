using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    Rigidbody rb;

    public float minfloorDistance;
    public Vector3 raycastOriginOffSet;

    //public static float xMov;
    //public static float zMov;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {

        PlayerMoveRelative(speed);
        if(Input.GetAxis("Horizontal") == 0)
        {
            rb.velocity = new Vector3(0, rb.velocity.y, rb.velocity.z);
        }
        if(Input.GetAxis("Vertical") == 0)
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, 0);
        }
        /*xMov = Input.GetAxis("Horizontal");
        zMov = Input.GetAxis("Vertical");

        

        rb.velocity = new Vector3(xMov * speed, rb.velocity.y, zMov * speed);*/

        if (Input.GetButtonDown("Jump") &&
            Physics.Raycast(this.transform.position + raycastOriginOffSet, -Vector3.up, minfloorDistance))
        {
            rb.AddForce(Vector3.up * jumpForce * 100);

        }
    }

    void PlayerMoveRelative(float SPD)
    {
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

        this.transform.Translate(camRelMov, Space.World);
    }
}
