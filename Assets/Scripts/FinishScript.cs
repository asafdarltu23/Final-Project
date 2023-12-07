using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishScript : MonoBehaviour
{
    public bool Final;
    public AudioSource audioPlayer;
    public AudioClip clip;
  
    //public Transform lightrayObjpos;
    public GameObject lightrayObj;
    public float speed;
    public float endPos;

    bool show = false;
    // Start is called before the first frame update
    void Start()
    {
        //audioPlayer.clip = clip;
    }

    void Update()
    {
        if (show == true)
        {
            lightrayObj.SetActive(true);
            audioPlayer.PlayOneShot(clip);
            lightrayObj.transform.position += -transform.up * Time.deltaTime * speed;
            if(lightrayObj.transform.position.y == endPos)
            {
                SceneManager.LoadScene("Continue");
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && Final)
        {
            show = true;
        }

        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("Continue");
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        
    }
}
