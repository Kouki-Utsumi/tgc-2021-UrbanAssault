using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter : Macine
{
    [SerializeField] float wingsArea;     //���̖ʐ�
    [SerializeField] float airDensity;    //��C���x
    [SerializeField] float speed;         //���x
    [SerializeField] float cl;            //�g�͌W��

    [SerializeField] protected Rigidbody Rb;

    float XZRotate;//�퓬�@�����E�ɐ��񂳂���
    float XYRotate;//�퓬�@���㉺�Ɍ�����


    // Start is called before the first frame update
    public void Start()
    {
        Rb = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Accelerate();//���ʂɐi��
        TurnAround();//WASD�Ői�ޕ�����ς���
    }

    public Fighter(int num, float Attack, float Acceleration)
    {

    }

    void Accelerate()
    {
        var forces = Vector3.zero;
        forces = speed * transform.forward;
        //�g�͂̕���
        Vector3 liftDirection = Vector3.Cross(Rb.velocity, transform.forward).normalized;
        var liftPower = lift(airDensity, wingsArea, speed, cl) / 1000 * Time.deltaTime;
        forces += liftPower * liftDirection;
        //MaxSpeed�������x����������Ή����i�������ێ��������j
        if(Rb.velocity.magnitude<10)Rb.AddForce(forces);
    }

    //�g�͂��擾
    float lift(float air, float wing, float spd, float cl)
    {
        //�g��  =��C���x*���̖ʐ�*���x�̓��*�g�͌W��/ 2
        float l =   air  *   wing *  spd*spd *   cl   / 2;
        return l;
    }

    //�Q�l�@https://teratail.com/questions/331607

    public void TurnAround()
    {
        if (Input.GetKey(KeyCode.W) && XYRotate > -30) XYRotate -= 0.5f;//�@����グ��
        if (Input.GetKey(KeyCode.S) && XYRotate < 30) XYRotate += 0.5f;//�@���������
        if (Input.GetKey(KeyCode.D)) XZRotate += 0.5f;//�E����
        if (Input.GetKey(KeyCode.A)) XZRotate -= 0.5f;//������
        transform.rotation = Quaternion.Euler(XYRotate, XZRotate, 0);
    }
}
