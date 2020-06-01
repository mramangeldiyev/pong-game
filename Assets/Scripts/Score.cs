using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

    public TextMesh currSco;
    public GameObject ballPref;
    public Transform padleObject;

    GameObject ball;
    int score;
	
	void Update ()
    {
        ball = GameObject.FindGameObjectWithTag("Ball");
        currSco.text = "" + score;
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            score += 1;
            Destroy(ball);
            (Instantiate(ballPref, new Vector3(padleObject.transform.position.x + 2, padleObject.transform.position.y, 0), Quaternion.identity) as GameObject).transform.parent = padleObject;
        }
    }
}
