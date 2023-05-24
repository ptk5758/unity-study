using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidObjectMu : RigidObject
{
    Rigidbody rigid;

    private void Awake()
    {
        this.rigid = this.transform.GetComponent<Rigidbody>();
    }
    private void Update()
    {
        float horizon = Input.GetAxisRaw("Horizontal");
        float verti = Input.GetAxisRaw("Vertical");
        Vector3 temp = new Vector3(horizon, 0, verti);
        rigid.AddForce(temp);
    }
}
/*
private void Awake()
{
    this.rigid = this.transform.GetComponent<Rigidbody>();
}

void Update()
{
    if (Input.GetKeyDown(KeyCode.Space))
    {
        if (rigid.useGravity == false)
        {
            StartCoroutine(delay(3f));
        }
    }
}
private IEnumerator delay(float delayTime)
{
    yield return new WaitForSeconds(delayTime);
    rigid.useGravity = true;
}
*/