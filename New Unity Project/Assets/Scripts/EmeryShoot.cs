using UnityEngine; //доступ к библиотеке UnityEngine
using System.Collections; //доступ к библиотеке System.Collections

public class EmeryShoot : MonoBehaviour { // название скрипта
	public GameObject Emery; //  переменная врага
	public GameObject FireBole; //  переменная огня из оружия
	public GameObject ModelEmery; // переменная модели врага
	public Transform bullet; //  переменная пули
	public int BulletForce = 5000; // числовая переменная силы пули 
	public float bullettimer = 1F; // таймер разрыва стрельбы
	public float bulletnewtimer = 1F; // таймер разрыва стрельбы
	public float exittimer = 1; // таймер выхода из зоны обстрела
	public float exitnewtimer = 1; // таймер выхода из зоны обстрела
	public bool exit; // булевая переменная выхода из зоны обстрела
	public AudioClip Fire; // звук выстрела
	
	void Update (){ // функция апдейт
		if(exit==true){ // если булевая переменая выхода из зоны обстрелаа = ДА
		exittimer -= Time.deltaTime; // отнятие из таймера выхода из зоны обстрела 1 секунды каждый кадр
		}
		if(exittimer<0){ // если таймер разрыва пуль меньше 0
			Emery.GetComponent<NavMeshAgent>().enabled = false; // то в переменной врага включаеться компонент NavMeshAgent 
			exit=false; //  булевая переменная выхода из зоны обстрела = НЕТ
			ModelEmery.GetComponent<Animator>().SetTrigger ("Idle"); // то в переменной модели врага, в компоненте Animator включаеться тригер Idle
			exittimer = exitnewtimer; // таймер выхода из зоны обстрела = таймер выхода из зоны обстрела. Т.Е. самому себе.
		}
		if(bullettimer<1.1F){ // если таймер разрыва пуль меньше 1.1
			FireBole.SetActive(true); // то переменная огня из оружия включается 
		}
		if(bullettimer<1){ // если таймер разрыва пуль меньше 1
			FireBole.SetActive(false); // то переменная огня из оружия выключается
		}
	}
	void OnTriggerEnter (Collider other){ // функция входа в тригер
		if(other.tag == "Player"){ // если тег Player входит в тригер на обьекте
			Emery.GetComponent<LookAt>().enabled = true; // то на переменная врага включается компонент LookAt
			if(bullettimer<0){ //  если таймер разрыва пуль меньше 0
				bullettimer = bulletnewtimer; // то таймер разрыва пуль = таймер разрыва пуль
			}
			if(bullettimer>1.1F){ // если таймер разрыва пуль меньше 1.1
				Transform BulletInstance = (Transform) Instantiate (bullet, GameObject.Find ("SpawnBullet").transform.position, Quaternion.identity); // точка от куда появляеться пуля
			    BulletInstance.GetComponent<Rigidbody>().AddForce (transform.forward * BulletForce); // сила и направление пули
				GetComponent<AudioSource>().PlayOneShot(Fire);	// на обьекте воспроизводиться AudioSource (Fire) один раз
			}
		}
	}
	void OnTriggerStay (Collider other){ // функция нахождения в тригере
		if(other.tag == "Player"){ // если тег Player находиться в тригер на обьекте
			bullettimer -= Time.deltaTime; // отнятие из таймера разрыва пуль 1 секунды каждый кадр
			if(bullettimer<0){ //  если таймер разрыва пуль меньше 0
				bullettimer = bulletnewtimer; // таймер выхода из зоны обстрела = таймер выхода из зоны обстрела. Т.Е. самому себе.
			}
			if(bullettimer>1.1F){ // если таймер разрыва пуль меньше 1.1
				Transform BulletInstance = (Transform) Instantiate (bullet, GameObject.Find ("SpawnBullet").transform.position, Quaternion.identity); //точка от куда появляеться пуля
			    BulletInstance.GetComponent<Rigidbody>().AddForce (transform.forward * BulletForce); //сила и направление пули
				GetComponent<AudioSource>().PlayOneShot(Fire); // на обьекте воспроизводиться AudioSource (Fire) один раз
			}
		}
	}
	void OnTriggerExit (Collider other){ // функция выхода из тригера
		if(other.tag == "Player"){ // если тег Player выходит из тригера на обьекте
			Emery.GetComponent<LookAt>().enabled = false; // то на переменной врага отключеться компонент LookAt
			Emery.GetComponent<NavMeshAgent>().enabled = true; // то на переменной врага включается компонент NavMeshAgent
			exit=true; // булевая переменная выхода из зоны обстрела = ДА
			ModelEmery.GetComponent<Animator>().SetTrigger ("Walk"); // то в переменной модели врага, в компоненте Animator включаеться тригер Walk
		}
	}
}

// Script by MaUR10.
	
	