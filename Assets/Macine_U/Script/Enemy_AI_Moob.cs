using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_AI_Moob : Macine
{
    // Start is called before the first frame update
    public Enemy_AI enemyAi;
    public int enemyLenge;
    NavMeshAgent agent;
    protected override void Start()
    {
        base.Start();
        agent = GetComponent<NavMeshAgent>();
        enemyAi = GetComponent<Enemy_AI>();
    }

    // Update is called once per frame
    void Update()
    {
        if(enemyLenge>(enemyAi.target.position - transform.position).sqrMagnitude)
        {
            agent.speed = 0f;
        }else
        {
            agent.speed = 4f;
        }
    }
}
