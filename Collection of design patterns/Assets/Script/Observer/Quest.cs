using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Subject))]

public class Quest : MonoBehaviour
{
    private Subject subject;

    private void Start()
    {
        subject = GetComponent<Subject>();   
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Item"))
        {
            subject.GetItem(other.tag);
            Destroy(other.gameObject);
        }
    }
}
