using UnityEngine;
using System.Collections;

public class Clicker : MonoBehaviour {

	public bool clicked()
    {
        return Input.anyKeyDown;
    }
}
