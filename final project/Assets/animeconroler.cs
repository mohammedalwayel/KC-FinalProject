 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; 

public class animeconroler : MonoBehaviour
{

     NavMeshAgent nav;    //متغيرات 
    public Transform[] loc;

    public Transform player;

    public float radius;  //استعمالها للمقارنات 


    float distanceToplayer = Mathf.Infinity;
    bool isAttacked; 
    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {

        distanceToplayer = Vector3.Distance(player.position, transform.position);
        if (isAttacked)
        {

            Attackedplayer();
        }else if(distanceToplayer < radius)
        {

            isAttacked = true;
        }
        if(!nav.pathPending && nav.remainingDistance < 0.5f)
        {

            GoToNextLoc();
        }
    }

    void GoToNextLoc()
    {

        if(loc.Length == 0)
        {

            return; 
        }

        nav.destination = loc[Random.Range(0, loc.Length)].position; 
    }

    void Attackedplayer()
    {
        if(distanceToplayer >= nav.stoppingDistance)
        {

            chaseplayer();
        }
        else if (distanceToplayer <= nav.stoppingDistance)
        {

            shotPlayer();
        }
    }


    void chaseplayer()
    {
        nav.SetDestination(player.position); 

    }
    void shotPlayer()
    {
        Debug.Log("SHOT");

    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }

    private void attack()
    {

         
    }
}
