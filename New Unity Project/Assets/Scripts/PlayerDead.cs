using UnityEngine;
using System.Collections;

public class PlayerDead : MonoBehaviour
{
    public GameObject Player;
    public Canvas deadCanvas;
    

    void Start()
    {
        deadCanvas.enabled = false;

    }

    void OnTriggerEnter(Collider other)
    {
	    if (other.tag == "MyShot")
        {
            deadCanvas.enabled = true;
            Player.SetActive (false);
            Debug.Log("re");
            
	    }
    }


}
	