using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class Macine : ImgMacine
{
    [SerializeField] private float Attack;
    [SerializeField] private float Acceleration;
    [SerializeField] private float Decelerate;
    [SerializeField] private float DelayTimeofFiring;
    [SerializeField] private float RotateSpeed;
    [SerializeField] private int BulletNumofFiring;
    [SerializeField] private Vector3 MaxSpeed;
    [SerializeField] private float Speed;
    



    public void ConstructorMacine(int num, float Attack, float Acceleration, float Decelerate, float DelayTimeofFiring, float RotateSpeed, int BulletNumofFiring, Vector3 MaxSpeed) 
    {
        ConstructorImgMacine(num);
        this.Attack = Attack;
        this.Acceleration = Acceleration;
        this.Decelerate = Decelerate;
        this.DelayTimeofFiring = DelayTimeofFiring;
        this.RotateSpeed = RotateSpeed;
        this.BulletNumofFiring = BulletNumofFiring;
        this.MaxSpeed = MaxSpeed;
    }

    

    public float GetAttack()//Attack��getter
    {
        return Attack;
    }

    public bool SpeedComparison()//���݂̃X�s�[�h��Max�X�s�[�h���r
    {
        //Debug.Log("Comparison");

        if (MaxSpeed.sqrMagnitude > Speed)
        {
            return true;
        }
        Debug.Log("���x����");
        return false;
    }
    
    

    public void Firing()//����
    {

    }

    public void Break()//����
    {

    }

    public void DecelerateSpeed()//����
    {

    }
    public float GetAcceleration()
    {
        return Acceleration;
    }
    public float GetRotateSpeed()
    {
        return RotateSpeed;
    }
    public float GetDelayTimeofFiring()
    {
        return DelayTimeofFiring;
    }
    public void SetSpeed(float speed)
    {
        Speed = speed;
    }



}
