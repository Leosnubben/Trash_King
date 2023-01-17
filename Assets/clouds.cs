using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clouds : MonoBehaviour
{
    [SerializeField] GameObject[] cloudsPrefab;
    [SerializeField] float secondSpawn = 1.5f;
    [SerializeField] float minTras;
    [SerializeField] float maxTras;
    void Start()
    {
        StartCoroutine(CloudsSpawn());
    }

    IEnumerator CloudsSpawn()
    {
        while (true)
        {
            var wanted = Random.Range(minTras, maxTras);
            var position = new Vector3(wanted, transform.position.x);
            GameObject gameObject = Instantiate(cloudsPrefab[Random.Range(0, cloudsPrefab.Length)], position, Quaternion.identity);
            yield return new WaitForSeconds(secondSpawn);
            Destroy(gameObject, 5f);

        }
    }

}
