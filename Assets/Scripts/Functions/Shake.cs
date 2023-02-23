using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{
    //Oscar
    public static bool start = false;
    public float duration = 1f;
    public AnimationCurve curve; 

    private void Update()
    {
        if (start) //N�r start blir true s� startar den camerashaken, och s�tter den p� false
        {
            start = false;
            StartCoroutine(Shaking());
        }
        IEnumerator Shaking()
        {
            Vector3 startPosition = transform.position; 
            float elapsedTime = 0f;
            
            while (elapsedTime < duration)
            {
                elapsedTime += Time.deltaTime;
                float strength = curve.Evaluate(elapsedTime / duration); //En kurva f�r att best�mma hur mycket det skakar, 
                transform.position = startPosition + Random.insideUnitSphere * strength; //G�r s� att den skakar i en "sphere" r�relse
                yield return null;
            }

            transform.position = startPosition;
        }
    }
}
