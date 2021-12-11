using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    GameObject GunWeapon;
    public GameObject Bullet;//�e�ɃZ�b�g�����e
    GameObject FireBullet;//���˂����e
    Rigidbody BulletRig;
    Transform MuzzlePos;
    public float BulletSpeed;
    int OffensivePower;


    void Start()
    {
        GunWeapon = this.gameObject;
        MuzzlePos = transform.Find("Muzzle").GetComponent<Transform>();
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
        FireBullet=Instantiate(Bullet, MuzzlePos.transform);
        BulletRig = FireBullet.GetComponent<Rigidbody>();
        BulletRig.AddForce(GunWeapon.transform.forward * BulletSpeed);
    }

}
