using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
  //public Text scoreText;
  //public Text scoreValue;
  //public Text HeartsText;
  public GameObject GameOver;
  public GameObject[] Turrets;
  public TextMeshProUGUI scoreTextMesh;
  public TextMeshProUGUI scoreValueMesh;
  public TextMeshProUGUI HeartsTextMesh;


  private int score;
  private int hearts;

  private void Start()
  {
    NewGame();
  }
  public void NewGame()
  {
    score = 0;
    hearts = 3;
    //scoreText.text = score.ToString();
    //HeartsText.text = hearts.ToString();

     scoreTextMesh.text = score.ToString();
    HeartsTextMesh.text = hearts.ToString();
  }

  public void IncreaseScore()
  {
    score+=10;
    //scoreText.text = score.ToString();
    scoreTextMesh.text = score.ToString();
  }
  public void DecreaseScore()
  {
    hearts-=1;
    //HeartsText.text = hearts.ToString();
    HeartsTextMesh.text = hearts.ToString();
    if(hearts<=0){
        GameOver.SetActive(true);
        //scoreValue.text=score.ToString();
        scoreValueMesh.text = score.ToString();
        foreach (GameObject tur in Turrets){
          tur.SetActive(false);
        }
    }
  }
}