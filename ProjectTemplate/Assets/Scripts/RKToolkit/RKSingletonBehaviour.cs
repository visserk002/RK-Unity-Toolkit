using UnityEngine;
using System.Collections;
using System;
using System.Linq.Expressions;

/*
	Simple singleton class.
	If you want something to be the only one ever in existance.
	(like for example a gamecontroller)
	use this.
*/

public class RKSingletonBehaviour: RKBehaviour {

	[HideInInspector] public static RKSingletonBehaviour instance = null;

	void Awake(){

		if (instance == null) {
			instance = this;
		} else if (instance != this) {
			Destroy (gameObject);
		}

		DontDestroyOnLoad (gameObject);

	}
	
}
