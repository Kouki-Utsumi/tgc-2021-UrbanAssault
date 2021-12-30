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
    [Tooltip("�e�̃X�s�[�h")]
    public float BulletSpeed;
    [Tooltip("�e�̍U����")]
    public float Attack;//�e�̍U����
    [SerializeField, Tooltip("�A�ː��\�i���b�����ɒe�������j")]
    float DelayTimeofFiring;//�e�̘A�ˑ��x
    float Timer;

    //Macine�ɂ��Ă���e�̐ݒ��Gun�X�N���v�g�ɓ��ꂽ��


    void Start()
    {
        GunWeapon = this.gameObject;
        MuzzlePos = transform.Find("Muzzle").GetComponent<Transform>();
        Fighter = transform.parent.gameObject.GetComponent<Fighter>();
        Timer =DelayTimeofFiring;
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        if (Input.GetMouseButtonDown(0) && Timer > DelayTimeofFiring)
        {
            Shoot();
            Timer = 0;
        }
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
