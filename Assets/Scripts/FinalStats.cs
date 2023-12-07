using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinalStats : MonoBehaviour
{
    public TextMeshProUGUI TimeDisplay;
    public TextMeshProUGUI ScoreDisplay;
    public TextMeshProUGUI FinalScoreDisplay;
    public TextMeshProUGUI FinalTimeDisplay;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetFloat("Completes", PlayerPrefs.GetFloat("Completes") + 1);
        TimeDisplay.text = "00:00:00";
        TimeDisplay.text = PlayerPrefs.GetString("Time");
        ScoreDisplay.text = "x0";
        ScoreDisplay.text = "x" + PlayerPrefs.GetString("Score");

        //PlayerPrefs.SetString("FinalTime", PlayerPrefs.GetString("FinalTime") + TimeDisplay.text);
        //PlayerPrefs.SetString("FinalScore", PlayerPrefs.GetString("FinalScore") + ScoreDisplay.text + "/6");
        //FinalTimeDisplay.text = PlayerPrefs.GetString("FinalTime");
        FinalScoreDisplay.text = PlayerPrefs.GetFloat("ScoreVal").ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
