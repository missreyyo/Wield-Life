using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class ZombieMovement : MonoBehaviour
{
    public GameObject heart;
    private GameObject gamer;
    private int zombielife = 3;
    private float far;
    // Start is called before the first frame update
    void Start()
    {
        gamer = GameObject.Find("Gamer");
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<NavMeshAgent>().destination=gamer.transform.position;
        far=Vector3.Distance(transform.position,gamer.transform.position);
        if(far<10f){
             GetComponentInChildren<Animation>().Play("Zombie_Attack_01");

        }
    }
     private void OnCollisionEnter(Collision shotting){
        if(shotting.collider.gameObject.tag.Equals("fire")){
            zombielife--;
            if(zombielife==0){
                Instantiate(heart, transform.position, Quaternion.identity);
                GetComponentInChildren<Animation>().Play("Zombie_Death_01");
                Destroy(this.gameObject,1.667f);
            }
        }
     }
}
