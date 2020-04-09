using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timerScript : MonoBehaviour
{
	public int counter = 30;
    // Start is called before the first frame update
    public Text timer;
    void Start()
    {
        timer.text = counter.ToString();
        StartCoroutine(HitungMundur());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator HitungMundur()
    {
    	while(counter > 0)
    	{
    		
    		yield return new WaitForSeconds(1);
    		counter--;
    		timer.text = counter.ToString();
    	}

    	SceneManager.LoadScene("GameOver");
    }
}
