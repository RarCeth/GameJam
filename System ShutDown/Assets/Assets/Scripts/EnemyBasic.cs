using UnityEngine;
using System.Collections;

public class EnemyBasic : MonoBehaviour {
	private NavMeshAgent myAgent;
	private Vector3 baseLocal;


	void Start () {
		myAgent = GetComponent <NavMeshAgent> ();
		baseLocal = GameObject.FindGameObjectWithTag ("Base").transform.position;
		myAgent.SetDestination (baseLocal);
	}

	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		ChangeEnemyNumber ();
		//ChangeBase health on contact

		Debug.Log ("true");
	}

	public virtual void ChangeEnemyNumber(){

	}
	
}
