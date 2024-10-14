using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

//�÷��̾� �Է��� ó���ϴ� ���� ��ũ��Ʈ Input System�� ����Ͽ� �÷��̾��� �̵� �Է��� �޾� ó���ϰ�, �ش� ������ �θ� Ŭ������ ���� ZepPlayController�� ����
public class PlayerInputController : ZepPlayController
{
    private Camera camera;

    private void Awake()
    {
        camera = Camera.main; //tag�� mainCamera�ΰ�
        camera.transform.GetComponent<CameraMove>().SetPlayer(transform); //�� ��ũ��Ʈ�� ������ �ִ� ī�޶� transform�� SetPlayer�� �������ش�.
    }
    public void OnMove(InputValue value) //Input Player������Ʈ���� Send Message�� ���� �̺�Ʈ�� ����Ǹ� �ٷ� �޼��� �����Ѵ�
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }

    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = camera.ScreenToWorldPoint(newAim); //ī�޶��� ������ ������ǥ�� ��ȯ ���ش�
        newAim = (worldPos - (Vector2)transform.position).normalized;

        CallLookEvent(newAim);
    }
}
