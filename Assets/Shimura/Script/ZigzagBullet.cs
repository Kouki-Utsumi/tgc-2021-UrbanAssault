using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using DG.Tweening;

public class ZigzagBullet : Bullet
{
    //�K�v�ɂȂ�����DOTween�C���|�[�g���Ă�������
    /*
    [SerializeField]
    GameObject BulletBody;

    [SerializeField,Tooltip("��������"),Range(0,1.0f)]
    float RoundTripTime;

    [SerializeField, Tooltip("�W�O�U�O�x����"), Range(0, 10)]
    public float Zigzag;
    
    protected override void Start()
    {
        base.Start();
        BulletBody = transform.GetChild(0).gameObject;
        StartCoroutine("ZigzagMove");
    }

    protected override void Update()
    {
        base.Update();
    }

    IEnumerator ZigzagMove()
    {
        BulletBody.transform.DOLocalMove(new Vector3(Zigzag/2, 0, 0), RoundTripTime/2);
        yield return new WaitForSeconds(RoundTripTime/2);
        while (true)
        {
            BulletBody.transform.DOLocalMove(new Vector3(-Zigzag, 0, 0), RoundTripTime / 2);
            yield return new WaitForSeconds(RoundTripTime / 2);
            BulletBody.transform.DOLocalMove(new Vector3(Zigzag / 2, 0, 0), RoundTripTime / 2);
            yield return new WaitForSeconds(RoundTripTime / 2);
        }
    }
    */
}
