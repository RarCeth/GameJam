using UnityEngine;
using System.Collections;

public class EnemyBasic : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){
		ChangeEnemyNumber ();
		Debug.Log ("true");
	}

	public virtual void ChangeEnemyNumber(){

	}
	
}
