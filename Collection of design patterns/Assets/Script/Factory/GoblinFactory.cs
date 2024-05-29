using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinFactory : MonoBehaviour, IMonsterFactory
{
    public GreenGoblin greenGoblin; // 빨간 고블린
    public RedGoblin redGobline; // 초록 고블린

    // 몬스터 생성 메서드
    public Monster CreateMonster(string type)
    {
        Monster monster = null;

        if(type.Equals("green")) // green이라면?
        {
            monster = Instantiate(greenGoblin); // 초록 고블린 생성
        }
        else if(type.Equals("red")) // red라면?
        {
            monster = Instantiate(redGobline); // 빨간 고블린 생성
        }

        return monster;
    }
}
