using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class ZombieMovement : MonoBehaviour
{
    private GameObject gamer;
    // Start is called before the first frame update
    void Start()
    {
        gamer = GameObject.Find("FPSController");
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<NavMeshAgent>().destination=gamer.transform.position;
    }
}
