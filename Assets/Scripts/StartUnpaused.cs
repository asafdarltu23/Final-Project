using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StartUnpaused : MonoBehaviour
{
    // To guarantee unpaused
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
