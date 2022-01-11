using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunManager : MonoBehaviour
{
    [SerializeField]
    List<GameObject> OwnedGun = new List<GameObject>();//�e���i�[
    int UsingGun;//�g�p���̏e��OwnedGun�ł̔ԍ�

    void Start()
    {
        UsingGun = 0;
        for (int i = 0; i < OwnedGun.Count; i++) OwnedGun[i].SetActive(false);
        OwnedGun[UsingGun].SetActive(true);
    }

    
    void Update()
    {
        GunSwitching();
    }

    void GunSwitching()
    {
        if (Input.GetKeyDown(KeyCode.E)&&OwnedGun.Count>1)
        {
            Debug.Log("Push E");
            if (UsingGun == OwnedGun.Count - 1)
            {
                OwnedGun[UsingGun].SetActive(false);
                UsingGun = 0;
                OwnedGun[UsingGun].SetActive(true);
            }
           else  if (UsingGun < OwnedGun.Count - 1)
            {
                OwnedGun[UsingGun++].SetActive(false);
                //Debug.Log("UsingGun="+UsingGun);
                OwnedGun[UsingGun].SetActive(true);
                //Debug.Log("UsingGun=" + UsingGun);
            }
        }

        if (Input.GetKeyDown(KeyCode.Q) && OwnedGun.Count > 1)
        {
            Debug.Log("Push Q");
            if (UsingGun >0)
            {
                OwnedGun[UsingGun--].SetActive(false);
                OwnedGun[UsingGun].SetActive(true);
            }
            else if (UsingGun ==0)
            {
                OwnedGun[UsingGun].SetActive(false);
                UsingGun = OwnedGun.Count-1;
                OwnedGun[UsingGun].SetActive(true);
            }
        }
    }
}
