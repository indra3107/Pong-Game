using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class winnerScript : MonoBehaviour
{
	public TextMeshProUGUI result;
    // Start is called before the first frame update
    void Start()
    {
    	if(ScoringScript.P1 > ScoringScript.P2){
    		result.text = "Player 1 Win";
    	}else if(ScoringScript.P1 < ScoringScript.P2){
    		result.text = "Player 2 Win";
    	}else{
    		result.text = "Draw";
    	}
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
