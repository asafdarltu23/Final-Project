using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public static bool dead;
    public Transform playerObject;
    public Vector3 startPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y < -15)
        {
            dead = true;

        }
        if (dead == true)
        {
            Kill();
            dead = false;
        }
    }

    public void Kill()
    {
        playerObject.transform.position = startPoint;
        Rigidbody rb = playerObject.GetComponent<Rigidbody>();
        rb.velocity = Vector3.zero;
        Debug.Log("Reset");
    }
}


