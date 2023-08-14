using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class CubeObs : MonoBehaviour
{
    MeshRenderer mesh;
    NavMeshAgent agent;

    public Color failColor;
    public GameManager manager;
    public Transform[] waypoints;

    int waypointIndex=0;
    Vector3 target;
    private void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        agent = GetComponent<NavMeshAgent>();
        UpdateDestination();    
    }
    private void Update()
    {
        if (Vector3.Distance(transform.position , target) < 1)
        {
            iterateIndex();
            UpdateDestination();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Player")
        {
            mesh.material.color = failColor;
            manager.fail();
        }
    }
    private void UpdateDestination()
    {
        target = waypoints[waypointIndex].position;
        agent.SetDestination(target);
    }
    private void iterateIndex()
    {
        waypointIndex++;
        if(waypointIndex >= waypoints.Length) waypointIndex = 0;
    }
}
