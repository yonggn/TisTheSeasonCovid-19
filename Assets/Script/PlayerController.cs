using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


[System.Serializable]
public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;

    public float movespeed = 5f;

    private Vector2 moveInput;

    public int QuarantineC;
    public int Score;
    public bool levelDone;
    public Text QuarantineNo;
    public Text leScore;
    public Text lives;
    public int lifeNo;
    public GameObject loseWindow;
    public GameObject winWindow;
    public Text finalscore;
    private NweSpawner humanSpawning;
    public Text ScoreToPill;
    public int opillNo;
    public int npillNo;
    public int pillNo;
    public AudioSource wrong;
    public AudioSource bgm;

    // Start is called before the first frame update
    public void Start()
    {
        //Time.timeScale = 1f;
        loseWindow.SetActive(false);
        winWindow.SetActive(false);
        opillNo=PlayerPrefs.GetInt("pills",0);
        lifeNo=PlayerPrefs.GetInt("lives",3);
        QuarantineC = PlayerPrefs.GetInt("quar", 0);
        QuarantineNo.text = QuarantineC.ToString();
        Score = 0;
        leScore.text = Score.ToString();
        bgm.Play();
        
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = new Vector2(Input.GetAxis("Horizontal"), 0);
        rb.velocity = moveInput * movespeed * Time.deltaTime;
        lives.text = lifeNo.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "BadPeople")
        {
            QuarantineC++;
            Score += 10;
            npillNo=Score/5;
        }

        if (collision.tag == "GoodPeople")
        {
            wrong.Play();
            Score -= 10;
            lifeNo--;
            lives.text = lifeNo.ToString();
        }
         pillNo = npillNo+opillNo;
        QuarantineNo.text = QuarantineC.ToString();
        leScore.text = Score.ToString(); 
        finalscore.text = Score.ToString();
        ScoreToPill.text = pillNo.ToString();
        Destroy(collision.gameObject);
        humanSpawning = FindObjectOfType<NweSpawner>();
        humanSpawning.humanNo--;
        if (humanSpawning.spawnTime <= 0)
        {
            humanSpawning.spawnDone = true;
        }
        else if (lifeNo <= 0)
        {
            Time.timeScale = 0f;
            EndGame(); 
        }
    }

    public void EndGame()
    { 
        Time.timeScale = 0f;
        loseWindow.SetActive(true);   
    }

    public void Restart()
    {
        FindObjectOfType<NweSpawner>().Start();
        Start();
        
    }

    public void WinGame()
    {
            Time.timeScale = 0f;
            winWindow.SetActive(true);   
    }

    private void OnDestroy()
    {
        PlayerPrefs.SetInt("pills", pillNo);
        PlayerPrefs.SetInt("lives", lifeNo);
        PlayerPrefs.SetInt("quar", QuarantineC);
        Debug.Log(PlayerPrefs.GetInt("pills")+"  "+PlayerPrefs.GetInt("lives")+"  "+PlayerPrefs.GetInt("quar"));
     
    }

}
