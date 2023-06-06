using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muDrop : MonoBehaviour
{
    float initX, initY, initZ;
    float speed = 2f;
    bool drop = false;

    void Awake()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha3) && !drop)
        {
            initX = transform.position.x;
            initY = transform.position.y;
            initZ = transform.position.z;
            StartCoroutine(Drop());
        }
    }

    IEnumerator Drop()
    {
        drop = true;

        Vector3 dropPoint = new Vector3(initX, initY, initZ + 4f);

        while (transform.position != dropPoint)
        {
            transform.position = Vector3.MoveTowards(transform.position, dropPoint, speed * Time.deltaTime);
            yield return null;
        }

        transform.position = new Vector3(initX, initY, initZ);
        drop = false;
    }
}