using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Base_Tank : Macine
{
    // Start is called before the first frame update
    Rigidbody Rb;
    Vector3 Time1;
    void Start()
    {
        Rb = this.gameObject.GetComponent<Rigidbody>();
        Vector3 Time1 = this.gameObject.transform.position;
    }
    public void ConstructorBase_Tank(int num, float Attack, float Acceleration, float Decelerate, float DelayTimeofFiring, float RotateSpeed, int BulletNumofFiring, Vector3 MaxSpeed) 
    {
        ConstructorMacine(num, Attack, Acceleration, Decelerate, DelayTimeofFiring, RotateSpeed, BulletNumofFiring, MaxSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        Accelerate(Rb);
        Rotate();
        Measurement(Rb);


    }
    public void Accelerate(Rigidbody Rb)//�O�i�ւ̉���
    {
        if (SpeedComparison())
        {
            Debug.Log("Moob");
            Rb.AddForce(transform.forward * GetAcceleration() * Input.GetAxis("Horizontal"));


        }

    }
    public void Rotate()//��]
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {

            this.gameObject.transform.Rotate(new Vector3(0, -GetRotateSpeed(), 0));
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {

            this.gameObject.transform.Rotate(new Vector3(0, GetRotateSpeed(), 0));

        }
    }
    
    public void Measurement(Rigidbody Rb)//���݂̃X�s�[�h���Z�o����
    {
        SetSpeed(Rb.velocity);


    }
}
