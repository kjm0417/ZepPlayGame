using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
     private Transform playerPos; //�÷��̾��� ��ġ�� �ް�
     private Vector3 offset = new Vector3(0, 0, -10); //2D�׿��� ���� ī�޶� z���� -10 �÷��̾��0�����ؾ� ī�޶� �ڿ��� ���� �� �ֵ��� ��
     private float smoothSpeed = 1f; //ī�޶� �̵� �ӵ�

    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate() //ī�޶� ���� ����� LateUpdate�� �ۼ����ִ°� ����. : �÷��̾ �̵��ϰ� ī�޶� �̵��ϱ� ������ �÷��̾� �̵��� fixUpdate�� ������ LateUpdate�� �ۼ����ش�.
    {
        if(playerPos != null)
        {   
            Vector3 desiredPosition = playerPos.position + offset; //
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);  //���ϴ� ��ġ�� �̵� ��Ű��,  Vector3.Lerp(�ڽ� ��ġ, ���ϴ� ��ġ��, �̵��ӵ�)
            transform.position = smoothedPosition;  // ī�޶� ��ġ ������Ʈ : �Լ��ؼ� �ʱ�ȭ�� ���༭ �÷��̾ ���󰡰� ����
        }
    }

    public void SetPlayer(Transform pos)
    {
        playerPos = pos;
    }
}
