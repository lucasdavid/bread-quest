﻿using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	EnemyModel model;

	void Start() {
		model = GetComponent<EnemyModel>();

		// horizontal movement
		iTween.MoveBy(gameObject, iTween.Hash(
			"x", 2,
			"easetype", "linear",
			"looptype","pingpong"
		));
	}

	void FixedUpdate() {
		ProcessMovement();
	}

	public void ProcessMovement() {

	}

	void OnCollisionEnter(Collision c) {
		if (c.gameObject.tag == "Player" && model.isHostile())
		{
			c.gameObject.GetComponent<PlayerModel>().Damage(PlayerModel.FALL_DAMAGE);
		}
		else if (c.gameObject.tag == "Jelly")
		{
			
		}
		else if (c.gameObject.tag == "PeanutButter")
		{
			
		}
	}
}
