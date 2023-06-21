using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TargetMovement : MonoBehaviour
{
    private Transform _player;
    private NavMeshAgent _agent;

    private void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player").transform;
        _agent = GetComponent<NavMeshAgent>();  
    }

    private void Update()
    {
        _agent.SetDestination(_player.position);
    }
    private void OnDisable()
    {
        _agent.enabled = false;
    }
}
