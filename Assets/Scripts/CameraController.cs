using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	public GameObject livingRoom;
	public GameObject cube;
	public GameObject mezz;
	public GameObject cantina;
	public Animator animator;
	private GameObject current;

	void Start()
	{
		current = livingRoom;
	}

	public void LivingRoom()
	{
		StartCoroutine(WaitForSeconds());
		animator.SetTrigger("transition");
		current.SetActive(false);
		livingRoom.SetActive(true);
		current = livingRoom;
	}

	public void Cube()
	{
		StartCoroutine(WaitForSeconds());
		animator.SetTrigger("transition");
		current.SetActive(false);
		cube.SetActive(true);
		current = cube;
	}

	public void Mezzanine()
	{
		StartCoroutine(WaitForSeconds());
		animator.SetTrigger("transition");
		current.SetActive(false);
		mezz.SetActive(true);
		current = mezz;
	}

	public void Cantina()
	{
		StartCoroutine(WaitForSeconds());
		animator.SetTrigger("transition");
		current.SetActive(false);
		cantina.SetActive(true);
		current = cantina;
	}

	IEnumerator WaitForSeconds()
	{
		yield return new WaitForSeconds(3);
		Debug.Log("test");
	}
}
