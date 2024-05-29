using UnityEngine;

public class GreenGoblin : Monster
{
    private void Start()
    {
        monsterName = "Green Goblin";
        health = 100;
        damage = 10;
    }

    public override void Attack()
    {
        Debug.Log($"{monsterName} attacks with {damage} damage!");
    }

    public override void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Debug.Log($"{monsterName} is dead!");
            Destroy(gameObject);
        }
        else
        {
            PrintStatus();
        }
    }
}
