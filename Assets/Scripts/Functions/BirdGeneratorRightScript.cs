using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Ella
public class BirdGeneratorRightScript : MonoBehaviour
{
    [SerializeField]
    GameObject[] BirdRight;

    [SerializeField]
    float spawnInterval;

    [SerializeField]
    GameObject endPoint;

    Vector3 startPos;


    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        Prewarm();
        Invoke("AttemptSpawn", spawnInterval);
    }

    void SpawnBirdRight(Vector3 startPos)
    {
        int randomIndex = UnityEngine.Random.Range(0, BirdRight.Length);
        GameObject birdRight = Instantiate(BirdRight[randomIndex]);

        float startY = UnityEngine.Random.Range(startPos.y - 5f, startPos.y + 100f);
        birdRight.transform.position = startPos; 
        //detta �r f�r att kontrollera vart f�glarna b�rjar och slutar spawna 

        birdRight.transform.position = new Vector3(startPos.x, startY, startPos.z);




        float speed = UnityEngine.Random.Range(2f, 5f);
        birdRight.GetComponent<BirdRightScript>().StartFloating(speed, endPoint.transform.position.x);
    }

    void AttemptSpawn()
    {

        SpawnBirdRight(startPos);

        Invoke("AttemptSpawn", spawnInterval);

    }

    void Prewarm() //detta �r f�r att f�glarna redan ska vara p� sk�rmen f�r att det inte ska bli en delay 
    {
        for (int i = 0; i < 10; i++)
        {
            Vector3 spawnPos = startPos + Vector3.right * (i * 2);
            SpawnBirdRight(spawnPos);
        }
    }
}
