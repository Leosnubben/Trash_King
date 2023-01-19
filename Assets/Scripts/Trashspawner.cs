using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trashspawner : MonoBehaviour
{
    public GameObject[] plattformar;
    public GameObject trash;


    // Start is called before the first frame update
    void Start()
    {
        plattformar = GameObject.FindGameObjectsWithTag("Ground");
    }
    void CreateTrash()
    {
        Instantiate(trash, plattformar[Random.Range(0,plattformar.Length)].transform.position + new Vector3(0, 2, 0), Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        CreateTrash();
    }
}
