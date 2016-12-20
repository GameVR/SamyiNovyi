using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DamegeEmery : MonoBehaviour {
	public GameObject Emery;
	public GameObject Ragdoll;
    public int score;
    public Text scoreText;

    void Start()
    {
        score = 0;
        scoreText.text = "Score: 0";
    }

    void OnTriggerEnter(Collider other){
		if(other.tag=="MyShot"){
			Emery.SetActive (false);
			Ragdoll.SetActive (true);
		Instantiate(Ragdoll, transform.position, transform.rotation);
        score += 1;
        scoreText.text = "Score: " + score;
       
        }
    }
	

}
