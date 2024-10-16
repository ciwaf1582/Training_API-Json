using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO; // 외부 데이터

// 저장하는 방법
// 1. 저장할 데이터가 존재
// 2. 데이터를 JSON으로 변환
// 3. 제이슨을 외부에 저장

// 불러오는 방법
// 1. 외부에 저장된 제이슨을 가져옴
// 2. 제이슨을 데이터로 변환
// 3. 불러온 데이터를 사용

public class PlayerData
{
    // 이름, 레벨, 코인, 착용 중인 무기
    public string name;
    public int level;
    public int coin;
    public int item;
}
public class DataManager : MonoBehaviour
{
    // 싱글 톤
    public static DataManager instance;

    PlayerData nowPlayer = new PlayerData();

    string path;
    string fileName = "save";
    private void Awake()
    {
        #region 싱글톤
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Destroy(instance.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
        #endregion
        path = Application.persistentDataPath + "/"; // 경로 자동 지정
    }
    private void Start()
    {
        
    }
    public void SaveData()
    {
        string data = JsonUtility.ToJson(nowPlayer); // Json으로 변환
        File.WriteAllText(path + fileName, data); // 1. 경로 2. string 함수 명
    }
    public void LoadData()
    {
        string data = File.ReadAllText(path + fileName);
        nowPlayer = JsonUtility.FromJson<PlayerData>(data);
    }
}
