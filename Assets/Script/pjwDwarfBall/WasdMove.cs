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
        speed = 30;
        positionX = 220;
        positionY = 9;
        positionZ = 216;
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
