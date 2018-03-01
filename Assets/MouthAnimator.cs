using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Animator))]
public class MouthAnimator : MonoBehaviour {


    Animator _ani;
	// Use this for initialization
	void Start () {
        _ani = gameObject.GetComponent<Animator>();
        _ani.Play("o");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Play(string voice)
    {
        _ani.Play(voice);
    }
}
