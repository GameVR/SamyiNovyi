using UnityEngine;
using System.Collections;

public class EnemyCowboyAttack : MonoBehaviour
{
    public GameObject Cowboy;
 //   public GameObject DeadZone;

    void Start()
    {
   //     DeadZone.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Cowboy.GetComponent<Animator>().SetTrigger("Idle");
            Cowboy.GetComponent<NavMeshAgent>().enabled = false;
            //    DeadZone.SetActive(true);

        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Cowboy.GetComponent<Animator>().SetTrigger("Walk");
            Cowboy.GetComponent<NavMeshAgent>().enabled = true;
            //        DeadZone.SetActive(false);
        }
    }
}


