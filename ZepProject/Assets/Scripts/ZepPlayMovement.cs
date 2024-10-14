using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZepPlayMovement : MonoBehaviour
{
    private ZepPlayController zepPlayController;
    private Rigidbody2D rigidbody;

    private Vector2 movementDirection = Vector2.zero; //���� 

    private void Awake()
    {
        zepPlayController = GetComponent<ZepPlayController>();
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        ApplyMovement(movementDirection);
    }
    void Start()
    {
        zepPlayController.OnMoveEvent += Move;
    }

    private void Move(Vector2 direction)
    {
        // �̵����⸸ ���صΰ� ������ ���������� ����.
        // �����̴� ���� ���� ������Ʈ���� ����(rigidbody�� �����ϱ�)
        Debug.Log(direction);
        movementDirection = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;

        rigidbody.velocity = direction;
    }
}
