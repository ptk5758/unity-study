using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerBall : MonoBehaviour
{
    Rigidbody rigid;
    public int cnt;

    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        cnt = 0;
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(new Vector3(0,40,0),ForceMode.Impulse);
        }
    }

    void FixedUpdate()
    {
        float ho = Input.GetAxisRaw("Horizontal"); //오른쪽 왼쪽
        float ve = Input.GetAxisRaw("Vertical"); // 위쪽 아래쪽
        rigid.AddForce(new Vector3(ho, 0,ve), ForceMode.Impulse);
    }

    void OnTriggerEnter(Collider other) //다른 객체와 충돌했을 때 , ohter이 다른 객체를 의미?
    {
        if (other.tag == "Item")
        {
            cnt++;
            Debug.Log("점수 : " + cnt);
            other.gameObject.SetActive(false);
        }
    }
}
