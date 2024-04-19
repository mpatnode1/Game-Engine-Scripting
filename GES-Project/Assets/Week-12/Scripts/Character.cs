using UnityEngine;

namespace CharacterEditor
{
    public class Character : MonoBehaviour
    {
        [SerializeField] private MeshRenderer m_Head;
        [SerializeField] private MeshRenderer m_Body;
        [SerializeField] private MeshRenderer m_ArmR;
        [SerializeField] private MeshRenderer m_ArmL;
        [SerializeField] private MeshRenderer m_LegR;
        [SerializeField] private MeshRenderer m_LegL;

        private void Start()
        {
            Load();
        }

        public void Load()
        {
            //Load materials from the MaterialManager and pass in the id pulled from each PlayerPref here
            Material bodyMaterial = MaterialManager.Get(BodyTypes.Body, PlayerPrefs.GetInt("Body"));
            m_Body.material = bodyMaterial;

            Material armMaterial = MaterialManager.Get(BodyTypes.Arm, PlayerPrefs.GetInt("Arm"));
            m_ArmR.material = armMaterial;
            m_ArmL.material = armMaterial;

            Material legMaterial = MaterialManager.Get(BodyTypes.Leg, PlayerPrefs.GetInt("Leg"));
            m_LegR.material = legMaterial;
            m_LegL.material = legMaterial;

            Material headMaterial = MaterialManager.Get(BodyTypes.Head, PlayerPrefs.GetInt("Head"));
            m_Head.material = headMaterial;

        }
    }
}