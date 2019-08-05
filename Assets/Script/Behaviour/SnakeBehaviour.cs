using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeBehaviour : MonoBehaviour {

	public Snake snake;
	public SnakePiece snakePiece_prefab;
	SnakePiece child_obj;
	SnakePiece lastPiece;
	public GameObject parent_obj;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		if(snake.isGrow){
		 	VerifyLastPieceBody();
		 	snake.isGrow = false;
			snake.bodyCount++;
		}

		if(snake.isWalk){
			if(child_obj!=null){
				child_obj.Follow(transform);
			}
			Walk();
			snake.isWalk = false;
		}

		if(snake.isRotateLeft)
        {
            RotationRight();
            snake.isRotateLeft = false;
            snake.isWalk = true;
        }

        if (snake.isRotateRight)
        {
            RotationLeft();
            snake.isRotateRight = false;
            snake.isWalk = true;
        }

        if (snake.isPoint){
			UIManager.instace.UpdateTextScore(snake.score);
			snake.score++;
			snake.isPoint = false;
		}
				
	}

    private void RotationRight()
    {
        transform.rotation *= Quaternion.AngleAxis(90, Vector3.up);
    }

    private void RotationLeft()
    {
        transform.rotation *= Quaternion.AngleAxis(-90, Vector3.up);
    }

    void Walk(){
		transform.position += transform.forward;
	}

	void VerifyLastPieceBody(){
		SnakePiece obj;
		if(lastPiece ==null)
        {
            obj = SpawnFirstChildBody();
        }
        else
        {
            obj = SpawnChildBody();
        }
		obj.name = "body_"+snake.bodyCount;
		obj.transform.parent = parent_obj.transform;
    }

    private SnakePiece SpawnChildBody()
    {
        SnakePiece obj = Instantiate(snakePiece_prefab, lastPiece.transform.position, lastPiece.transform.rotation);
        lastPiece.child_obj = obj;// adicionar como filho
        lastPiece = obj;//atualizar last piece
        return obj;
    }

    private SnakePiece SpawnFirstChildBody()
    {
        SnakePiece obj = Instantiate(snakePiece_prefab, transform.position, transform.rotation);
        if (child_obj == null)
        {
            child_obj = obj;
        }
        lastPiece = obj;//atualizar last piece
        return obj;
    }
}