using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WalkState : StateMachineBehaviour
{
    float time;
    List<Transform> wayPoints = new List<Transform>();
    NavMeshAgent agent;

    Transform player;
   
    // OnStateEnter được gọi khi transition bắt đầu và state machine bắt đầu đánh giá state này
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        agent = animator.GetComponent<NavMeshAgent>();
        agent.speed = 1.5f;
        time = 0;
        GameObject go = GameObject.FindGameObjectWithTag("WayPoints");
        foreach(Transform t in go.transform)
            wayPoints.Add(t);

        agent.SetDestination(wayPoints[Random.Range(0, wayPoints.Count)].position);
    }

    // OnStateUpdate được gọi trên mỗi frame update giữa OnStateEnter và OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if(agent.remainingDistance <= agent.stoppingDistance)
            agent.SetDestination(wayPoints[Random.Range(0,wayPoints.Count)].position);  

        time += Time.deltaTime;
        if (time > 10)
        {
            animator.SetBool("IsCheck", false);
        }
    }

    // OnStateExit được gọi khi transition kết thúc và state machine kết thúc đánh giá state này
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
            agent.SetDestination(agent.transform.position);
    }
}
