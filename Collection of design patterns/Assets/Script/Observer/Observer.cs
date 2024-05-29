using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Observer : MonoBehaviour, IObserver
{
    [Header("Quest Text")]
    [SerializeField] private TextMeshProUGUI text;

    private Subject subject;

    private void Start()
    {
        subject = FindObjectOfType<Subject>();

        subject.AddObserver(this); // 옵저버를 자신으로 설정
    }

    private void DestroyObserver()
    {
        subject.RemoveObserver(this);
    }

    public void UpdateNotify(string itemName)
    {
        // 퀘스트 완료 ㅋ.ㅋ
        if(itemName == "Item")
        {
            text.text = "Get Item (1/1)";
        }
    }
}
