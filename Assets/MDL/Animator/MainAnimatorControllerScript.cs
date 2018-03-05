using System.Collections;
using UnityEngine;


public class MainAnimatorControllerScript : MonoBehaviour
{

	Animator animator;
	private int count;

	void Start ()
	{
		animator = GetComponent <Animator> ();
		count = 1;
	}

	void Update ()
	{
		
		if ((Input.GetMouseButton(0) || Input.touchCount >= 1) && animator.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
		{
			if(count == 1)
			{
				animator.Play ("Int1", -1, 0f);						
				count =2;
			}
			else
			{
				animator.Play ("Int2", -1, 0f);						
				count =1;
			}
		}

		if(Input.GetMouseButton(1) || Input.GetTouch(0).phase == TouchPhase.Moved)
		{
			Application.Quit();
		}
	}

}
