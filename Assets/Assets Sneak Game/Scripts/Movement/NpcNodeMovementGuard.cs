using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NpcNodeMovementGuard : MonoBehaviour{
    public List<Transform> waypoints = new List<Transform>();
    public Transform startingPoint;
    public float turningSpeed = 1f;
    public float searchSpeed = 1f;
    public float walkingspeed = 1f;
    public float wPDistance = 0.1f;
    private float wPDistanceNext;
    private Rigidbody rb;
    public float velocity;

    private void Start(){
        rb = GetComponent<Rigidbody>();
        SetStartPositionAndRotation();
        StartCoroutine(StartMovement());

    }

    private void Update(){

    }

    private void SetStartPositionAndRotation(){
        transform.position = startingPoint.position;
        transform.forward = startingPoint.forward;
    }

    IEnumerator StartMovement(){
        while (true){
            foreach (var waypoint in waypoints){
                // Debug.Log("distance start"+MeasureDistanceToWp(waypoint));

                while (MeasureDistanceToWp(waypoint) > wPDistance){

                    // Debug.Log("distance current"+MeasureDistanceToWp(waypoint));


                    Debug.DrawLine(transform.position, waypoint.position, Color.blue);
                    RotateTowardsWp(waypoint);
                    MoveTowardsWp();
                    yield return null;

                }
            }

        }
    }

    float MeasureDistanceToWp(Transform waypoint){
        var vectorToTarget = waypoint.position - transform.position;
        vectorToTarget.y = 0;
        return vectorToTarget.magnitude;
    }

    void RotateTowardsWp(Transform waypoint){
        Vector3 targetDirection = waypoint.position - transform.position;
        targetDirection.y = 0;
        float singleStep = turningSpeed * Time.deltaTime;

        Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singleStep, 0.0f);


        transform.rotation = Quaternion.LookRotation(newDirection);

    }

    void MoveTowardsWp(){
        rb.velocity = transform.forward * walkingspeed;
        velocity = rb.velocity.magnitude;
    }
}
