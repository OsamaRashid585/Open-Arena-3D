using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EntityMovement : MonoBehaviour
{
    private NavMeshAgent _agent;
    private Rigidbody _rb;

    private void OnEnable()
    {
        EntityManager.OnClick += Jump;
    }
    private void OnDisable()
    {
        EntityManager.OnClick -= Jump;
    }
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _rb = GetComponent<Rigidbody>();
        InvokeRepeating("RandomPatrolling",0,5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void RandomPatrolling()
    {
        _agent.SetDestination(new Vector3(Random.Range(-18, 18), 0, Random.Range(-18, 18)));
    }

    private void Jump()
    {

        Debug.Log(gameObject.name);
    }
}
