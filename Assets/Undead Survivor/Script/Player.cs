using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public Vector2 inputVec;
    public float speed = 70F;
    Rigidbody2D rigid;
    Animator animator;

    Boolean flipX;
 
    SpriteRenderer spriteRenderer;
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();

    }
    // Start is called before the first frame update
    void Start()
    {
                                    Debug.Log("이거 작동 하나?");

    }
    void OnMove(InputValue value)
    {
        inputVec = value.Get<Vector2>();
    }

    void FixedUpdate()
    {
        Vector2 nextVector = inputVec * speed * Time.fixedDeltaTime;
        rigid.MovePosition(rigid.position + nextVector);
    }

    void LateUpdate()
    {
    
        animator.SetFloat("Speed", inputVec.magnitude);

        spriteRenderer.flipX = inputVec.x < 0;
    }
}
