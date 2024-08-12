using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quest11 : MonoBehaviour
{

    public List<Quest> quests = new List<Quest>();

    public void AddQuest(Quest newQuest)
    {
        quests.Add(newQuest);
    }

    public Quest quest;

    public Text nameText;

    public Text nameText1;

    public Image artwork1;
    



    void Start()
    {

        nameText.text = quest.name123;
        nameText1.text = quest.name8;

        artwork1.sprite = quest.artwork;
        
    }

}
