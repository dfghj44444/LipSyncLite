using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
[RequireComponent(typeof(Animator))]
public class MouthAnimator : MonoBehaviour {


    Animator _ani;
    float playProtect = 0.1f;
    float played = 0;
    string lastWord = "";
	// Use this for initialization
	void Start () {
        _ani = gameObject.GetComponent<Animator>();
        _ani.Play("o");
	}
	
	// Update is called once per frame
	void Update () {
        played += Time.deltaTime;
	}

    public void Play(string voice)
    {
        if (voice == null || played<playProtect)
            return; 
        if (voice.Equals("a") || voice.Equals("o") || voice.Equals("e") || voice.Equals("i") || voice.Equals("u") || voice.Equals("v"))
        {

            _ani.CrossFade(voice,0.08f);
            //_ani.Play(voice);
            Debug.Log(voice);
            played = 0f;
        }
    }
}
