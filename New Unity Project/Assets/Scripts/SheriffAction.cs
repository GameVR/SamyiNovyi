using UnityEngine;
using System.Collections;

public class SheriffAction : MonoBehaviour {

    public Transform Player;
    public Transform Sheriff;
    public bool inVision;



	// Use this for initialization
	void Start () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            inVision = true;
            

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            inVision = false;
        }



    }

    // Update is called once per frame
    void Update () {
        if (inVision)
        {
           
        }
        else
        {
   
        }     
        
    }
}
