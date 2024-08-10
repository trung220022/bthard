using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{

    public Quest quest;

    public Text nameText;

    public Text nameText1;

    public Image icon;

    

    // Use this for initialization
    void Start()
    {

        nameText.text = quest.name;
        nameText1.text = quest.name;
        icon.sprite = quest.icon;

    }

}
