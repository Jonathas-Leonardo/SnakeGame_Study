using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakePiece : MonoBehaviour {

	public SnakePiece child_obj;

	public void Follow(Transform trans){
		if(child_obj!=null){
			child_obj.Follow(transform);
		}
		transform.position = trans.position;
		transform.rotation = trans.rotation;
	}
}