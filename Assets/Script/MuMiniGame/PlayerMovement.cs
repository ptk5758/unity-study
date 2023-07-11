using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class PlayerMovement : MonoBehaviour
{
    public float positionX;
    public float positionZ = 8;
    public float speed = 10f;

    private void Start()
    {
        
    }

    void Update()
    {
        // WASD ¿Ãµø
        if (Input.GetKey(KeyCode.W))
        {
            positionZ += speed * Time.deltaTime;
            this.transform.position = new Vector3(positionX, this.transform.position.y, positionZ);
        }
        if (Input.GetKey(KeyCode.S))
        {
            positionZ -= speed * Time.deltaTime;
            this.transform.position = new Vector3(positionX, this.transform.position.y, positionZ);
        }
        if (Input.GetKey(KeyCode.A))
        {
            positionX -= speed * Time.deltaTime;
            this.transform.position = new Vector3(positionX, this.transform.position.y, positionZ);
        }
        if (Input.GetKey(KeyCode.D))
        {
            positionX += speed * Time.deltaTime;
            this.transform.position = new Vector3(positionX, this.transform.position.y, positionZ);
        }
    }
}