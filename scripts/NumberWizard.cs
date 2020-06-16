using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{

    [SerializeField] int maxGuess;
    [SerializeField] int minGuess;
    [SerializeField] TextMeshProUGUI guessText;
    [SerializeField] TextMeshProUGUI minGuessText;
    [SerializeField] TextMeshProUGUI maxGuessText;

    int guess;

    int originalMax;
    int originalMin;
    int originalGuess;


    // Start is called before the first frame update
    void Start()
    {
        originalMax = maxGuess;
        originalMin = minGuess;
        originalGuess = guess;
        StartGame();
    }

    void StartGame()
    {
        NextGuess();
        //guess = (maxGuess + minGuess) / 2;
        maxGuess = originalMax;
        minGuess = originalMin;
        //guess = originalGuess;
        minGuessText.text = minGuess.ToString();
        maxGuessText.text = maxGuess.ToString();
        //guessText.text = guess.ToString();
        maxGuess = maxGuess + 1;

        /*
         * --------------------------------------------------------------
         Debug.Log("Welcome to Number Wizard, puny mortal!");
         Debug.Log("Gamble thy soule, picketh a number...");
         Debug.Log("A number not higher than " + maxGuess + ",");
         Debug.Log("Nor lower than a measly " + minGuess + "!");
         Debug.Log("Declareth to me if your number is higher or lower than " + guess + "!");
         Debug.Log("Push up = higher, push down for lower, push enter when correct.");
         maxGuess = maxGuess + 1;
         ----------------------------------------------------------------
         */

    }
    // Update is called once per frame
    void LateUpdate()
    {
        minGuessText.text = minGuess.ToString();
        maxGuessText.text = maxGuess.ToString();
    }
    public void OnPresshigher()
    {
        minGuess = guess + 1;
        NextGuess();
    }
    public void OnPressLower()
    {
        maxGuess = guess -1;
        NextGuess();
        
    }

    void NextGuess()
    {
        int randomAdd = Random.Range(-10, 10);
        //guess = ((Random.Range(minGuess, maxGuess)) / 2);
        guess = ((maxGuess + minGuess) / 2) + randomAdd;
        // Debug.Log("So... your number is higher or lower than: " + guess + "?");
        guessText.text = guess.ToString();
    }
}
