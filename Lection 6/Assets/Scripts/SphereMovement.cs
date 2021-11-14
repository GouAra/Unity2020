using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    public float theta; //���� � �������� ����� �������� �������� � OX
    public float phi; //���� � �������� ����� �������� �������� � OY
    public float velocity; //������ ��������
    private Vector3 v; //������ ��������


    void Start()
    {
        v = new Vector3(
            velocity * Mathf.Sin(theta * Mathf.Deg2Rad) *  Mathf.Cos(phi * Mathf.Deg2Rad), 
            velocity * Mathf.Cos(theta * Mathf.Deg2Rad),
            velocity * Mathf.Sin(theta * Mathf.Deg2Rad) * Mathf.Sin(phi * Mathf.Deg2Rad));
        GetComponent<Rigidbody>().AddForce(v, ForceMode.VelocityChange);
    }

    void FixedUpdate()
    {

    }
}
