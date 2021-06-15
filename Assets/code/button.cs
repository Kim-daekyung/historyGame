using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button : MonoBehaviour
{
   
    public GameObject Image;
    public GameObject buttone;
    public GameObject text1;
    public GameObject team;
    public GameObject answers;

    public GameObject A1;
    public GameObject A2;
    public GameObject A3;
    public GameObject A4;

    public Text A1Q;
    public Text A2Q;
    public Text A3Q;
    public Text A4Q;
    public Text text;
    public Text teamT;
    public string[] teamname;
    public int[] teamScores = { };
   
    public GameObject Rst;


    public Score scores;
    public int[] answerT;
    public int[] answerF;
    public bool answer = false;
    public int[] answernumber;

    int j=1;
    int e = 1;


    public Player player;
    private void Awake()
    {
        answerF = new int[10];
        answerT = new int[10];

        teamname = new string[10];
        teamScores =new int[10];
        answernumber = new int[20];
    }
    // Start is called before the first frame update
    void Start()
    {
        Rst = Image.transform.Find("Start").gameObject;
        buttone = Image.transform.Find("button").gameObject;
        text1 = Image.transform.Find("Q&A").gameObject;
        team = Image.transform.Find("team").gameObject;
        answers = Image.transform.Find("Answer").gameObject;
        A1 = this.transform.Find("Q1").gameObject;
        A2 = this.transform.Find("Q2").gameObject;
        A3 = this.transform.Find("Q3").gameObject;
        A4 = this.transform.Find("Q4").gameObject;

        teamT = team.GetComponent<Text>();
        A1Q = this.A1.transform.Find("Text").GetComponent<Text>();
        A2Q = this.A2.transform.Find("Text").GetComponent<Text>();
        A3Q = this.A3.transform.Find("Text").GetComponent<Text>();
        A4Q = this.A4.transform.Find("Text").GetComponent<Text>();
        text = text1.GetComponent<Text>();

        Image.SetActive(false);
        Rst.SetActive(false);
        answers.SetActive(false);

        scores = Image.transform.Find("Score").GetComponent<Score>();
        player = FindObjectOfType<Player>();
        for (int i = 1; i <= 5; i++)
        {
            teamname[i]= " " + i + "조";
        }
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    public  void trueAnswer()
    {
        
        Debug.LogError(teamname[j]);
        text.text+= "<color=#0000ffff><size=50>"+ teamname[j]+"정답입니다! </size></color>";
        answer = true;
        answerT[j]++;
        j++;
    }
    public void falseAnswer()
    {
       
        Debug.LogError(teamname[j]);
        text.text += "<color=#FF0000><size=50> "+ teamname[j] +"틀렸습니다! </size></color>";
        answer = true;
        answerF[j]++;
        j++;


    }
    public void Q1()
    {
        teamT.text += teamname[j] + "1번\n";
        teamScores[j]=1;
        j++;
        answers.SetActive(true);
    }

    public void Q2()
    {
        teamT.text += teamname[j] + "2번\n";
        teamScores[j]=2;
        j++;
        answers.SetActive(true);
    }

    public void Q3()
    {
        teamT.text += teamname[j] + "3번\n";
        teamScores[j] = 3;
        j++;
        answers.SetActive(true);
    }

    public void Q4()
    {
        teamT.text += teamname[j] + "4번\n";
        teamScores[j] = 4;
        j++;
        answers.SetActive(true);
    }
    public void Answer()
    {
        text.text = null;
        j = 1;
        scores.ied = 1;
        scores.go = false;
        scores.scoreT.text = null;
        for(int i = 1; i <= 5; i++)
        {
            if (teamScores[i]== answernumber[e])
            {
                Debug.Log("맞음 "+teamScores[i]);
              
                trueAnswer();
            }
            else { 
                Debug.Log("틀림 "+teamScores[i]);
                
                falseAnswer();
            }
        }
        e++;
        player.Qnext.SetActive(true);
        answers.SetActive(false);
        teamT.text = null;
        j = 1;
        
    }

    public void QA()
    {
        if (player.ed == 1)
        {
            answernumber[1] = 1;
            A1Q.text = "뒤주";
            A2Q.text = "전쟁터";
            A3Q.text = " 학교";
            A4Q.text = "왕궁";

        }
        if (player.ed == 2)
        {
            answernumber[2] = 2;
            A1Q.text = "순조";
            A2Q.text = "영조";
            A3Q.text = " 정조";
            A4Q.text = "세종대왕";
        }
        if (player.ed == 3)
        {
            answernumber[3] = 1;
            A1Q.text = "순조";
            A2Q.text = "영조";
            A3Q.text = " 정조";
            A4Q.text = "세종대왕";
        }
        if (player.ed == 4)
        {
            answernumber[4] = 1;
            A1Q.text = "순조";
            A2Q.text = "영조";
            A3Q.text = " 정조";
            A4Q.text = "세종대왕";
        }
        if (player.ed == 5)
        {
            answernumber[5] = 1;
            A1Q.text = "순조";
            A2Q.text = "영조";
            A3Q.text = " 정조";
            A4Q.text = "세종대왕";
        }


    }
    

}
   

