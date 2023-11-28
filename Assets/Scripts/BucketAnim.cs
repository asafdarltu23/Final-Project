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
            agua.gameObject.SetActive(true);
            hb.gameObject.SetActive(true);
            yield return new WaitForSeconds(waitTime);
            anim.SetBool("Go", false);
            agua.gameObject.SetActive(false);
            hb.gameObject.SetActive(false);
        }
    }
}