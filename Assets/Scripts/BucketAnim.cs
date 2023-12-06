using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketAnim : MonoBehaviour
{
    public Animator anim;
    public ParticleSystem agua;
    public Transform hb;
    private float waitTime = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitOn());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator WaitOn()
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            anim.SetBool("Go", true);
            yield return new WaitForSeconds(waitTime);
            anim.SetBool("Go", false);
        }
    }

    //Remember to have this script in the actual bucket object being animated to be able to access these functions in the events tab
    public void ActivateHB()
    {
        agua.gameObject.SetActive(true);
        hb.gameObject.SetActive(true);
    }

    public void DeactivateHB()
    {
        agua.gameObject.SetActive(false);
        hb.gameObject.SetActive(false);
    }
}
