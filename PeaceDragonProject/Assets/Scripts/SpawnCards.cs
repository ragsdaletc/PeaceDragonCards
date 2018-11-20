using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCards : MonoBehaviour {

    public GameObject card;
    public Sprite[] sprites;
    public GameObject[] deck = new GameObject[78];
    Vector3 cardPosition0 = new Vector3(-9, 0, 0);
    Vector3 cardPosition1 = new Vector3(-6, 0, 0);
    Vector3 cardPosition2 = new Vector3(-3, 0, 0);
    Vector3 cardPosition3 = new Vector3(0, 0, -3);
    Vector3 cardPosition4 = new Vector3(3, 0, 0);
    Vector3 cardPosition5 = new Vector3(6, 0, 0);
    Vector3 cardPosition6 = new Vector3(9, 0, 0);
    // Use this for initialization
    void Start () {
        Screen.orientation = ScreenOrientation.Landscape;
        ShuffleArray(sprites);

        for (int i = 0; i < 78; i++)
        {
            //create the cards
            deck[i] = Instantiate(card, new Vector3(0,0,i), Quaternion.Euler( new Vector3(180, 90, 90)));
            //change the cardface sprite
            GameObject cardFace = deck[i].transform.GetChild(1).gameObject;
            cardFace.GetComponent<SpriteRenderer>().sprite = sprites[i];
            deck[i].name = "card" + i;
        }
        deck[0].transform.position = cardPosition0;
        deck[1].transform.position = cardPosition1;
        deck[2].transform.position = cardPosition2;
        deck[3].transform.position = cardPosition3;
        deck[4].transform.position = cardPosition4;
        deck[5].transform.position = cardPosition5;
        deck[6].transform.position = cardPosition6;
    }

    void Update()
    {

    }

    Sprite[] ShuffleArray(Sprite[] x)
    {
        //randomization of playernames in array
        for (int i = x.Length - 1; i > 0; i--)
        {
            int j = Random.Range(0, x.Length);
            //swap the two items in the array
            Sprite temp = x[j];
            x[j] = x[i];
            x[i] = temp;
        }
        return x;
    }




}
