using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class MovementMu : MoveMent
{
    

    private void setSpawnpoint()
    {
        spawnPoint = new Vector3[4];
    }
    private void Start()
    {
        positionX = 0;
        positionZ = 0;
        speed = 5.0f;
    }

    void Update()
    {
        // WASD 이동
        if (Input.GetKey(KeyCode.W))
        {
            positionX += Time.deltaTime;
            this.transform.position = new Vector3(positionX, this.transform.position.y, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            positionX -= Time.deltaTime;
            this.transform.position = new Vector3(positionX, this.transform.position.y, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            positionZ += Time.deltaTime;
            this.transform.position = new Vector3(this.transform.position.x, 0, positionZ);
        }
        if (Input.GetKey(KeyCode.D))
        {
            positionZ -= Time.deltaTime;
            this.transform.position = new Vector3(this.transform.position.x, 0, positionZ);
        }
        this.transform.position = new Vector3(positionX * speed, this.transform.position.y, positionZ * speed);
        
        // 위치저장
        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                spawnPoint(0);
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                spawnPoint(1);
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                spawnPoint(2);
            }
            else if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                spawnPoint(3);
            }
        }

        // 숫자키 누르고 저장된 포지션으로 이동
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            transform.position = Vector3.MoveTowards(transform.position, spawnPoint(0), speed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            transform.position = Vector3.MoveTowards(transform.position, spawnPoint(1), speed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            transform.position = Vector3.MoveTowards(transform.position, spawnPoint(2), speed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            transform.position = Vector3.MoveTowards(transform.position, spawnPoint(3), speed * Time.deltaTime);
        }
    }
}
// 현재위치, 목표위치, 속도
// transform.position = Vector3.MoveTowards(transform.position, Target.position, Speed * Time.deltaTime);
// transform.position = Vector3.MoveTowards(transform.position, spawnPoint(0), Speed * Time.deltaTime);
// transform.position = Vector3.MoveTowards(transform.position, spawnPoint(1), Speed * Time.deltaTime);
// transform.position = Vector3.MoveTowards(transform.position, spawnPoint(2), Speed * Time.deltaTime);
// transform.position = Vector3.MoveTowards(transform.position, spawnPoint(3), Speed * Time.deltaTime);