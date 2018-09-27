using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Fungus;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public Flowchart flowChart;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Dragged(BaseEventData a)
	{
		Debug.Log (a);
	}

	public void FakeBtnCicked()
	{
        var rm = flowChart.GetIntegerVariable("HeadRemain");
        rm--;
        if(rm > 0)
        {

        }
        else
        {
            rm = 3;
            flowChart.SetBooleanVariable("BennettDead", true);
        }

        flowChart.SetIntegerVariable("HeadRemain", rm);
	}


    public void GotoFungusScene()
    {
        SceneManager.LoadScene("FungusAdventure");
    }

    public void GotoHomeScene()
    {
        SceneManager.LoadScene("Home");
    }
}
