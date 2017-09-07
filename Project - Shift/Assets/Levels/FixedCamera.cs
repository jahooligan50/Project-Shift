using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedCamera : MonoBehaviour {

    [SerializeField] GameObject player;

    Vector3 cameraOffset = new Vector3(0,0,-10f);

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        //keep camera in player's position
        transform.position = player.transform.position + cameraOffset;
    }
}
