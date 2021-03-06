﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class KillTarget : MonoBehaviour {
	public Camera camera;
    public ParticleSystem hitEffect;
	public GameObject killEffect;
	public float timeToSelect = 3.0f;
	public int score;
    public Text scoreText;
	private float countDown;
    private GameObject target;
    public GameObject enemyCowboy;
    public GameObject enemyRagdoll;


    void Start () {
		score = 0;
		countDown = timeToSelect;
		hitEffect.enableEmission = false;
        scoreText.text = "Score: 0";
        
	}
	
	void Update () {
		//Ray ray = new Ray (camera.transform.position, camera.transform.rotation * Vector3.forward);
		//RaycastHit hit;
      //  if (Physics.Raycast(ray, out hit) && (hit.collider.gameObject.tag == "EnemyCowboy"))
      //  {
     //       target = hit.collider.gameObject;
      //      if (countDown > 0.0f)
     //       {
                // on target
     //           countDown -= Time.deltaTime;
                //	print (countDown);
      //          hitEffect.transform.position = hit.point;
       //         hitEffect.enableEmission = true;
     //       }
      //      else
      //      {
      //          enemyCowboy.SetActive(false);
      //          enemyRagdoll.SetActive(true);
      //          Instantiate(enemyRagdoll, enemyCowboy.transform.position, enemyCowboy.transform.rotation);
     //           score += 1;
      //          scoreText.text = "Score: " + score;
       //         countDown = timeToSelect;
                
     //       }
    //    }
    //    else
     //   {
            // reset
      //      countDown = timeToSelect;
     //       hitEffect.enableEmission = false;
     //   }
    }

	void SetRandomPosition() {
		float x = Random.Range (-5.0f, 5.0f);
		float z = Random.Range (-5.0f, 5.0f);
		target.transform.position = new Vector3 (x, 0.0f, z);
	}
}
