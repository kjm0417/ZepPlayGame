using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�� Ŭ������ �̺�Ʈ ������� Ķ������ �̵��� �����ϴ� ����
public class ZepPlayController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent; //�̺�Ʈ�� �����Ͽ� �̵� ���� ó��
    public event Action<Vector2> OnLookEvent; 

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }
}
