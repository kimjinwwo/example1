using System.Collection;
using UnityEngine;

public class Movment : MoneBehaviour
{
	//X축 이동
	private float moveXwidth = 1.5f; //1회 이동 시 거리 (x측) 
	private float moveTimex = 0.1f; //1회 이동 시 소요되는 시간 (X축) 
	private bool  isMove = false; //	true=이동중 , false = 이동 가능 

	//y축 이동 
	private float originY = 0.55f; //점프 및 착지하는 y축 값 
	private float gravity = -9.81f //중력 값 
	private float moveTimeY = 0.3f; //	y축 1회 이동시 소요시간 
	private bool isJump = false; //	 true = 점프중 ,false = 점프 가능

	//Z축 이동 
	private float movespeed = 20.0f; // Z축 이동 속도 


	
}

Private void update ()
{
	
}


public void MoveToX(int x) //외부에서 x축 이동을 할 때 호출하는 메소드 
{
	//현재 점프 중으로 점프 불가능 
	if (isXMove == true) return; //현재 이동하고 있는 상태이기 때문에 종료 

	if (x > 0 && transform.position.x < movexwidth)
    {
		startCoroutine(onMoveToX(x));
    } //X가 0보다 클 경우 플레이어 위치가 왼쪽 또는 가운데 일 시 오른쪽 이동이 가능
	else if (x < 0 && transform.position.x > - movexwidth)
    {
		startCouroutine(onMoveToX(x));
    } // 
}

public void MoveToY()
{
	//현재 점프 중으로 점프 불가능 
	if (isJump == true) return;

	startCoroutine(onMoveToY());
}