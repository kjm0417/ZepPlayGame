using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    [Header("nameSelect")]
    [SerializeField] private InputField nameInputField;
    [SerializeField] private Button startBtn;
    public Text nameText;
    public GameObject NewPlayer;
    public GameObject gameStartUI;
    public GameObject playerSideUI;

    [Header("playerSelect")]
    public GameObject playerChange;
    public GameObject player1;
    public GameObject player2;
    private GameObject objPlayer;
 

    [Header("PlayerNameChange")]
    public GameObject nameChangeUI;
    [SerializeField] private InputField changeInputField;

    [Header("PlayerRoster")]
    public GameObject sideUI;
    public Text rosterText;


    private void Start()
    {
        objPlayer = Resources.Load<GameObject>("Prefab/PlayerPenguin");
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.K))
        {
            sideUI.SetActive(false);
        }

    }
    public void GameStartBtn()
    {
        string name = nameInputField.text;

        if (string.IsNullOrEmpty(name))
        {
            Debug.Log("���ư�");
            return; 
        }

        gameStartUI.SetActive(false);

        // �÷��̾ �ν��Ͻ�ȭ�մϴ�.
        if (objPlayer != null)
        {

            GameObject instantiatedPlayer = Instantiate(objPlayer);
            NewPlayer = instantiatedPlayer;

            // �̸� �ؽ�Ʈ ����
            nameText = NewPlayer.GetComponentInChildren<Canvas>().GetComponentInChildren<Text>();

            if (nameText != null)
            {
                nameText.text = name; // �̸� �ؽ�Ʈ ����
            }
        }
        else
        {
            Debug.Log("����");
        }

        playerSideUI.SetActive(true);
    }


    public void PlayerChange()
    {
        playerChange.SetActive(true);
    }

    public void PlayerPenguin()
    {
         objPlayer = Resources.Load<GameObject>("Prefab/PlayerPenguin");
        playerChange.SetActive(false);
        player1.SetActive(true);
        player2.SetActive(false);
    }

    public void PlayerPlat()
    {
        objPlayer = Resources.Load<GameObject>("Prefab/PlayerPlat");
        playerChange.SetActive(false) ;
        player2.SetActive(true) ;
        player1.SetActive(false);
    }

    public void NameChangeBtn()
    {
        nameChangeUI.SetActive(true);
    }

    public void CheckBtn()
    {
        string changeName = changeInputField.text;

        if (string.IsNullOrEmpty(changeName))
        {
            Debug.Log("���ư�");
            return;
        }

        if(objPlayer != null)
        {
            if (nameText != null)
            {
                nameText.text = changeName; // �̸� �ؽ�Ʈ ����
            }
        }

        nameChangeUI.SetActive(false);
    }

    public void RosterOpen()
    {
        string output = "";
        sideUI.SetActive(true);

        GameObject[] playerRoster = GameObject.FindGameObjectsWithTag("Player");
        GameObject[] npcRoster = GameObject.FindGameObjectsWithTag("Npc");
       
        foreach(GameObject playerRosterItem in playerRoster)
        {
            playerRosterItem.name = nameText.text;
            output += nameText.text+"\n";
        }

        foreach(GameObject npcRosterItem in npcRoster)
        {
           output += npcRosterItem.name;
        }

        rosterText.text = output;
    }

}
