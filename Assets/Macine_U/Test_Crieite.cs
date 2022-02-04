using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Crieite : MonoBehaviour
{
    // Start is called before the first frame update
    Base_Tank TankM;
    public GameObject obj;
    public GameObject bullet;
    GameObject TankS;
    void Start()
    {

        TankS=Instantiate(obj, new Vector3(0.0f, 2.0f, 0.0f), Quaternion.identity);
    }

}
