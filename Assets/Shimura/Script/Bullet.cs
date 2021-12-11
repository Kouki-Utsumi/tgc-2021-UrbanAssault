/*
 * 弾の飛び方は継承したクラスが決める 
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bullet : MonoBehaviour
{
    protected GameObject Weapon;//銃
    protected Rigidbody BulletRig;
    private float Timer;
    public float DeleteTime;//弾が生成されてから消えるまでの時間
    public int Speed = 1000;



    
    protected virtual void Start()
    {
        Timer = 0;
        Weapon = transform.parent.gameObject;
        Debug.Log("Weapon="+Weapon);
        transform.parent = null;
        BulletRig = GetComponent<Rigidbody>();
    }

    
    protected virtual void Update()
    {
        Timer += Time.deltaTime;
        if (Timer >= DeleteTime) Destroy(this.gameObject);
    }


    protected virtual void OnTriggerEnter(Collider other)
    {
        //当たり判定の処理    
    }
}
