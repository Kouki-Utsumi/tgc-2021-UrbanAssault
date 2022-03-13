using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank_Enemy_Send : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        Enemy_Manegment.playerposition = this.transform;
        
    }


}
