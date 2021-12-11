using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    GameObject GunWeapon;
    public GameObject Bullet;//銃にセットした弾
    GameObject FireBullet;//発射した弾
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


    //弾の生成と銃の正面方向に力を加える
    void Shoot()
    {
        FireBullet=Instantiate(Bullet, MuzzlePos.transform);
        BulletRig = FireBullet.GetComponent<Rigidbody>();
        BulletRig.AddForce(GunWeapon.transform.forward * BulletSpeed);
    }

}
