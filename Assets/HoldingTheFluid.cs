using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldingTheFluid : MonoBehaviour {

	void OnParticleCollision(GameObject other){


	Debug.Log(other +"is the object in parameters");
	Debug.Log("Collision detected from PS Script");


	}
}
