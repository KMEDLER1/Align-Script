using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SimpleMove : MonoBehaviour
{
    public GameObject Dest;

    public NavMeshAgent Vehicle;

    // Start is called before the first frame update
    private void Start()
    {
        Vehicle.SetDestination(Dest.transform.position);
    }

    // Update is called once per frame
    private void Update()
    {
    }
}