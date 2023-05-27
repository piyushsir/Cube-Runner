using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gamemanager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obstacle;
    public Transform spawnPoint;
    public GameObject player;
    public GameObject playbutton;
    int score=0;
    public TextMeshProUGUI scoretext;
    void Start()
    {

    }

    // Update is called once per frame

    void Update()
    {
        
    }
    IEnumerator SpawnObstacles()
    {
        while(true)
        {
            float waitTime=Random.Range(0.9f,2f);
            yield return new WaitForSeconds(waitTime);
            Instantiate(obstacle,spawnPoint.position,Quaternion.identity);
        }
    }
   void scoreUp()
    {
        score=score+1;
        scoretext.text=(score.ToString());
    }

    public void GameStart()
    {
        player.SetActive(true);
        playbutton.SetActive(false);

        StartCoroutine("SpawnObstacles");
        InvokeRepeating("scoreUp",2f,1f);
    }
}
