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
        Debug.Log(Input.anyKey);
    }
}
