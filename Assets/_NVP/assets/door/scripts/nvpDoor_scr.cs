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
		var animationStateBehaviours = _doorAnimator.GetBehaviours<nvpDoorStateBehaviour_scr>();
		foreach(var beh in animationStateBehaviours){
			beh.doorStateIndicatorRenderer = doorIndicator.GetComponent<Renderer>();
		}
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
