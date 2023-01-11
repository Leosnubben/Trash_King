using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraFollow : MonoBehaviour
{
    Player player;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        // If satser s� att kameran endast f�ljer efter spelaren inom banan (L�gg scennamnet inom " " f�r att best�mma vilken)
        // �ndra numrena till start och slut positionerna av mappen f�r att best�mma hur l�ngt kameran �ker.
        if (player.transform.position.x > -16.9 && player.transform.position.x < 16.9 && player.scene.name == "Oscar")
        {
            // G�r s� att kameran f�ljer efter v�nster och h�ger
            transform.position = new Vector3(player.transform.position.x, transform.position.y, -10);
        }
        if (player.transform.position.x > -16.9 && player.transform.position.x < 16.9 && player.scene.name == "")
        {
            transform.position = new Vector3(player.transform.position.x, transform.position.y, -10);
        }
        if (player.transform.position.x > -16.9 && player.transform.position.x < 32 && player.scene.name == "")
        {
            transform.position = new Vector3(player.transform.position.x, transform.position.y, -10);
        }
        if (player.transform.position.x > -16.9 && player.transform.position.x < 32 && player.scene.name == "")
        {
            transform.position = new Vector3(player.transform.position.x, transform.position.y, -10);
        }
        if (player.transform.position.x > -16.9 && player.transform.position.x < 72 && player.scene.name == "")
        {
            transform.position = new Vector3(player.transform.position.x, transform.position.y, -10);
        }
        if (player.transform.position.x > -16.9 && player.transform.position.x < 72 && player.scene.name == "")
        {
            transform.position = new Vector3(player.transform.position.x, transform.position.y, -10);
        }

        // Mark niv�n
        if (player.transform.position.y > -8)
        {
            //F�ljer med spelaren upp och ner.
            transform.position = new Vector3(transform.position.x, player.transform.position.y, -10);
        }
    }
}
