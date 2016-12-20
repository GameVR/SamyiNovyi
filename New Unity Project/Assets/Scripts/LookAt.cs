using UnityEngine; //доступ к библиотеке UnityEngine
using System.Collections; //доступ к библиотеке System.Collections

public class LookAt : MonoBehaviour { // название скрипта
	public Transform target; // переменая обьекта слежения
	
	void LateUpdate(){ //функция лейт апдейт
		transform.LookAt(target.transform.position); //поиск обьекта
	}
}

	