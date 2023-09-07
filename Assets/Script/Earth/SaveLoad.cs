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
        // 다른 필요한 데이터 추가
    }

    private void SavePlayerData(PlayerData playerData)
    {
        string json = JsonUtility.ToJson(playerData);
        File.WriteAllText(Application.persistentDataPath + "/unityJson.json", json);
    }

    // 데이터 저장 예시
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
            return new PlayerData(); // 저장된 데이터가 없을 경우 기본값 반환
        }
    }

    // 데이터 불러오기 예시
    void LoadData()
    {
        PlayerData loadedData = LoadPlayerData();
        int playerLevel = loadedData.level;
        float playerExperience = loadedData.experience;
        // 불러온 데이터를 게임에 적용
    }

}