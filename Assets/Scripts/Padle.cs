using UnityEngine;
using System.Collections;

public class Padle : MonoBehaviour {

    public float padleSpeed = 1;
    public Vector3 playerPos;

	void Update ()
    {
        float yPos = gameObject.transform.position.y + (Input.GetAxis("Vertical") * padleSpeed);
        playerPos = new Vector3(-20, Mathf.Clamp(yPos, -12.5F ,12.5F), 0);
        gameObject.transform.position = playerPos;
	}
}
