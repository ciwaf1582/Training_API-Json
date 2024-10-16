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
        // 1. �ּ�
        // �������̼� ������ ��û�� �� Ű ���� ���� ����
        string apikey = "JWPc9k6lxWcPg7OxjEegHChTq2zUDvbY";
        //string url = "https://api.neople.co.kr/df/servers?apikey=" + apikey;
        // ���� ����
        string url_1 = "https://api.neople.co.kr/df/servers?apikey=" + apikey; 
        // ���� ����
        string url_2 = "https://api.neople.co.kr/df/jobs?apikey=" + apikey;

        // ���ݸ�����
        string jobId = "41f1cdc2ff58bb5fdc287be0db2a8df3";
        string jobGrowId = "4ec01f4ae3728c080f28a72213b6df10";
        string url_3 = $"https://api.neople.co.kr/df/skills/{jobId}?jobGrowId={jobGrowId}&apikey=JWPc9k6lxWcPg7OxjEegHChTq2zUDvbY";

        // UnityWebRequest ���
        //UnityWebRequest www = UnityWebRequest.Get(url_3); // Get ������� ��û

        // WWW ���
        WWW www = new(url_3); // Get ������� ��û
        // 2. ���� ���
        //yield return www.SendWebRequest(); // ���� ��ٸ���
        yield return www; // ���� ��ٸ���

        // 3. ����
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
