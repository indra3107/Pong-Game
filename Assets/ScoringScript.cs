using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoringScript : MonoBehaviour
{
	public TextMeshProUGUI scoringP1, scoringP2;
    // Start is called before the first frame update
    public static int P1=0, P2=0;

    void Start()
    {
    	scoringP1.text = P1.ToString();
    	scoringP2.text = P2.ToString();
    }

    // Update is called once per frame
    public void UpdateScore(string Wall)
    {
    	if(Wall == "wall kanan"){
    		P2 += 1;
    		scoringP2.text = P2.ToString();
    	}else if(Wall == "wall kiri"){
    		P1 += 1;
    		scoringP1.text = P1.ToString();
    	}
        
    }
}
