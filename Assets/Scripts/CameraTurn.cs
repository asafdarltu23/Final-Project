using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class CameraTurn : MonoBehaviour
{
    public Transform orientation;
    public Transform Player;
    public Transform playerObj;
    public Rigidbody rb;

    public float rotationspeed;
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Death.dead == false)
        {
            Vector3 viewDirect = Player.position - new Vector3(transform.position.x, Player.position.y, transform.position.z);
            orientation.forward = viewDirect.normalized;

            float horiz = Input.GetAxis("Horizontal");
            float vert = Input.GetAxis("Vertical");
            Vector3 inputDirect = (orientation.forward * vert) + (orientation.right * horiz);

            if (inputDirect != Vector3.zero)
            {
                playerObj.forward = Vector3.Slerp(playerObj.forward, inputDirect.normalized, Time.deltaTime * rotationspeed);
            }

        }
    }
}
