using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Death : MonoBehaviour
{
    public static bool dead;
    public Transform playerObject;
    public Vector3 startPoint;
    Rigidbody rb;
    //public Transform Camera;
    //private Vector3 CamPosOrig;
    //private Quaternion CamRotOrig;
    // Start is called before the first frame update
    void Start()
    {
        //CamPosOrig = Camera.transform.position;
        //CamRotOrig = Camera.transform.rotation;
        rb = playerObject.GetComponent<Rigidbody>();
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
            //Camera.transform.position = CamPosOrig;
            //Camera.transform.rotation = CamRotOrig;
            //CameraTurn.ResetCam = true;
            dead = false;
        }
    }

    public void Kill()
    {
        rb.velocity = Vector3.zero;
        playerObject.transform.position = startPoint;
        Debug.Log("Reset");
    }
}


