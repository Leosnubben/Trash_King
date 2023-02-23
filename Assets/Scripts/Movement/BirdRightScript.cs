using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Ella
public class BirdRightScript : MonoBehaviour
{
    private float _speed;
    private float _endPosX;

    public void StartFloating(float speed, float endPosX)
    {
        _speed = speed;
        _endPosX = endPosX;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * (Time.deltaTime * _speed));

        if (transform.position.x > _endPosX)
        {
            Destroy(gameObject);
            //f�r att f�glarna ska f�rsvinna n�r de kommer till slutpositionen 
        }
    }
}
