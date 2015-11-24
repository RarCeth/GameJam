using UnityEngine;
using System.Collections;

public class OnType2 : EnemyBasic {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public override void ChangeEnemyNumber(){
		Camera.main.GetComponent <EnemySpawning> ().nE2 -= 1;
		Destroy (gameObject);
	}
}
