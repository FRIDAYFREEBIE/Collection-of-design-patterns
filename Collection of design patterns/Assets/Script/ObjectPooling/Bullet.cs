using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Shoot(Vector2 direction, float speed)
    {
        rb.velocity = direction * speed;
        StartCoroutine(DeactivateAfterDelay(2f));
    }

    private IEnumerator DeactivateAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        gameObject.SetActive(false);
        ObjectPooling.Instance.ReturnObject(this);
    }
}
