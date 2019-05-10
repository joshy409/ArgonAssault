using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    [SerializeField] float delay = 5f;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

	// Use this for initialization
	void Start () {
        StartCoroutine(LoadSceneAfterDelay(delay));
	}

    IEnumerator LoadSceneAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(0);
    }
	
}
