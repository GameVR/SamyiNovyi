using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SheriffAction : MonoBehaviour {

    public Transform Player;
    public Transform Sheriff;
    public float[] distns;
    public bool inVision;
    public float speedR;
    public Canvas dialogCanvas;
    public Text dialogText;
    public float timer = 20.0f;

//    public Text[] listMessage;

	// Use this for initialization
	void Start () {
        dialogCanvas.enabled = false;
        
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

        float distance = Vector3.Distance(transform.position, Player.transform.position);
        if (distance < distns[0])
        {
            
            dialogCanvas.enabled = true;
            
            Quaternion tRot = Quaternion.LookRotation(Player.transform.position - transform.position);
            Sheriff.transform.rotation = Quaternion.Slerp(transform.rotation, tRot, speedR * Time.deltaTime);
           
            if (timer <= 20)
            {
                dialogText.text = "Здравствуй";
                timer -= Time.deltaTime;

            }
            if (timer < 15)
            {
                dialogText.text = "Спаси нас";
                timer -= Time.deltaTime;

            }
            if (timer < 12)
            {
                dialogText.text = "В нашем городе бандит";
                timer -= Time.deltaTime;
            }
            if (timer < 7)
            {
                dialogText.text = "Убей его!";
                timer -= Time.deltaTime;
            }
            if (timer < 5)
            {
                dialogText.text = "Он живет на окраине";
                timer -= Time.deltaTime;
            }
            if (timer < 0)
            {
                timer = 21;            
            }



        }
        else
        {

        }
  
    }
}
