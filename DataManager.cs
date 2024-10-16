using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO; // �ܺ� ������

// �����ϴ� ���
// 1. ������ �����Ͱ� ����
// 2. �����͸� JSON���� ��ȯ
// 3. ���̽��� �ܺο� ����

// �ҷ����� ���
// 1. �ܺο� ����� ���̽��� ������
// 2. ���̽��� �����ͷ� ��ȯ
// 3. �ҷ��� �����͸� ���

public class PlayerData
{
    // �̸�, ����, ����, ���� ���� ����
    public string name;
    public int level;
    public int coin;
    public int item;
}
public class DataManager : MonoBehaviour
{
    // �̱� ��
    public static DataManager instance;

    PlayerData nowPlayer = new PlayerData();

    string path;
    string fileName = "save";
    private void Awake()
    {
        #region �̱���
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
        path = Application.persistentDataPath + "/"; // ��� �ڵ� ����
    }
    private void Start()
    {
        
    }
    public void SaveData()
    {
        string data = JsonUtility.ToJson(nowPlayer); // Json���� ��ȯ
        File.WriteAllText(path + fileName, data); // 1. ��� 2. string �Լ� ��
    }
    public void LoadData()
    {
        string data = File.ReadAllText(path + fileName);
        nowPlayer = JsonUtility.FromJson<PlayerData>(data);
    }
}
