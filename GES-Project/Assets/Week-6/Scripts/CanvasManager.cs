using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
namespace Week11
{


    public class CanvasManager : MonoBehaviour
    {

        // Start is called before the first frame update
        void Start()
        {
            //gameObject.GetComponent<Button>().onClick.AddListener(TaskOnClick);
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void Restart()
        {
            GameManager.instance.OnRestart.Invoke();
        }
        void TaskOnClick()
        {
            Debug.Log("milkshake");
        }
    }
}
