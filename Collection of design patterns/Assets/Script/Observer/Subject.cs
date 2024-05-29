using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subject : MonoBehaviour, ISubject
{
    public List<IObserver> observers = new List<IObserver>(); // 옵저버 리스트

    public void AddObserver(IObserver observer)
    {
        if (!observers.Contains(observer)) // 리스트에 없는 옵저버 만
        {
            observers.Add(observer); // 리스트에 추가
        }
    }

    public void RemoveObserver(IObserver observer)
    {
        if (observers.Contains(observer)) // 리스트에 없는 옵저버 만
        {
            observers.Remove(observer);  // 리스트에서 삭제
        }
    }

    public void NotifyObserver(string itemName)
    {
        foreach (IObserver observer in observers) // 모든 옵저버를 순회
        {
            observer.UpdateNotify(itemName);
        }
    }

    public void GetItem(string itemName) // 퀘스트 완료 처리를 위한 매서드
    {
        NotifyObserver(itemName); // NotifyObserver 매서드를 사용하여 옵저버에게 전달
    }
}
