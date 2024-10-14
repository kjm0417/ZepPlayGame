using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAimRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer; //직렬화하여 인스펙터에서 초기화

    private ZepPlayController zepPlayController;
    void Start()
    {
        zepPlayController = GetComponent<ZepPlayController>();
    }

    // Update is called once per frame
    void Update()
    {
        zepPlayController.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 direction)
    {
        RotateArm(direction);
    }

    private void RotateArm(Vector2 direction)
    {
        float xflip = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; //각도를 구하기 -90 ~ 180까지 만 나옴 -90 -180 90 180
        
        spriteRenderer.flipX = Mathf.Abs(xflip)>90f;

    }
}
