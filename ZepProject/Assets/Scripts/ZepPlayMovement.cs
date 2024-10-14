using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZepPlayMovement : MonoBehaviour
{
    private ZepPlayController zepPlayController;
    private Rigidbody2D rigidbody;

    private Vector2 movementDirection = Vector2.zero; //방향 

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
        // 이동방향만 정해두고 실제로 움직이지는 않음.
        // 움직이는 것은 물리 업데이트에서 진행(rigidbody가 물리니까)
        Debug.Log(direction);
        movementDirection = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;

        rigidbody.velocity = direction;
    }
}
