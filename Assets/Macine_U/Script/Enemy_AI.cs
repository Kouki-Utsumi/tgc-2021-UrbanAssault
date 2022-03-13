using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_AI : Macine
{
    public Transform target;
    NavMeshAgent agent;
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        agent = GetComponent<NavMeshAgent>();
        target = Enemy_Manegment.playerposition;
    }
    // Update is called once per frame
    void Update()
    {
        
        if (Enemy_Manegment.playerposition == null)
        {
            Debug.Log("target:core");
            target = Enemy_Manegment.core;
        }
        else
        {
            Debug.Log("target:player");
            target = Enemy_Manegment.playerposition;
        }
        agent.SetDestination(target.position);
    }
}
