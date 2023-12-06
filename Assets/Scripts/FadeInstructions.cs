using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class FadeInstructions : MonoBehaviour
{
    public TextMeshProUGUI instructions;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(5);
        instructions.alpha = instructions.alpha - 0.05f;
        if (instructions.alpha <= 0)
        {
            instructions.enabled = false;
        }
        yield break;
    }
}
