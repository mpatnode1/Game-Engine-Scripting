using System.Diagnostics;
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
            nextMaterial.onClick.AddListener(NextMaterial);
            nextBodyPart.onClick.AddListener(NextBodyPart);
            loadGame.onClick.AddListener(LoadGame);
        }

        void NextMaterial()
        {
            
            //PLEASE READ: I'm not sure if I'm missing something but
            //only the arms in the MaterialManager have a case 0,
            //everything else has case 1-3
            //I changed it in my version of the code to be a 1
            //and used an id 1 for the else statement

            if (id < 3)
            {
                id++;
            }
            else
            {
                //id = 0;
                id = 1;
            }

            //switch case for each BodyType and save the value of id to the correct PlayerPref
            switch (bodyType)
            {
                case BodyTypes.Arm:
                    {
                        PlayerPrefs.SetInt("Arm", id);
                        PlayerPrefs.Save();
                    }
                break;
                case BodyTypes.Body:
                    {
                        PlayerPrefs.SetInt("Body", id);
                        PlayerPrefs.Save();
                    }
                break;
                case BodyTypes.Head:
                    {
                        PlayerPrefs.SetInt("Head", id);
                        PlayerPrefs.Save();
                    }
                break;
                case BodyTypes.Leg:
                    {
                        PlayerPrefs.SetInt("Leg", id);
                        PlayerPrefs.Save();
                    }
                break;
                default:break;
            }

            //TODO: Tell the character to load to get the updated body piece

            character.Load();
        }

        void NextBodyPart()
        {
            //TODO: Setup a switch case that will go through the different body types
            //      ie if the current type is Head and we click next then set it to Body
            switch (bodyType)
            {
                case BodyTypes.Head:
                    {
                        bodyType = BodyTypes.Body;
                    }
                    break;
                case BodyTypes.Body:
                    {
                        bodyType = BodyTypes.Arm;
                    }
                    break;
                case BodyTypes.Arm:
                    {
                        bodyType = BodyTypes.Leg;
                    }
                    break;
                case BodyTypes.Leg:
                    {
                        bodyType = BodyTypes.Head;
                    }
                    break;
                default:break;
            }
            //TODO: Then setup another switch case that will get the current saved value
            //      from the player prefs for the current body type and set it to id

            switch(bodyType)
            {
                case BodyTypes.Head:
                    {
                        PlayerPrefs.SetInt("Head", id);
                        PlayerPrefs.Save();
                    }
                    break;
                case BodyTypes.Body:
                    {
                        PlayerPrefs.SetInt("Body", id);
                        PlayerPrefs.Save();
                    }
                    break;
                case BodyTypes.Arm:
                    {
                        PlayerPrefs.SetInt("Arm", id);
                        PlayerPrefs.Save();
                    }
                    break;
                case BodyTypes.Leg:
                    {
                        PlayerPrefs.SetInt("Leg", id);
                        PlayerPrefs.Save();
                    }
                    break;
                default:break;
            }
        }

        void LoadGame()
        {
            SceneManager.LoadScene("Game");
        }
    }
}