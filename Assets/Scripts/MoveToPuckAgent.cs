using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;

public class MoveToPuckAgent : Agent
{

    [SerializeField] private Transform targetTransform;

    public override void OnEpisodeBegin()
    {
        //I want to reset entire scene here....how is scene reset when one team loses a point?
    }

    public override void CollectObservations(VectorSensor sensor)
    {
        sensor.AddObservation(transform.position);
        sensor.AddObservation(targetTransform.position);
    }

    public override void OnActionReceived(ActionBuffers actions)
    {
        float moveX = actions.ContinuousActions[0];
        float moveY = actions.ContinuousActions[1];
        float moveSpeed = 5f;
        transform.position += new Vector3(moveX, moveY, 0) * Time.deltaTime * moveSpeed;

    }

    private void OnTriggerEnter(Collider other)
    {
        SetReward(0.2f);
        Debug.Log("Reward");
    }
}
