using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DailyQuestManager : MonoBehaviour
{
    public QuestDataBase questDatabase;
    public DailyQuestItemHandler dailyQuestItemHandler;
    public Transform rootUiContent;
    private void Start()
    {


        foreach (var questData in questDatabase.questData)
        {
            CreatQuest(questData);
        }
    }

     
    private void CreatQuest(DailyQuestData questData)
    {
        var quest = Instantiate(dailyQuestItemHandler, rootUiContent);
        quest.SetData(questData);
    }





}
