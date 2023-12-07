using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapScript : MonoBehaviour
{
    bool isColliding;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (isColliding) return;
            isColliding = true;
            Death.dead = true;

            StartCoroutine(Reset());
        }
    }

    IEnumerator Reset()
    {
        yield return new WaitForEndOfFrame();
        isColliding = false;
    }
}
