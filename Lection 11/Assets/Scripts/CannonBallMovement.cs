using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBallMovement : MonoBehaviour
{
    public float angle; //���� � �������� ����� �������� �������� � OY
    public float velocity; //������ ��������
    private Vector3 v; //������ ��������

    void Start()
    {
        angle = (100 - angle) * Mathf.Deg2Rad;
        v = new Vector3(
            velocity * Mathf.Sin(angle),
            velocity * Mathf.Cos(angle),
            0
            );
        GetComponent<Rigidbody>().AddForce(v, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
