﻿using UnityEngine;

public class CameraController : MonoBehaviour {

	public Transform player;
	public Vector3 offset;

    void Start()
    {
     
    }

    // Update is called once per frame
    void Update () {
		transform.position = player.position + offset;
	}
}
