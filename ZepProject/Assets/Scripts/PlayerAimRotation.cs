using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAimRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer; //����ȭ�Ͽ� �ν����Ϳ��� �ʱ�ȭ

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
        float xflip = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; //������ ���ϱ� -90 ~ 180���� �� ���� -90 -180 90 180
        
        spriteRenderer.flipX = Mathf.Abs(xflip)>90f;

    }
}
