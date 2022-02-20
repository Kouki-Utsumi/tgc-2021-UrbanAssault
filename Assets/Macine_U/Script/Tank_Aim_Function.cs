using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank_Aim_Function : Tank_Move_Function
{
    private Transform transform_gun;
    protected override void Start()
    {
        base.Start();
        transform_gun = transform.Find("GUN").transform;
        
    }
    
    protected override void Update()
    {
        base.Update();
        
        if (Input.GetKey(KeyCode.A))
        {
            PushA();
        }
        else if (Input.GetKey(KeyCode.Z))
        {
            PushZ();
        }
        checkrotatex = transform_gun.localEulerAngles.x;

        pcheckrotatex = Mathf.Abs(gameObject.transform.localEulerAngles.x);
        x = checkrotatex - pcheckrotatex;

    }
    [SerializeField] private float max_rotate = 0.0f;
    [SerializeField] private float min_rotate = -0.6f;
    public float checkrotatex;
    public float pcheckrotatex;
    public float x;

    public override void PushA()
    {
        
        if (transform_gun.localEulerAngles.x < max_rotate)
        {
            transform_gun.Rotate(new Vector3(rotate_speed, 0, 0));
            
        }
    }
    public override void PushZ()
    {
        
        if (transform_gun.localEulerAngles.x > min_rotate)
        {
            transform_gun.Rotate(new Vector3(-rotate_speed, 0, 0));
            

        }
        
    }
}
