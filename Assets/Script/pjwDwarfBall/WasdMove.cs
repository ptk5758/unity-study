using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WasdMove : MonoBehaviour
{
    public float positionX;
    public float positionZ;
    public float positionY;
    float speed;

    private void Start()
    {
        speed = 90;
        positionX = -210;
        positionY = 10;
        positionZ = -210;
    }
    void Update()
    {
        BallMoves();
    }

    void BallMoves()
    {
        //wasd로 공 이동
        if (Input.GetKey(KeyCode.A))
        {
            positionX -= Time.deltaTime * speed;
            transform.position = new Vector3(positionX, positionY, positionZ);
        }

        if (Input.GetKey(KeyCode.D))
        {
            positionX += Time.deltaTime * speed;
            transform.position = new Vector3(positionX, positionY, positionZ);
        }

        if (Input.GetKey(KeyCode.S))
        {
            positionZ -= Time.deltaTime * speed;
            transform.position = new Vector3(positionX, positionY, positionZ);
        }

        if (Input.GetKey(KeyCode.W))
        {
            positionZ += Time.deltaTime * speed;
            transform.position = new Vector3(positionX, positionY, positionZ);
        }
    }
}
