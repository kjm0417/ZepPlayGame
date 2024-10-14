using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

//플레이어 입력을 처리하는 역할 스크립트 Input System을 사용하여 플레이어의 이동 입력을 받아 처리하고, 해당 정보를 부모 클래스에 전달 ZepPlayController에 전달
public class PlayerInputController : ZepPlayController
{
    private Camera camera;

    private void Awake()
    {
        camera = Camera.main; //tag가 mainCamera인거
        camera.transform.GetComponent<CameraMove>().SetPlayer(transform); //이 스크립트를 가지고 있는 카메라 transform을 SetPlayer에 전달해준다.
    }
    public void OnMove(InputValue value) //Input Player컴포넌트에서 Send Message로 인해 이벤트가 실행되면 바로 메서드 실행한다
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }

    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = camera.ScreenToWorldPoint(newAim); //카메라의 범위를 월드좌표로 변환 해준다
        newAim = (worldPos - (Vector2)transform.position).normalized;

        CallLookEvent(newAim);
    }
}
