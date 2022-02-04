using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Tank : Bullet
{
    GameObject ParentTank;
    Rigidbody Rb;
    public void Fire(Rigidbody muzzle_rb)
    {
        Rb = muzzle_rb;
    }
    protected override void Update()
    {
        base.Update();
        Rb.AddForce(ParentTank.transform.forward * 10);
    }


}
