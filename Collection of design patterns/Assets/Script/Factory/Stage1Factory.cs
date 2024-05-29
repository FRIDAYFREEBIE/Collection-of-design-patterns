using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 고블린 팩토리 사용을 위해 만든 스크립트
public class Stage1Factory : MonoBehaviour
{   
    [Header("Monster Type")]
    [SerializeField] private string monsterType; // 몬스터 타입

    IMonsterFactory factory;

    void Start()
    {
        factory = FindAnyObjectByType<GoblinFactory>().GetComponent<GoblinFactory>();
        
        Monster monster = factory.CreateMonster(monsterType); // 몬스터 타입에 따라 팩토리에서 몬스터를 생성
    }
}
