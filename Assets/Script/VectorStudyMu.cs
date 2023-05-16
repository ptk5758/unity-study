using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorStudyMu : VectorStudy
{
    public Vector3 tgPoint;
    public float speed;
    Vector3 position1 = new Vector3(20, 1, 20);
    Vector3 position2 = new Vector3(20, 1, 0);
    Vector3 position3 = new Vector3(20, 1, -20);
    Vector3 position4 = new Vector3(0, 1, 20);
    Vector3 position5 = new Vector3(0, 1, -20);

    private void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1) && Input.GetKey(KeyCode.Space))
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, position1, speed);
        }
        if (Input.GetKey(KeyCode.Alpha2) && Input.GetKey(KeyCode.Space))
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, position2, speed);

        }
        if (Input.GetKey(KeyCode.Alpha3) && Input.GetKey(KeyCode.Space))
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, position3, speed);

        }
        if (Input.GetKey(KeyCode.Alpha4) && Input.GetKey(KeyCode.Space))
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, position4, speed);

        }
        if (Input.GetKey(KeyCode.Alpha5) && Input.GetKey(KeyCode.Space))
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, position5, speed);

        }
        /*Vector3 position1 = new Vector3(20, 1, 20);
        Vector3 position2 = new Vector3(20, 1, 0);
        Vector3 position3 = new Vector3(20, 1, -20);
        Vector3 position4 = new Vector3(0, 1, 20);
        Vector3 position5 = new Vector3(0, 1, -20);*/
    }
}
