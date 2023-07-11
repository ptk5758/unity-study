using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    Transform playerTransform; //���� ���� ��ġ�� �޾ƿ� ����
    Vector3 Offset; //ī�޶� ���� �� �پ��ִ� �� �ƴ϶� ������ �� �������� �ϰ� �ҷ��� ��ġ�� ����

    void Awake()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform; //Player��� �̸��� ��ü�� ���� ��ġ ������ �޾ƿ�
        Offset = transform.position - playerTransform.position;
        //ī�޶�� �� ������ �Ÿ��� ���� �� �Ÿ���ŭ ī�޶� �������ְ�? ��ġ�� ����
        //���� ��ġ�� �ٲ� �� �Ÿ���ŭ�� �����ϸ鼭 ī�޶� ��� ����ٴ�
    }

    // Update is called once per frame
    void LateUpdate() //Update�� �ۼ��� �ڵ尡 �� ������
    {
        transform.position = playerTransform.position + Offset;
        //ī�޶��� ���� ��ġ�� Offset(���� �����ص� ���� ī�޶� ������ �Ÿ�)��ŭ ��������
    }
}
