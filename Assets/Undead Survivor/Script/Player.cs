using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector2 inputVec;
    public float speed = 0.4F;
    Rigidbody2D rigid;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inputVec.x = Input.GetAxisRaw("Horizontal"); //Raw�� ������ ���� 1 Ȥ�� 0�� ����, ������ 0.0~1.0 ���� ����
        inputVec.y = Input.GetAxisRaw("Vertical");
       
    }

    void FixedUpdate()
    {
        Vector2 nextVector = inputVec.normalized * speed * Time.fixedDeltaTime;
        rigid.MovePosition(rigid.position + nextVector);


    }
}
