using UnityEngine;
using System.Collections;

public class OnType1 : EnemyBasic {

	public override void ChangeEnemyNumber(){
		Camera.main.GetComponent <EnemySpawning> ().nE1 -= 1;
		Destroy (gameObject);
	}
}
