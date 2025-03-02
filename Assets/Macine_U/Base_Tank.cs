using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Base_Tank : Macine
{
    /*
    // Start is called before the first frame update
    Rigidbody Rb;
    Vector3 Time1;
    public GameObject Bullet;
    public int BulletSpeed=100;
    float DelayTimeofFiring;
    private GameObject ThisTank;
    [SerializeField]public GameObject Muzzle;//銃口
    [SerializeField] public GameObject Gun;//銃

    void Start()
    {
        Rb = this.gameObject.GetComponent<Rigidbody>();
        Vector3 Time1 = this.gameObject.transform.position;
        DelayTimeofFiring = GetDelayTimeofFiring();
        ThisTank = this.gameObject;

        //銃口の探索
        Muzzle = transform.Find("GUN/Gun").gameObject;

        //銃の探索
        Gun= transform.Find("GUN").gameObject;
        Gun.transform.Rotate(new Vector3(-GetRotateSpeed()*2, 0, 0));

    }


    // Update is called once per frame
    [SerializeField]float Timer;
    void Update()
    {
        Accelerate(Rb);
        Rotate();
        Measurement(Rb);
        Timer += Time.deltaTime;
        if (Input.GetKey(KeyCode.W))
        {
            if (Timer > DelayTimeofFiring)
            {
                Fire();
                Timer = 0;
            }
        }
        MoobGun();


    }
    public void Accelerate(Rigidbody Rb)//前進への加速
    {
        if (SpeedComparison())
        {
            //Debug.Log("Moob");
            Rb.AddForce(transform.forward * GetAcceleration() * Input.GetAxis("Horizontal"));
            Rb.AddForce(transform.forward * GetAcceleration() * Input.GetAxis("Vertical") *(-1));


        }

    }
    
    
    public void Measurement(Rigidbody Rb)//現在のスピードを算出する
    {
        SetSpeed(Rb.velocity.sqrMagnitude);
    }
    /// <summary>
    /// 銃の発射
    /// </summary>
    public void Fire()
    {
        Vector3 gun_pos= Muzzle.transform.position;
        GameObject bullet=Instantiate(Bullet, gun_pos,this.transform.rotation);
        bullet.GetComponent<Bullet_Tank>().Fire(Muzzle.GetComponent<Rigidbody>());
        
    }
    private float MaxRotate=1.00f;
    private float MinRotate=0.95f;
    public float x;
    /// <summary>
    /// 戦車の上にある銃を上下に動かす
    /// </summary>
    /// <param name="n"></param>
    public void MoobGun()
    {
        x = Gun.transform.rotation.x;
       
        if(x <= MaxRotate)
        {
            if(x >= MinRotate)
            {
                if (Input.GetKey(KeyCode.Q))
                {
                    Gun.transform.Rotate(new Vector3(-GetRotateSpeed(), 0, 0));
                    if(Gun.transform.rotation.x <= MinRotate)
                    {
                        Gun.transform.Rotate(new Vector3(GetRotateSpeed(), 0, 0));
                    }

                }
                else if (Input.GetKey(KeyCode.E))
                {
                    Gun.transform.Rotate(new Vector3(GetRotateSpeed(), 0, 0));
                    if (Gun.transform.rotation.x >= MaxRotate)
                    {
                        Gun.transform.Rotate(new Vector3(-GetRotateSpeed(), 0, 0));
                    }

                }
            }
        }

    }
    */
    
}
