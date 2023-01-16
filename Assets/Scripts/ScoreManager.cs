using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
   

    int score = 0;

    void Start()
    {
        scoreText.text = score.ToString() + " POINTS";
        
    }

    // Update is called once per frame

    // skapa en ny tag som heter "MyCoin" och lägg den på alla colliders

    private void OntriggerEnter2D(Collider2D Coin)
    {
        if (Coin.tag == "MyCoin")
        {
            score = +1;
            scoreText.text = "score" + score;
        }
    }
}
       
