using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nvpDoor_scr : MonoBehaviour {

	// +++ fields +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
	[SerializeField] private bool _open;
	[SerializeField] private bool _opened;
	[SerializeField] private Animator _doorAnimator;
	public GameObject doorIndicator;


	// +++ unity callbacks ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
	void Start () {
		
	}

	void Update () {
		if(_open != _opened){
			_opened = _open;
			_doorAnimator.SetBool("open", _open);
		}
	}


	// +++ event handler ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
	void OnTriggerEnter(Collider other)
	{
		Debug.Log(other.name);
		if(other.tag == "Player"){

			_open = true;
		}
	}

	void OnTriggerExit(Collider ohter){
		if(ohter.tag == "Player"){
			_open = false;
		}
	}


}
