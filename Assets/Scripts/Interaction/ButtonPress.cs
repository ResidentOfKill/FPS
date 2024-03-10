using UnityEngine;

namespace CustomAS.Scripts.Interaction{
    public class ButtonPress : MonoBehaviour, IInteractable{
        
        public GameObject door;
        public GameObject buttonLight;
        
        public bool needsKey = false;
        
        public int roomID;
        public string doorColor;
        public void Interact(GameObject actor){
            if (needsKey && !actor.GetComponent<PlayerInventory>().CheckKeyCard(roomID, doorColor)){
                return;
            }
            door.SetActive(false);
            buttonLight.GetComponent<Light>().color = Color.green;
            gameObject.GetComponent<Renderer>().material.color = Color.green;
            actor.GetComponent<PlayerInventory>().DropKeyCard(roomID, doorColor);
        }
    }
}
