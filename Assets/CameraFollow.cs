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
        // If satser så att kameran endast följer efter spelaren inom banan (Lägg scennamnet inom " " för att bestämma vilken)
        // Ändra numrena till start och slut positionerna av mappen för att bestämma hur långt kameran åker.
        if (player.transform.position.x > -16.9 && player.transform.position.x < 16.9 && player.scene.name == "Oscar")
        {
            // Gör så att kameran följer efter vänster och höger
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

        // Mark nivån
        if (player.transform.position.y > -8)
        {
            //Följer med spelaren upp och ner.
            transform.position = new Vector3(transform.position.x, player.transform.position.y, -10);
        }
    }
}
