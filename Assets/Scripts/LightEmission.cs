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
        if (Input.GetKey(KeyCode.Mouse1))
        {
            lighting.range = lightrange;
            rb.velocity = new Vector3(0, rb.velocity.y, 0);
            DustPart.gameObject.SetActive(true);
        }
        else
        {
            lighting.range = 5;
            DustPart.gameObject.SetActive(false);
        }
    }
}
