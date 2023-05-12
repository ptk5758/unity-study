using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // 키보드 입력 감지
    // 대부분은 Update , FixedUpdate 무튼 Update류에서 처리가 많이 됀다
    private void Update()
    {
        // Debug.Log("Hello Player");
        // Input // 유니티의 거의 모든 입력 담당 클레스
        // 어떤 키든 눌려져있으면 1 아니면 0
        // Debug.Log(Input.anyKey);
        // (매개변수) 의 키가 눌러지고 있는 동안~ 진행형 bool
        // Input.GetKeyDown(); // (매개 변수의) 키가 누른 순간 bool
        // Input.GetKeyUp(); // (매개 변수의) 키가 눌럿다가 때진 순간 bool
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
