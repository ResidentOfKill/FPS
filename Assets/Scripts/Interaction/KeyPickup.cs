using UnityEngine;

namespace CustomAS.Scripts.Interaction{
    public class KeyPickup : MonoBehaviour, IInteractable{
        public int roomID;
        public string keyColor;
        public void Interact(GameObject actor){
            actor.GetComponent<PlayerInventory>().AddKeyCard(roomID, keyColor);
            Destroy(gameObject);
        }
    }
}
