using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {

	public Transform bullet;
	public int BulletForce = 5000;
	public AudioClip Fire;
	public GameObject Pistol;
	public GameObject FireBole;
	
	void Start(){
		FireBole.SetActive (false);
	}
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			FireBole.SetActive (true);
			Pistol.GetComponent<Animator>(). SetTrigger ("Shot");
			Transform BulletInstance = (Transform) Instantiate (bullet, GameObject.Find ("Spawn").transform.position, Quaternion.identity);
			BulletInstance.GetComponent<Rigidbody>().AddForce (transform.forward * BulletForce);
			GetComponent<AudioSource>().PlayOneShot(Fire);	
		}	
		if(Input.GetMouseButtonUp(0)){
			FireBole.SetActive (false);
		}
		
	
	}
}
	