using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace CharacterEditor
{
    public class CharacterEditor : MonoBehaviour
    {
        [SerializeField] Button nextMaterial;
        [SerializeField] Button nextBodyPart;
        [SerializeField] Button loadGame;

        [SerializeField] Character character;

        int id;
        BodyTypes bodyType = BodyTypes.Head;

        private void Awake()
        {
            //TODO: Setup some button listeners to call the NextMaterial, NextBodyPart, and LoadGame functions
        }

        void NextMaterial()
        {
            //TODO: Add 1 to the value of id and if it is 3 or more then reset back to 0

            //TODO: Make a switch case for each BodyType and save the value of id to the correct PlayerPref

            //TODO: Tell the character to load to get the updated body piece
        }

        void NextBodyPart()
        {     
            //TODO: Setup a switch case that will go through the different body types
            //      ie if the current type is Head and we click next then set it to Body

            //TODO: Then setup another switch case that will get the current saved value
            //      from the player prefs for the current body type and set it to id
        }

        void LoadGame()
        {
            SceneManager.LoadScene("Game");
        }
    }
}