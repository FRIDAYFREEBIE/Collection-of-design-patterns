
using System;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Rigidbody2D))]

public class SimpleFSM : MonoBehaviour, IFSM
{
    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rigidbody2D;
    private Vector2 moveDirection;

    public enum State // 상태 목록
    {
        Idle,
        Move,
    }

    private State state; // 현재 상태

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rigidbody2D = GetComponent<Rigidbody2D>();

        state = State.Idle; // 현재 상태 = Idle
    }

    private void Update()
    {
        UpdateState();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        moveDirection = new Vector2(moveX, moveY).normalized;

        rigidbody2D.velocity = new Vector2(moveDirection.x * 2, moveDirection.y * 2); // 이동

        if (rigidbody2D.velocity.magnitude != 0 ) // 이동중인가?
            state = State.Move; // 상태를 Move로 변경
        else
            state = State.Idle; // 상태를 Idle로 변경
    }

    public void UpdateState()
    {
        switch(state)
        {
            case State.Idle: // 현재 상태가 Idle 이라면?
                spriteRenderer.color = new Color(255, 255, 255); // 스프라이트의 색상을 하얀색으로 바꾼다
                break;

            case State.Move: // 현재 상태가 Move 이라면?
                spriteRenderer.color = new Color(255, 000, 000); // 스프라이트의 색상을 빨간색으로 바꾼다
                break;
        }
    }
}