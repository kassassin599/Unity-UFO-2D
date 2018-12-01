using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeGame : MonoBehaviour {

    float roundStartTime;
    int waitTime;
    float roundStartDelayTime=3f;
    bool roundStarted;

	// Use this for initialization
	void Start () {
        print("Press the space bar oce you think that the alloted time is up.");

        Invoke("SetNewRandomTime", roundStartDelayTime);
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space) && roundStarted){
            InputReceived();
        }

	}

    void InputReceived()
    {
        roundStarted = false;
        float playerWaitTime = Time.time - roundStartTime;
        float error = Mathf.Abs(waitTime - playerWaitTime);



        print("You waited for" + playerWaitTime + " seconds. That's " + error + " seconds off. " + GenerateMessage(error));
        Invoke("SetNewRandomTime", roundStartDelayTime);

    }

    string GenerateMessage(float error)
    {
        string message = "";

        if (error < 0.15f)
        {
            message = "OUTSTANDING!";
        }
        else if (error < 0.75f)
        {
            message = "Exceeds Expectations.";
        }
        else if (error < 1.25f)
        {
            message = "Acceptable";
        }
        else if (error < 1.75f)
        {
            message = "poor";
        }
        else
        {
            message = "DreadFul";
        }

        return message;
    }

    void SetNewRandomTime()
    {
        waitTime = Random.Range(5, 21);
        roundStartTime = Time.time;
        roundStarted = true;

        print(waitTime + " seconds.");
    }
}
