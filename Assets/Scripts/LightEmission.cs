using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightEmission : MonoBehaviour
{
    Light lighting;
    public float lightrange;

    // Start is called before the first frame update
    void Start()
    {
        lighting = this.gameObject.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse1))
        {
            lighting.range = lightrange;
        }
        else
        {
            lighting.range = 5;
        }
    }
}
