using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    int score;

       public void OnCollisionEnter2D(Collision2D collision)
    {
            if (collision.gameObject.tag == "F�gel")
            {
            score += 15;
            }

            if (collision.gameObject.tag == "R�tta")
        {
            score += 10;
        }
            if (collision.gameObject.tag == "Trash")
        {
            score += 5;
        }
    }
}
