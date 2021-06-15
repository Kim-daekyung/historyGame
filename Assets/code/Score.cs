using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject score;
    public GameObject button;
    public Text scoreT;
    public button buttonT;
    public GameObject Image;
    public bool go=true;
    public int ied = 1;
    // Start is called before the first frame update
    void Start()
    {
        score = this.gameObject;
        scoreT = score.GetComponent<Text>();
        button = Image.transform.Find("button").gameObject;
        buttonT = button.GetComponent<button>();
       
           
          
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ied <=5&&go==false)
        {
            scoreT.text +="<color=#808000> " + buttonT.teamname[ied]+ "</color>"+" <color=#00FFFF> 맞은갯수: " + buttonT.answerT[ied] + " </color><color=#FF0000>틀린갯수: </color>" + buttonT.answerF[ied]+"\n";
            ied++;
        }
    }
}
