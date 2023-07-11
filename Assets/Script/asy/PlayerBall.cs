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
        float ho = Input.GetAxisRaw("Horizontal"); //������ ����
        float ve = Input.GetAxisRaw("Vertical"); // ���� �Ʒ���
        rigid.AddForce(new Vector3(ho, 0,ve), ForceMode.Impulse);
    }

    void OnTriggerEnter(Collider other) //�ٸ� ��ü�� �浹���� �� , ohter�� �ٸ� ��ü�� �ǹ�?
    {
        if (other.tag == "Item")
        {
            cnt++;
            Debug.Log("���� : " + cnt);
            other.gameObject.SetActive(false);
        }
    }
}
