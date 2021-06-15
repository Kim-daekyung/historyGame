using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed;
    private bool moveOn;
    private Vector3 vector;
    private Collider2D Rcoller;
    private Collider2D Lcoller;

   
    private GameObject Rcamer;
    private GameObject Lcamer;
    public GameObject Image;
    public GameObject button;
    public GameObject text;
    public GameObject Rst;
    public GameObject title;
    public GameObject Qnext;
    public GameObject Endbutton;

    public button buttonT;

    public Text textT;
    public Text titleText;
    public Text score;
    private float waitT = 0;
    public float time;
    public string[] textnuber;
    public bool Stop=false;


    public int ed;
    private void Awake()
    {
        textnuber = new string[10];
    }
    // Start is called before the first frame update
    void Start()
    {
        moveOn = false;
        speed =5.0f;
        Rcamer = this.transform.Find("Right").gameObject;
        Rcoller = Rcamer.GetComponent<Collider2D>();
        Lcamer = this.transform.Find("Left").gameObject;
        Lcoller =Lcamer.GetComponent<Collider2D>();

        Rst = Image.transform.Find("Start").gameObject;
        button = Image.transform.Find("button").gameObject;
        text = Image.transform.Find("Q&A").gameObject;
        textT = text.GetComponent<Text>();
        title = Image.transform.Find("Title").gameObject;
        titleText = title.GetComponent<Text>();
        score = Image.transform.Find("Score").GetComponent<Text>();
        
        buttonT = button.GetComponent<button>();

        Qnext = Image.transform.Find("nextQ").gameObject;

        Endbutton = Image.transform.Find("End").gameObject;
        Qnext.SetActive(false);
        Image.SetActive(false);
        Rst.SetActive(false);

        time = 0f;
        waitT = 5.0f;
        for(int i = 0; i <= 5; i++)
        {
            textnuber[i] = i + " 번";
        }
        ed = 1;
        //button = FindObjectOfType<ButtonEditor>();
     
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow)|| Input.GetKeyDown(KeyCode.LeftArrow)){

            moveOn = true;
        }
        if (this.transform.position.x > 30.0f&&time<waitT&&Stop==false)
        {
            time += Time.deltaTime;
            answerQ();
            
            
           
            Image.SetActive(true);
            text.SetActive(true);
            button.SetActive(false);
            
            


        }
        if (Stop == true)
        {
            buttonT.answers.SetActive(false);
            Endbutton.SetActive(true);
        }
        
       
        if (time>=waitT&&buttonT.answer==false)
        {
            Rst.SetActive(false);
            text.SetActive(false);
            button.SetActive(true);
        }
        if (buttonT.answer == true)
        {
            button.SetActive(false);
            text.SetActive(true);
        }

        
      
    }

    public void answerQ()
    {
        if (ed == 1)
        {
            titleText.text=ed+" 번 문제";
            textT.text =" 사도 세자가  죽은 장소는?";
            buttonT.QA();
            
        }
        else if (ed == 2)
        {
            titleText.text = ed + " 번 문제";
            textT.text =" 사도세자의 아버지는?";
            buttonT.QA();
        }
        else if (ed == 3)
        {
            titleText.text = ed + " 번 문제";
            textT.text = " 3번?";
            buttonT.QA();
        }
        else if (ed == 4)
        {
            titleText.text = ed + " 번 문제";
            textT.text = " 3번?";
            buttonT.QA();
        }
         else if (ed == 5)
        {
            titleText.text = ed + " 번 문제";
            textT.text = " 3번?";
            buttonT.QA();
        }
        else if (ed == 6)
        {
            textT.text = "<size=40>"+score.text+"</size>";
            Stop = true;

        }
      
    }
    private void FixedUpdate()
    {
        Move();     
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (Lcoller.gameObject.tag=="coller" || Rcoller.gameObject.tag=="coller")
        {
            Debug.Log("성");
            moveOn = false;
        }
    }
    public void Move()
    {
        if (moveOn == true)
        {
            if (Input.GetAxisRaw("Horizontal") < 0)
            {
                vector = Vector3.left;
            }
            else if (Input.GetAxisRaw("Horizontal") > 0)
            {
                vector = Vector3.right;
            }
            else
            {
                return;
            }
            
            transform.position += vector * speed * Time.deltaTime;
        }
    }
    public void retry()
    {
        
        time = 0;
        Rst.SetActive(true);
        
    }
    public void reStart()
    {
        time = waitT;
        Rst.SetActive(false);
    }
    
    public void nextQ()
    {
        ed++;
        time = 0;
        button.SetActive(true);
        Qnext.SetActive(false);
        buttonT.answer = false;
        
    }
    public void End()
    {
        Application.Quit();
    }
    
}
