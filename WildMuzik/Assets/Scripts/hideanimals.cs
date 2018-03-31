using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideanimals : MonoBehaviour {

    public SpriteRenderer hider;
    // Use this for initialization
    void Start()
    {
        
       

    }
    public void Hidethem()
    {
        hider = GetComponent<SpriteRenderer>();
        hider.enabled = true;
        StartCoroutine(countdown());
    }
    IEnumerator countdown()
    {

        yield return new WaitForSeconds(3);
        hider.enabled = false;

    }

// Update is called once per frame
void Update () {
		
	}

}
