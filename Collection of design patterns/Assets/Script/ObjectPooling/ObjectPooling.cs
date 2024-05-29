using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling : MonoBehaviour, IObjectPooling
{
    public static ObjectPooling Instance { get; set; } // 싱글톤

    [Header("Pool")]
    [SerializeField] private Bullet bulletPrefab; // 총알 프리팹 
    [SerializeField] private int initialCount = 10; // 초기에 풀에 저장 할 총알의 갯수
    
    private Queue<Bullet> pool = new Queue<Bullet>(); // 풀(큐)

    // 싱글톤
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            Initialize(initialCount);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // 풀 초기화 메서드
    // initialCount만큼 오브젝트를 생성하여 풀에 저장
    public void Initialize(int initCount)
    {
        for (int i = 0; i < initCount; i++)
        {
            Bullet newBullet = CreateNewObject(); // newBullet에 새로운 오브젝트를 넣고
            ReturnObject(newBullet); // 풀에 반환
        }
    }

    // 오브젝트 생성 메서드
    // 생성된 오브젝트를 반환
    public Bullet CreateNewObject()
    {
        Bullet newBullet = Instantiate(bulletPrefab);
        newBullet.gameObject.SetActive(false); // 오브젝트 비활성화
        return newBullet;
    }

    // 오브젝트를 가지고 오는 메서드
    // 풀에서 오브젝트를 꺼내 반환
    public Bullet GetObject()
    {
        if (pool.Count > 0) // 풀에 오브젝트가 아직 남아 있다면?
        {
            Bullet bullet = pool.Dequeue();
            bullet.gameObject.SetActive(true); // 오브젝트 활성화
            return bullet;
        }
        else // 풀에 오브젝트가 없다면?
        {
            Bullet newBullet = CreateNewObject();
            newBullet.gameObject.SetActive(true); // 오브젝트 활성화
            return newBullet;
        }
    }

    // 오브젝트를 다시 넣어놓는 메서드
    // 풀에 오브젝트를 반환
    public void ReturnObject(Bullet bullet)
    {
        bullet.gameObject.SetActive(false);
        pool.Enqueue(bullet);
    }
}
