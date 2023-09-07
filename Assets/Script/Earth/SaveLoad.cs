using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveLoad : MonoBehaviour
{
    [System.Serializable]
    public class PlayerData
    {
        public int level;
        public float experience;
        // �ٸ� �ʿ��� ������ �߰�
    }

    private void SavePlayerData(PlayerData playerData)
    {
        string json = JsonUtility.ToJson(playerData);
        File.WriteAllText(Application.persistentDataPath + "/unityJson.json", json);
    }

    // ������ ���� ����
    void SaveData()
    {
        PlayerData playerData = new PlayerData();
        playerData.level = 10;
        playerData.experience = 500.0f;
        SavePlayerData(playerData);
    }

    private PlayerData LoadPlayerData()
    {
        string filePath = Application.persistentDataPath + "/unityJson.json";
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            return JsonUtility.FromJson<PlayerData>(json);
        }
        else
        {
            return new PlayerData(); // ����� �����Ͱ� ���� ��� �⺻�� ��ȯ
        }
    }

    // ������ �ҷ����� ����
    void LoadData()
    {
        PlayerData loadedData = LoadPlayerData();
        int playerLevel = loadedData.level;
        float playerExperience = loadedData.experience;
        // �ҷ��� �����͸� ���ӿ� ����
    }

}