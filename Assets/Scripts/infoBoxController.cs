using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infoBoxController : MonoBehaviour
{
	public GameObject infoBox;

	public void InfoBox()
	{
		if (infoBox.activeInHierarchy)
			infoBox.SetActive(false);
		else
			infoBox.SetActive(true);
	}
}
