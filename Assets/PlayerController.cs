using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO; // �ν����� â���� Serializable ó���� �����͸� �����Ϸ��� �߰��������

public class PlayerController : MonoBehaviour
{
    // PlayerController�μ� �ʿ��� ������ �޼��尡 ����..
    public PlayerData playerData; // PlayerData ��ü�κ��� �����͸� ����

    [ContextMenu("To Json Data")] // ������Ʈ�� ������� �Լ��� �����ϴ� �޴���ư �߰�
    void SavePlayerDataToJson() // json���Ͽ� �÷��̾��� �����͸� ����
    {
        string jsonData = JsonUtility.ToJson(playerData, true);
        string path = Path.Combine(Application.dataPath, "playerData.json");
        File.WriteAllText(path, jsonData);
    }

    [ContextMenu("From Json Data")]
    void LoadPlayerDataToJson() // json���Ϸκ��� �÷��̾��� �����͸� ����
    {
        string path = Path.Combine(Application.dataPath, "playerData.json");
        string jsonData = File.ReadAllText(path);
        playerData = JsonUtility.FromJson<PlayerData>(jsonData);
    }
}
[System.Serializable] // PlayerData�� ���������ϰ� Serializable �������.
public class PlayerData // MonoBehaviour �� �������� �޾ƿ��°��� �����ϱ� ���ؼ� C#Ŭ���� ����
{
    public string name;
    public int age;
    public int level;
    public bool isDead;
    public string[] items;
}