using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MovementMu : MoveMent
{
    public float front;
    public float side;

    private void setSpawnpoint()
    {
        spawnPoint = new Vector3[4];
    }
    private void Start()
    {
        speed = 5.0f;
    }

    void Update()
    {
        // 위치저장
        /*if (Input.GetKey(KeyCode.LeftShift))
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                SavePosition(spawnPoint[0]);
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                SavePosition(spawnPoint[1]);
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                SavePosition(spawnPoint[2]);
            }
            else if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                SavePosition(spawnPoint[3]);
            }
        }*/
        // 이동
        if (Input.GetKey(KeyCode.W))
        {
            front += Time.deltaTime;
            this.transform.position = new Vector3(front, this.transform.position.y, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            front -= Time.deltaTime;
            this.transform.position = new Vector3(front, this.transform.position.y, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            side += Time.deltaTime;
            this.transform.position = new Vector3(this.transform.position.x, 0, side);
        }
        if (Input.GetKey(KeyCode.D))
        {
            side -= Time.deltaTime;
            this.transform.position = new Vector3(this.transform.position.x, 0, side);
        }
        this.transform.position = new Vector3(front*speed, this.transform.position.y, side*speed);

    }
}