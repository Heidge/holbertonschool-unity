using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerTrigger : MonoBehaviour
{
	public GameObject player;
	void Update()
	{
		
	}

	void OnTriggerExit(Collider other)
	{
		if (!other.CompareTag("Timetrigger"))
		{
			player.GetComponent<Timer>().enabled = true;
		}
		
	}
}
