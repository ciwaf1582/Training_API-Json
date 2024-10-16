using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 1. 데이터(코드 = 클래스)를 만들어야함 => 저장할 데이터 생성
// 2. 그 데이터를 Json으로 변환(포장)
// 3. Json(택배)를 원래 코드로 변환
class Data // 조립도
{
    public string nickname;
    public int level;
    public int coin;
    public bool skill;
}
public class Test : MonoBehaviour
{
    Data player = new Data() { nickname = "성기삽니다", level = 50, coin = 200, skill = false }; // 객체 생성

    private void Start()
    {
        string jsonData = JsonUtility.ToJson(player); // 제이슨으로 포장

        Data player2 = JsonUtility.FromJson<Data>(jsonData); // 데이터 형태로 변환
        print(player2.nickname);
        print(player2.level);
        print(player2.coin);
        print(player2.skill);
    }
}
