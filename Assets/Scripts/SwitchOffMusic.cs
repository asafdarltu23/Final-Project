using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchOffMusic : MonoBehaviour
{
    public AudioSource audioPlayer;
    public AudioSource MusicToStop;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            MusicToStop.Stop();
            audioPlayer.Play();
        }
    }
}
