using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireworkSpawner : MonoBehaviour
{
    public GameObject firework;
    public GameObject hero;

    void Start()
    {
        hero = GameObject.FindGameObjectWithTag("Player");
    }

    public void FireworkSpawn()
    {
        firework.transform.localPosition = hero.transform.localPosition;
        Instantiate(firework);
    }
}
