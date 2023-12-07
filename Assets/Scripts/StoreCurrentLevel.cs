using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreCurrentLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetFloat("Completes", 0);
        PlayerPrefs.SetString("FinalTime", "0");
        PlayerPrefs.SetString("FinalScore", "0");
        PlayerPrefs.SetFloat("ScoreVal", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
