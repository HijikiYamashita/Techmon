using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountScripts : MonoBehaviour
{
    public Text text;
    public int number;
    public Text damage;
    public int total;
    public AudioSource sound;

    void Start()
    {
        number = 0;
        sound = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (total >= 100)
        {
            SceneManager.LoadScene("Clear");
        }
    }

    public void CountUp()
    {
        number = number + 1;
        text.text = number.ToString();
    }

    public void Attack()
    {
        total = total + number;
        damage.text = total.ToString();
        sound.PlayOneShot(sound.clip);
    }
}
