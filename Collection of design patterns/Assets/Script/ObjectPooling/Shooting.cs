// Shooting script
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [Header("Shooting Information")]
    [SerializeField] private Transform firePoint;
    [SerializeField] private float bulletSpeed = 20f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Bullet bullet = ObjectPooling.Instance.GetObject();
        bullet.transform.position = firePoint.position;
        bullet.Shoot(firePoint.up, bulletSpeed);
    }
}