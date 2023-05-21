using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class MovementMu : MoveMent
{
    /* MoveMent 에서 선언된것
    public Vector3[] spawnPoint; 이걸 쓰는게 중요한데
    public float positionX; 
    public float positionZ;
    public float speed;
    */

    private void Start()
    {
        spawnPoint = new Vector3[4];
        positionX = 0;
        positionZ = 0;
        speed = 0.01f; // 다음부턴 속도 신경쓰자 민욱아 이게 뭔 개 고생이니 ㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋ
    }

    void Update()
    {
        // WASD 이동
        if (Input.GetKey(KeyCode.W))
        {
            positionX += Time.deltaTime;
            this.transform.position = new Vector3(positionX, this.transform.position.y, positionZ);
        }
        if (Input.GetKey(KeyCode.S))
        {
            positionX -= Time.deltaTime;
            this.transform.position = new Vector3(positionX, this.transform.position.y, positionZ);
        }
        if (Input.GetKey(KeyCode.A))
        {
            positionZ += Time.deltaTime;
            this.transform.position = new Vector3(positionX, this.transform.position.y, positionZ);
        }
        if (Input.GetKey(KeyCode.D))
        {
            positionZ -= Time.deltaTime;
            this.transform.position = new Vector3(positionX, this.transform.position.y, positionZ);
        }

        // 위치저장 및 이동
        if (Input.GetKey(KeyCode.Alpha1))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                spawnPoint[0] = this.transform.position;
                Debug.Log("1번에 좌표 " + spawnPoint[0] + "가 저장되었습니다.");
            }
            positionX = spawnPoint[0].x;
            positionZ = spawnPoint[0].z;
            this.transform.position = Vector3.MoveTowards(this.transform.position, spawnPoint[0], speed);
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                spawnPoint[1] = this.transform.position;
                Debug.Log("2번에 좌표 " + spawnPoint[1] + "가 저장되었습니다.");
            }
            positionX = spawnPoint[1].x;
            positionZ = spawnPoint[1].z;
            this.transform.position = Vector3.MoveTowards(this.transform.position, spawnPoint[1], speed);
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                spawnPoint[2] = this.transform.position;
                Debug.Log("3번에 좌표 " + spawnPoint[2] + "가 저장되었습니다.");
            }
            positionX = spawnPoint[2].x;
            positionZ = spawnPoint[2].z;
            this.transform.position = Vector3.MoveTowards(this.transform.position, spawnPoint[2], speed);
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                spawnPoint[3] = this.transform.position;
                Debug.Log("4번에 좌표 " + spawnPoint[3] + "가 저장되었습니다.");
            }
            positionX = spawnPoint[3].x;
            positionZ = spawnPoint[3].z;
            this.transform.position = Vector3.MoveTowards(this.transform.position, spawnPoint[3], speed);
        }

        // 좌표 저장된 값 확인하는거
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log("1번 좌표는 " + spawnPoint[0] + "입니다.");
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            Debug.Log("2번 좌표는 " + spawnPoint[1] + "입니다.");
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("3번 좌표는 " + spawnPoint[2] + "입니다.");
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            Debug.Log("4번 좌표는 " + spawnPoint[3] + "입니다.");
        }
    }
}