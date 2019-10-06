using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;

public class Pathfinding : MonoBehaviour
{
	GameObject player;
	NavMeshAgent enemy;

	//Use this for initialization
	void Start()
	{
		player = GameObject.FindGameObjectWithTag("Player");

		if(player == null)
		{
			Debug.Log("Can't find player tag");
		}

		enemy = GetComponent<NavMeshAgent>();
	}

	//Update is called once per frame
	void Update()
	{
		if (player != null)
		{
			Debug.Log("Found player!");
			enemy.destination = player.transform.position;
		}
	}
}