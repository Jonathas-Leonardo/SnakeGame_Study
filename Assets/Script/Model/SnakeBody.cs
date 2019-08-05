using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SnakeBody {

	public int bodyCount;
	public bool isLastBody;
	public bool isWalk;
	public bool isRotateLeft;
	public bool isRotateRight;
	public bool isGrow;
	public bool isStop;
	public bool isDie;
}
