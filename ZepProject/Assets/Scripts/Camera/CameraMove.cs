using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
     private Transform playerPos; //플레이어의 위치를 받고
     private Vector3 offset = new Vector3(0, 0, -10); //2D겜에서 보통 카메라 z값이 -10 플레이어는0으로해야 카메라가 뒤에서 찍을 수 있도록 함
     private float smoothSpeed = 1f; //카메라 이동 속도

    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate() //카메라 같은 기능은 LateUpdate에 작성해주는게 좋다. : 플레이어가 이동하고 카메라가 이동하기 때문에 플레이어 이동을 fixUpdate에 했으면 LateUpdate에 작성해준다.
    {
        if(playerPos != null)
        {   
            Vector3 desiredPosition = playerPos.position + offset; //
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);  //원하는 위치로 이동 시키기,  Vector3.Lerp(자신 위치, 원하는 위치로, 이동속도)
            transform.position = smoothedPosition;  // 카메라 위치 업데이트 : 게속해서 초기화를 해줘서 플레이어를 따라가게 설정
        }
    }

    public void SetPlayer(Transform pos)
    {
        playerPos = pos;
    }
}
