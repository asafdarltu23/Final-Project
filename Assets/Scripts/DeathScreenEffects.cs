using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DeathScreenEffects : MonoBehaviour
{
    public AudioSource audioPlayer;
    public TextMeshProUGUI Title;
    public TextMeshProUGUI RetryText;
    public TextMeshProUGUI QuitText;

    private bool Unfade = false;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DelayedEffects());
    }

    // Update is called once per frame
    void Update()
    {
        if(Unfade == true)
        {
            RetryText.alpha = RetryText.alpha + 0.005f;
            QuitText.alpha = QuitText.alpha + 0.005f;
        }
    }

    IEnumerator DelayedEffects()
    {
        yield return new WaitForSeconds(2);
        Title.alpha = 255;
        audioPlayer.Play();
        yield return new WaitForSeconds(0.5f);
        Unfade = true;
    }
}
