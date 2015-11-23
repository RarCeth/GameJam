using UnityEngine;
using System.Collections;

public class OnType3 : EnemyBasic {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public override void ChangeEnemyNumber(){
		Camera.main.GetComponent <EnemySpawning> ().nE3 -= 1;
		Destroy (gameObject);
	}
}
