using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 1. ������(�ڵ� = Ŭ����)�� �������� => ������ ������ ����
// 2. �� �����͸� Json���� ��ȯ(����)
// 3. Json(�ù�)�� ���� �ڵ�� ��ȯ
class Data // ������
{
    public string nickname;
    public int level;
    public int coin;
    public bool skill;
}
public class Test : MonoBehaviour
{
    Data player = new Data() { nickname = "�����ϴ�", level = 50, coin = 200, skill = false }; // ��ü ����

    private void Start()
    {
        string jsonData = JsonUtility.ToJson(player); // ���̽����� ����

        Data player2 = JsonUtility.FromJson<Data>(jsonData); // ������ ���·� ��ȯ
        print(player2.nickname);
        print(player2.level);
        print(player2.coin);
        print(player2.skill);
    }
}
