using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class CameraReturn : MonoBehaviour
{
    public GameObject Camera;
    public GameObject Player;
    public float Degrees;
    [Tooltip("Leave 0 to ignore that plane, change to positive value to apply to that plane")]
    public Vector3 Direction;

    public static bool Triggered;
    public static bool ResetCam;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (ResetCam == true)
        {
            Triggered = false;
        }
        //Debug.Log(Triggered);
        //Debug.Log(ExitTrigger);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && Triggered == true)
        {
            Camera.transform.RotateAround(Player.transform.position, Direction, Degrees);
            Triggered = true;
        }
        else if (other.CompareTag("Player") && Triggered == false)
        {
            Triggered = false;
        }
    }
}
