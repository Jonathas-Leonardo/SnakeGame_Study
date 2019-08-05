using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

[Serializable]
public class Snake{

	public int speed;
	public int score;
	public int bodyCount;
	public bool isWalk;
	public bool isRotateLeft;
	public bool isRotateRight;
	public bool isGrow;
	public bool isStop;
	public bool isDie;
	public bool isPoint;
}
