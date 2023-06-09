using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class MovementMu : MoveMent
{
    /* MoveMent 拭辞 識情吉依
    public Vector3[] spawnPoint; 戚杏 床澗惟 掻推廃汽
    public float positionX; 
    public float positionZ;
    public float speed;
    */

    private void Start()
    {
        spawnPoint = new Vector3[4];
        positionX = 0;
        positionZ = 0;
        speed = 0.01f; // 陥製採渡 紗亀 重井床切 肯錐焼 戚惟 杭 鯵 壱持戚艦 せせせせせせせせせせせせせせせせせせせせせせせせせせせせせせせせ
    }

    void Update()
    {
        // WASD 戚疑
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

        // 是帖煽舌 貢 戚疑
        if (Input.GetKey(KeyCode.Alpha1))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                spawnPoint[0] = this.transform.position;
                Debug.Log("1腰拭 疎妊 " + spawnPoint[0] + "亜 煽舌鞠醸柔艦陥.");
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
                Debug.Log("2腰拭 疎妊 " + spawnPoint[1] + "亜 煽舌鞠醸柔艦陥.");
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
                Debug.Log("3腰拭 疎妊 " + spawnPoint[2] + "亜 煽舌鞠醸柔艦陥.");
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
                Debug.Log("4腰拭 疎妊 " + spawnPoint[3] + "亜 煽舌鞠醸柔艦陥.");
            }
            positionX = spawnPoint[3].x;
            positionZ = spawnPoint[3].z;
            this.transform.position = Vector3.MoveTowards(this.transform.position, spawnPoint[3], speed);
        }

        // 疎妊 煽舌吉 葵 溌昔馬澗暗
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log("1腰 疎妊澗 " + spawnPoint[0] + "脊艦陥.");
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            Debug.Log("2腰 疎妊澗 " + spawnPoint[1] + "脊艦陥.");
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("3腰 疎妊澗 " + spawnPoint[2] + "脊艦陥.");
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            Debug.Log("4腰 疎妊澗 " + spawnPoint[3] + "脊艦陥.");
        }
    }
}