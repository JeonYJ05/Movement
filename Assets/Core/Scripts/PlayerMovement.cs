using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody _rigidbody;
    [SerializeField] private float _speed = 5;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>(); 
    }

    private void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Move(h, v);
    }

    private void Move(float h , float v)
    {
        // transform.forward(z) �����ٰ� v(���� ��)�� ���Ѵ�.
        // a * -1 �Ǵ� 1���� ���� ���Ǵµ�, ���� ���� ������ ������ ����Ѵ� (Axis)
        Vector3 dir = transform.forward * v + transform.right * h;
        Vector3 speed = _speed * Time.deltaTime * dir.normalized;

        _rigidbody.MovePosition(transform.position + speed);
    }

}
