using UnityEngine;
using System.Collections;

public class EnemyWalk : MonoBehaviour
{

    public GameObject Cowboy ;
    public float timer;
    public bool yes;
    public float newtimer;


    void Start()
    {
        newtimer = timer;

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Cowboy.GetComponent<NavMeshAgent>().enabled = true;
            Cowboy.GetComponent<Animator>().SetTrigger("Walk");


        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            yes = true;
        }



    }
    void Update()
    {
        if (yes == true)
        {
            timer -= Time.deltaTime;
        }
        if (timer < 0)
        {
            Cowboy.GetComponent<NavMeshAgent>().enabled = false;
            yes = false;
            timer = newtimer;
            Cowboy.GetComponent<Animator>().SetTrigger("Idle");
        }

    }
}



