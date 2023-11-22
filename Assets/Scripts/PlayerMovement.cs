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

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {


        float xMov = -Input.GetAxis("Vertical");
        float zMov = Input.GetAxis("Horizontal");

        rb.velocity = new Vector3(xMov * speed, rb.velocity.y, zMov * speed);

        if (Input.GetButtonDown("Jump") &&
            Physics.Raycast(this.transform.position + raycastOriginOffSet, -Vector3.up, minfloorDistance))
        {
            rb.AddForce(Vector3.up * jumpForce * 100);

        }
    }
}
