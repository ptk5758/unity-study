using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMentPtk : MoveMent
{
    private void Awake()
    {
        this.spawnPoint = new Vector3[4];
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.W)) this.positionZ += Time.deltaTime * this.speed;
        if (Input.GetKey(KeyCode.S)) this.positionZ -= Time.deltaTime * this.speed;
        if (Input.GetKey(KeyCode.A)) this.positionX += Time.deltaTime * this.speed;
        if (Input.GetKey(KeyCode.D)) this.positionX -= Time.deltaTime * this.speed;
        if (Input.GetKeyDown(KeyCode.Alpha1) && Input.GetKey(KeyCode.LeftShift)) this.spawnPoint[0] = this.transform.position;
        if (Input.GetKeyDown(KeyCode.Alpha2) && Input.GetKey(KeyCode.LeftShift)) this.spawnPoint[1] = this.transform.position;
        if (Input.GetKeyDown(KeyCode.Alpha3) && Input.GetKey(KeyCode.LeftShift)) this.spawnPoint[2] = this.transform.position;
        if (Input.GetKeyDown(KeyCode.Alpha4) && Input.GetKey(KeyCode.LeftShift)) this.spawnPoint[3] = this.transform.position;
        if (Input.GetKey(KeyCode.Alpha1)) {
            Vector3 temp = Vector3.MoveTowards(this.transform.position, this.spawnPoint[0], 1);
            this.positionX = temp.x;
            this.positionZ = temp.z;
        }
        if (Input.GetKey(KeyCode.Alpha2)) {
            Vector3 temp = Vector3.MoveTowards(this.transform.position, this.spawnPoint[1], 1);
            this.positionX = temp.x;
            this.positionZ = temp.z;
        }
        if (Input.GetKey(KeyCode.Alpha3)) {
            Vector3 temp = Vector3.MoveTowards(this.transform.position, this.spawnPoint[2], 1);
            this.positionX = temp.x;
            this.positionZ = temp.z;
        }
        if (Input.GetKey(KeyCode.Alpha4)) {
            Vector3 temp = Vector3.MoveTowards(this.transform.position, this.spawnPoint[3], 1);
            this.positionX = temp.x;
            this.positionZ = temp.z;
        }
        this.transform.position = new Vector3(this.positionX, 0, this.positionZ);
    }
}
