using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudGeneratorScript : MonoBehaviour
{
    [SerializeField]
    GameObject[] clouds;

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

    void SpawnCloud(Vector3 startPos)
    {
        int randomIndex = UnityEngine.Random.Range(0, clouds.Length);
        GameObject cloud = Instantiate(clouds[randomIndex]);

       float startY = UnityEngine.Random.Range(startPos.y - 2f, startPos.y + 25f);
        cloud.transform.position = startPos;

        cloud.transform.position = new Vector3(startPos.x, startY, startPos.z);



        
        float speed = UnityEngine.Random.Range(0.2f, 1.2f);
        cloud.GetComponent<CloudScript>().StartFloating(speed, endPoint.transform.position.x);
    }

    void AttemptSpawn()
    {

        SpawnCloud(startPos);

        Invoke("AttemptSpawn", spawnInterval);

    }

    void Prewarm()
    {
        for (int i = 0; i < 10; i++)
        {
            Vector3 spawnPos = startPos + Vector3.right * (i * 2);
            SpawnCloud(spawnPos);
        }
    }
}
