using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    //czas do zakonczenia poziomu
    public float timeLeft = 90f;

    //elementy UI
    public GameObject timeCounter;
    public GameObject gameOverOverlay;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //zmniejsz ilosc czasu pozosta³ego na wykonanie poziomu
        //o czas, który min¹³ od ostaniej klatki
        timeLeft -= Time.deltaTime;



        //aktualizuj UI
        UpdateUI();
    }

    void UpdateUI()
    {
        //funkcja odpowiedzialna za aktualizacjê interfejsu u¿ytkownika

        timeCounter.GetComponent<TextMeshProUGUI>().text = "Pozosta³y czas:" + Mathf.Floor(timeLeft).ToString();

        if (timeLeft <= 0)
            gameOverOverlay.SetActive(true);

    }
    public void OnWin()
    {
        if(other.CompareTag("LevelEnd"))
        {
            GameObject.Find("LevelManager").GetComponent<LevelManager>().OnLose();

        }

    }
}
