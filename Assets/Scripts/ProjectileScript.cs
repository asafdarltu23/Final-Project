using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    public float speed;
    public float lifetime;
    private float lifetimeCounter;
    public float distance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lifetimeCounter += Time.deltaTime;

        if (lifetimeCounter < distance)
        {
            ProjectileMovement();
        }

        if ( lifetimeCounter > lifetime)
        {
            Destroy(gameObject);
        }
    }

    void ProjectileMovement()
    {
        Vector3 newpos = transform.position;
        newpos += transform.forward * speed * Time.deltaTime;
        transform.position = newpos;
    }
}
