using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO; // 인스펙터 창에서 Serializable 처리된 데이터를 수정하려면 추가해줘야함

public class PlayerController : MonoBehaviour
{
    // PlayerController로서 필요한 변수와 메서드가 있음..
    public PlayerData playerData; // PlayerData 객체로부터 데이터를 받음

    [ContextMenu("To Json Data")] // 컴포넌트에 따라오는 함수를 실행하는 메뉴버튼 추가
    void SavePlayerDataToJson() // json파일에 플레이어의 데이터를 저장
    {
        string jsonData = JsonUtility.ToJson(playerData, true);
        string path = Path.Combine(Application.dataPath, "playerData.json");
        File.WriteAllText(path, jsonData);
    }

    [ContextMenu("From Json Data")]
    void LoadPlayerDataToJson() // json파일로부터 플레이어의 데이터를 갱신
    {
        string path = Path.Combine(Application.dataPath, "playerData.json");
        string jsonData = File.ReadAllText(path);
        playerData = JsonUtility.FromJson<PlayerData>(jsonData);
    }
}
[System.Serializable] // PlayerData를 수정가능하게 Serializable 해줘야함.
public class PlayerData // MonoBehaviour 의 정보까지 받아오는것을 방지하기 위해서 C#클래스 생성
{
    public string name;
    public int age;
    public int level;
    public bool isDead;
    public string[] items;
}