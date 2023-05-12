using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Ű���� �Է� ����
    // ��κ��� Update , FixedUpdate ��ư Update������ ó���� ���� �´�
    private void Update()
    {
        // Debug.Log("Hello Player");
        // Input // ����Ƽ�� ���� ��� �Է� ��� Ŭ����
        // � Ű�� ������������ 1 �ƴϸ� 0
        // Debug.Log(Input.anyKey);
        // (�Ű�����) �� Ű�� �������� �ִ� ����~ ������ bool
        // Input.GetKeyDown(); // (�Ű� ������) Ű�� ���� ���� bool
        // Input.GetKeyUp(); // (�Ű� ������) Ű�� �����ٰ� ���� ���� bool
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Get Key !");
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Get Key Down!");
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            Debug.Log("Get Key Up!");
        }
    }
}
