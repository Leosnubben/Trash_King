using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarScript : MonoBehaviour
{

    private float _speed;
    private float _endPosY;

    public void StartFloating(float speed, float endPosY)
    {
        _speed = speed;
        _endPosY = endPosY;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * (Time.deltaTime * _speed));

        if (transform.position.x > _endPosY)
        {
            Destroy(gameObject);
        }
    }
}
