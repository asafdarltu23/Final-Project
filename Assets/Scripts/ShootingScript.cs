using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    public Transform projectile;
    public float Fuel;
    public float fireRate;
    float fireCooldown = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fireCooldown += Time.deltaTime;
        if(fireCooldown > fireRate && Input.GetKey(KeyCode.Mouse1))
        {
            Shoot();
            fireCooldown = 0;
        }
    }

    void Shoot()
    {
        //Vector3 extend = new Vector3(5, 0, 0);
        Instantiate(projectile, transform.position, Quaternion.identity);
    }
}
