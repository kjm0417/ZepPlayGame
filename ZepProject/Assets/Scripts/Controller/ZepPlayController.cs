using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//이 클래스는 이벤트 기반으로 캘익터의 이동을 제어하는 역할
public class ZepPlayController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent; //이벤트에 구독하여 이동 관련 처리
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
