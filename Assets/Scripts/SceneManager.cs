using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    private GameObject[] targetArray;

    // Deactive the targets to not start recognition under UI
	private void Start ()
    {
        Invoke("DeactiveGO", .1f);
	}
    
    private void DeactiveGO()
    {
        targetArray = GameObject.FindGameObjectsWithTag("Target");

        for (int i = 0; i < targetArray.Length; i++)
        {
            targetArray[i].SetActive(false);
        }
    }
}
