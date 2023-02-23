using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trashspawner : MonoBehaviour
{
    /// Hela koden skriven av Leo
    
    public GameObject[] plattformar;
    public GameObject[] trash;
    public int AmountOfTrash;
    public int trashcount = 0;

    // Start is called before the first frame update
    void Start()
    {
        plattformar = GameObject.FindGameObjectsWithTag("Ground");  //S�ger att allt med "Ground" taggen �r en plattform - Leo
    }
    IEnumerator TrashCreation() // Spawnar bara trash �ver plattformar - Leo
    {
        Instantiate(trash[Random.Range(0,trash.Length)], plattformar[Random.Range(0, plattformar.Length)].transform.position + new Vector3(0, 0.4f, 0), Quaternion.identity);
        trashcount += 1;
        yield return true;
    }
    /*void CreateTrash()
    {
        Instantiate(trash, plattformar[Random.Range(0,plattformar.Length)].transform.position + new Vector3(0, 2, 0), Quaternion.identity);
        trashcount += 1;
    }*/
    // Update is called once per frame
    void Update()
    {
        if (trashcount <= AmountOfTrash) //S�tter en valfri gr�ns p� hur mycket trash som kan spawnas - Leo
        {
            StartCoroutine(TrashCreation());
        }
        else if (trashcount >= AmountOfTrash) //Slutar generera trash om gr�nsen �r n�dd - Leo
        {
            StopCoroutine(TrashCreation());
        }
        else
        {
            print("Ojojojoj");
        }
    }
}
