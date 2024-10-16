using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class NewtworkTest : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(UnityWepRequestGet());
    }
    IEnumerator UnityWepRequestGet()
    {
        // 1. 주소
        // 여러명이서 정보를 요청할 때 키 값을 따로 지정
        string apikey = "JWPc9k6lxWcPg7OxjEegHChTq2zUDvbY";
        //string url = "https://api.neople.co.kr/df/servers?apikey=" + apikey;
        // 서버 정보
        string url_1 = "https://api.neople.co.kr/df/servers?apikey=" + apikey; 
        // 직업 정보
        string url_2 = "https://api.neople.co.kr/df/jobs?apikey=" + apikey;

        // 웨펀마스터
        string jobId = "41f1cdc2ff58bb5fdc287be0db2a8df3";
        string jobGrowId = "4ec01f4ae3728c080f28a72213b6df10";
        string url_3 = $"https://api.neople.co.kr/df/skills/{jobId}?jobGrowId={jobGrowId}&apikey=JWPc9k6lxWcPg7OxjEegHChTq2zUDvbY";

        // UnityWebRequest 방법
        //UnityWebRequest www = UnityWebRequest.Get(url_3); // Get 방식으로 요청

        // WWW 방법
        WWW www = new(url_3); // Get 방식으로 요청
        // 2. 응답 대기
        //yield return www.SendWebRequest(); // 응답 기다리기
        yield return www; // 응답 기다리기

        // 3. 응답
        if (www.error == null)
        {
            //Debug.Log(www.downloadHandler.text);
            Debug.Log(www.text);
        }
        else
        {
            Debug.Log("ERROR");
        }
    }
}
