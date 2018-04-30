using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; // 이벤트 시스템 등록

public class Rotator : MonoBehaviour {

	[SerializeField]
	private float speed = 40.0f; // 회전속도

	[SerializeField]
	private Vector3 moveDirection; // 회전 방향


	Quaternion origin; // 회전시에 다시 원상태로 돌아오게끔 함 (좀 더 부드러운(자연스러운?) 회전이 가능 함)

	Coroutine flipper = null;
	// Use this for initialization
	void Start () {
		origin = transform.rotation;
	}
	
	// Update is called once per frame
	/*void Update () { // 스크립트가 enabled 상태일 때 매 프레임 마다 호출(물리효과가 적용되지 않은 단순한 타이머, 키입력을 받을 때 사용)
		transform.Rotate(Vector3.right * speed); // 회전시키는 함수 (Vectro3.방향 * 속도)
		
	}*/

	private void FixedUpdate() // 설정된 값에 따라 일정한 간격으로 호출 (물리효과가 적용된 rigidbody 오브젝트 조정시 사용)
	{
		//if (Input.GetMouseButtonDown(0)) // 0은 좌클릭 1은 우클릭, 오브젝트와 상관 없이 실행
		//{
			//if (flipper != null) // flipper 함수가 null값이 아니라면
			//{
			//	StopCoroutine(flipper); // 코루틴 함수 멈춤
			//}
			//print("test"); // 콘솔창에 출력
			//flipper = StartCoroutine(flip()); // 코루틴 함수 시작
			
			/*transform.Rotate(Vector3.right * speed);
			StartCoroutine(flip()); // 코루틴 함수 시작 (flip()과 "flip" 둘다 사용 가능)*/
			
			//print("DONE");
		//}
	}

	//IEnumerator flip()
	//{
	//transform.rotation = origin; // 위 아래 아무데나 상관 없음
	//	int n_frames = 100;
	//	while (n_frames-- >0) // 100까지 회전
	//	{
	//		transform.Rotate(Vector3.right * speed);
	//		yield return new WaitForEndOfFrame(); // 코루틴 휴식 타임 선언
	//		yield return new WaitForSeconds(1.0f); // 1초 쉬었다가 다시 실행
	//		yield return null; // null값 반환, 반환하지 않으면 flip() 오류, 멈추는 장소를 알려 주기 위하여 반환
	// yield return null값을 반환 한 후 다시 while문에서 반복

	/*if (Input.GetMouseButtonDown(1)) // 좌클릭시 멈추기
	{
		print("stop");
		break;
	}*/
	//	}
	//	transform.rotation = origin;
	//}

	//void OnMouseUp() // 클릭한 오브젝트만 실행이 됨.
	private IEnumerator OnMouseUp() // IEnumerator를 사용하여 바로 실행 가능
	{
		print("test");
		int n_frames = 100;
		while (n_frames-- > 0)
		{
			transform.Rotate(Vector3.right * speed);
			yield return null;
		}
		transform.rotation = origin;
		//if(!EventSystem.current.IsPointerOverGameObject()) // EventSystem의 current의 IsPointerOverGameObject가 flase 일 때 UI가 앞에 있다면 UI가 작동을 하고 뒤에 있는 오브젝트는 미작동함.
		//StartCoroutine(flip());
		print("DONE");
	}
	// 클릭한 방향으로 RayCast가 나와 부딪히는 물체를 작동시킴
}
// 순서대로 실행하길 원할때 coroutine 함수를 사용
// update함수는 신경써야 할 게 많아짐
// yield 양보한다는 뜻으로 이해하면 편함(링크참조 : http://theeye.pe.kr/archives/2725)