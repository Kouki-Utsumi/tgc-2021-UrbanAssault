/*
 * �e�̔�ѕ��͌p�������N���X�����߂� 
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bullet : MonoBehaviour
{
    protected Rigidbody BulletRig;
    float Timer;
    [SerializeField,Tooltip("�e�̏��Ŏ���")] 
    float DeleteTime;
    [Tooltip("�e�̍U���́iGun�X�N���v�g����擾�j")] 
    float Attack;//Gun�X�N���v�g��Bullet�X�N���v�g�Ŏ擾�j




    protected virtual void Start()
    {
        Timer = 0;
        transform.parent = null;
        BulletRig = GetComponent<Rigidbody>();
        Debug.Log("�e�U���́F"+Attack);
    }

    
    protected virtual void Update()
    {
        Timer += Time.deltaTime;
        if (Timer >= DeleteTime) Destroy(this.gameObject);
    }


    protected virtual void OnTriggerEnter(Collider other)
    {
        //�����蔻��̏���    
    }

    public void SetAttack(float Attack)
    {
        this.Attack = Attack;
    }
}
