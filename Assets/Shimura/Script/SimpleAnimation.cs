using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAnimation : MonoBehaviour
{
    public float interval; // �Z�O�����g�̎��ԊԊu
    public GameObject[] waypoints; // �o�R����I�u�W�F�N�g
    private float startTime;
    void Start()
    {
        startTime = Time.time;
    }
    void Update()
    {
        float s = (Time.time - startTime) / interval;
        int seg = (int)s % (waypoints.Length - 1); // ��ԃZ�O�����g�����߂�
        float a = s - Mathf.Floor(s); // �Z�O�����g���ł̐i�s��
        Vector3 pos1 = waypoints[seg].transform.position;
        Vector3 pos2 = waypoints[seg + 1].transform.position;
        transform.position = Vector3.Lerp(pos1, pos2, a); // �i�s���Ő��`���
    }
}
