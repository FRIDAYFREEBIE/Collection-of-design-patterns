using UnityEngine;

public abstract class Monster: MonoBehaviour
{
    public string monsterName;
    public int health;
    public int damage;

    public abstract void Attack();
    public abstract void TakeDamage(int amount);

    public void PrintStatus()
    {
        Debug.Log($"{monsterName} has {health} health left.");
    }
}