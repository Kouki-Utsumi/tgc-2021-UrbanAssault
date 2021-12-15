using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    public List<GameObject> OwnedBullet = new List<GameObject>();
    public static GameObject UsingBullet;//�g�p���̒e
    static float BulletNumber = 0;//OwnedBullet���X�g�̔z��ԍ��Ƃ��Ďg�p
    // Start is called before the first frame update
    void Start()
    {
        UsingBullet = OwnedBullet[(int)BulletNumber];
    }

    // Update is called once per frame
    void Update()
    {
        ChangeBullet();
        //Debug.Log("UsingBullet=" + UsingBullet) ;
        //Debug.Log("BulletNumber="+BulletNumber );
    }

    void ChangeBullet()
    {
        BulletNumber += 10 * Input.GetAxis("Mouse ScrollWheel");
        if (BulletNumber > OwnedBullet.Count - 1) BulletNumber = 0;
        else if (BulletNumber < 0) BulletNumber = OwnedBullet.Count-1;
        UsingBullet = OwnedBullet[(int)BulletNumber];
    }
}
