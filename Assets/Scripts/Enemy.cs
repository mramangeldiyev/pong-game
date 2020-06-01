using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    public float speed = 8;
    Vector3 targetPos;
    Vector3 playerPos;
    GameObject ballObj;


	
	
	void Update ()
    {
        ballObj = GameObject.FindGameObjectWithTag("Ball");
        if (ballObj != null)
        {
            targetPos = Vector3.Lerp(gameObject.transform.position, ballObj.transform.position, Time.deltaTime * speed);
            playerPos = new Vector3(-20, Mathf.Clamp(targetPos.y, -12.5F, 12.5F), 0);
            gameObject.transform.position = new Vector3(20, playerPos.y, 0);
        }
	}
}
