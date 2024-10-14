using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class PlayerAnimationController : AnimationController
{
    private static readonly int isWalking = Animator.StringToHash("isWalking");

    private readonly float magnituteThreshold = 0.5f; //walking을 하는데 너무 조금 움직이면 멈춘걸로 하고 싶다

    protected override void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 vector)
    {
        Debug.Log(vector);
        Debug.Log("magnitude : "+vector.magnitude);
        animator.SetBool(isWalking, vector.magnitude > magnituteThreshold);
    }
}
