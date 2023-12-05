using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinalStats : MonoBehaviour
{
    public TextMeshProUGUI TimeDisplay;
    public TextMeshProUGUI ScoreDisplay;
    // Start is called before the first frame update
    void Start()
    {
        TimeDisplay.text = "00:00:00";
        TimeDisplay.text = PlayerPrefs.GetString("Time");
        ScoreDisplay.text = "x0";
        ScoreDisplay.text = "x" + PlayerPrefs.GetString("Score");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
