using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    Collider col;
    //public AudioSource player;
    //public AudioClip sound;

    // Start is called before the first frame update
    void Start()
    {
        //player.clip = sound;
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //player.Play();
            Score.Instance.AddScore(1);
            gameObject.SetActive(false);
            this.gameObject.GetComponent<Collider>().enabled = false;
        }
    }
}
