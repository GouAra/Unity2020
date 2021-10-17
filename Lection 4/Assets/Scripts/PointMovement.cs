using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointMovement : MonoBehaviour
{
    public float G = 6.67e-11f; // �������������� ����������
    public Vector3 velocity;
    public Rigidbody Centre;


    void Start()
    {
        velocity = new Vector3(0, transform.position.z, -transform.position.y); // ������ �������� ����������� ������� �������
        GetComponent<Rigidbody>().AddForce(velocity, ForceMode.VelocityChange);
    }

    void FixedUpdate()
    {
        float r = transform.position.magnitude; // ���������� �� ������ �� �����
        float F = G * Centre.GetComponent<Rigidbody>().mass * GetComponent<Rigidbody>().mass / Mathf.Pow(r, 2);
        Vector3 Force = - F * transform.position.normalized; // ����� ���������� ��������� � ��������� �����
        GetComponent<Rigidbody>().AddForce(Force * Time.fixedDeltaTime, ForceMode.Impulse);
    }
}
