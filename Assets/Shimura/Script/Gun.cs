using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    GameObject GunWeapon;
    Fighter Fighter;//���̏e�𓋍ڂ��Ă���e�I�u�W�F�N�g
    public GameObject Bullet;//�e�ɃZ�b�g�����e
    GameObject FireBullet;//���˂����e
    Rigidbody BulletRig;
    Transform MuzzlePos;
    public float BulletSpeed;
    float Attack;//�e�̍U���́i�e�I�u�W�F�N�g����擾�j


    void Start()
    {
        GunWeapon = this.gameObject;
        MuzzlePos = transform.Find("Muzzle").GetComponent<Transform>();
        Fighter = transform.parent.gameObject.GetComponent<Fighter>();
        Attack = Fighter.GetAttack();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) Shoot();
        Bullet = BulletManager.UsingBullet;
    }


    //�e�̐����Əe�̐��ʕ����ɗ͂�������
    void Shoot()
    {
        //�e����
        FireBullet=Instantiate(Bullet, MuzzlePos.transform);
        //�e�̍U���͂�ݒ�
        Bullet b = FireBullet.GetComponent<Bullet>();
        b.SetAttack(Attack);
        //�e��O���ɔ�΂�
        BulletRig = FireBullet.GetComponent<Rigidbody>();
        BulletRig.AddForce(GunWeapon.transform.forward * BulletSpeed);  
        
    }

}
