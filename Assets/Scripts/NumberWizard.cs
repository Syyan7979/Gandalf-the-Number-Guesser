using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max, min;
    [SerializeField] Text guessText;
    [SerializeField] TextMeshProUGUI counterText;

    int guess;
    static int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        NextGuess();
    }

    void NextGuess()
    {
        if (min < max + 1)
        {
            guess = Random.Range(min, max + 1);
            counter += 1;
            guessText.text = guess.ToString();
        }
    }

    public void OnPressHigher()
    {
        min = guess + 1;
        NextGuess();
        
    }

    public void OnPressLower()
    {
        max = guess - 1;
        NextGuess();
    }
}

