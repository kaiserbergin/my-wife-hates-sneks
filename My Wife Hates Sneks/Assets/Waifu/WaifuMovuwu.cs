using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WaifuMovuwu : MonoBehaviour
{
    public WayPoint[] WayPoints;
    public int CurrentWayPointIndex;
    private NavMeshAgent NavMeshAgent;
    // Start is called before the first frame update
    void Start()
    {
        NavMeshAgent = GetComponentInChildren<NavMeshAgent>();

        CurrentWayPointIndex = 0;
        NavigateToNextWayPoint();
    }

    // Update is called once per frame
    void Update()
    {
        if (ArrivedAtWaypoint())
        {
            SetNextWayPointIndex();
            NavigateToNextWayPoint();
        }
    }

    private void NavigateToNextWayPoint()
    {
        NavMeshAgent.SetDestination(WayPoints[CurrentWayPointIndex].transform.position);
    }

    private bool ArrivedAtWaypoint()
    {
        return transform.position.x == WayPoints[CurrentWayPointIndex].transform.position.x && transform.position.z == WayPoints[CurrentWayPointIndex].transform.position.z;
    }

    private void SetNextWayPointIndex()
    {
        CurrentWayPointIndex = CurrentWayPointIndex == WayPoints.Length - 1 ? 0 : CurrentWayPointIndex + 1;
    }
}
