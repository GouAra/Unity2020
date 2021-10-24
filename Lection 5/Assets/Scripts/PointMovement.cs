using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointMovement : MonoBehaviour
{
    //���������� �������� - ������

    static float eps = 6.67e-11f; //�������������� ����������

    public float mass = 10; //����� Point
    public float e; //������������� ��������������

    private float velocity; //��������� ��������, ���� ����� R � velocity = 0
    private float a; //eps * ����� Point * ����� Centre
    private float R; //���������� ����� Centre � Point
    private float K0; //������������ ������
    private float p; //��������� �������� ����������� �������
    private float f = 0;

    void Start()
    {
        a = eps * mass * 1.989e30f;
        R = transform.position.magnitude;
      
        velocity = Random.Range(0.1f, Mathf.Sqrt(2 * a / (mass * R)) - 0.1f); // velocity < Mathf.Sqrt(2 * a / (mass * R)) ��� e < 1
        K0 = R * mass * velocity;
        p = Mathf.Pow(K0, 2) / (mass * a);
    }

    void Update()
    {
        f += K0 / (mass * Mathf.Pow(R, 2) ) * Mathf.Deg2Rad;
        R = p / ( 1 + e * Mathf.Cos(f) );
        transform.position = new Vector3(R * Mathf.Cos(f), R * Mathf.Sin(f), 0);
    }
}
