using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class togglePhone : MonoBehaviour{
    private Animator animator;
    private bool _phoneIsUp = false;


    private void Start(){
        animator = gameObject.GetComponent<Animator>();
        animator.speed = 1;
        
    }

    public void StopOnLast(){
        _phoneIsUp = true;
    }
    public void StopOnFirst(){
        
        _phoneIsUp = false;
    }
    
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.M)){
            animator.enabled = true;
            if (_phoneIsUp == false){
                // animator.speed = 1;
                animator.Play("PhoneCam");
            }
            else if (_phoneIsUp == true){
                // animator.speed = 1;
                animator.Play("PhoneCam_Rev");
            }
        }
    }
}
