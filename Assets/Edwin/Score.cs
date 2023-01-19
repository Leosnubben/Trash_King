using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    int score;

       public void OnCollisionEnter2D(Collision2D collision)
    {
            if (collision.gameObject.tag == "Fågel")
            {
            score += 15;
            }

            if (collision.gameObject.tag == "Råtta")
        {
            score += 10;
        }
            if (collision.gameObject.tag == "Trash")
        {
            score += 5;
        }
    }
}
