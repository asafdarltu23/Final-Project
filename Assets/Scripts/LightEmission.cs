using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LightEmission : MonoBehaviour
{
    Light lighting;
    public float lightrange;
    public ParticleSystem DustPart;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        lighting = this.gameObject.GetComponent<Light>();
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            lighting.range = lightrange;
            PlayerMovement.LightEmitting = true;
            DustPart.gameObject.SetActive(true);
        }
        else
        {
            lighting.range = 10;
            DustPart.gameObject.SetActive(false);
            PlayerMovement.LightEmitting = false;
        }
    }
}
