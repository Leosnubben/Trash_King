using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarGeneratorScript: MonoBehaviour
{

    [SerializeField]
    GameObject[] stars;

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

    void SpawnStar(Vector3 startPos)
    {
        int randomIndex = UnityEngine.Random.Range(0, stars.Length);
        GameObject cloud = Instantiate(stars[randomIndex]);

        float startY = UnityEngine.Random.Range(startPos.y - 1f, startPos.y + 1f);
        cloud.transform.position = startPos;

        cloud.transform.position = new Vector3(startPos.y, startY, startPos.z);




        float speed = UnityEngine.Random.Range(0.2f, 1.2f);
        cloud.GetComponent<StarScript>().StartFloating(speed, endPoint.transform.position.y);
    }

    void AttemptSpawn()
    {

        SpawnStar(startPos);

        Invoke("AttemptSpawn", spawnInterval);

    }

    void Prewarm()
    {
        for (int i = 0; i < 10; i++)
        {
            Vector3 spawnPos = startPos + Vector3.right * (i * 2);
            SpawnStar(spawnPos);
        }
    }
}
