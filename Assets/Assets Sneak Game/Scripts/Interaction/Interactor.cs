using UnityEngine;

namespace CustomAS.Scripts.Interaction{
    interface IInteractable{
        public void Interact(GameObject actor);
    }

    public class Interactor : MonoBehaviour{
        public GameObject actor;
        public Transform interactorSource;
        public float interactRange;
        public GameObject cursor;
        public GameObject cursorE;

        // Update is called once per frame
        void Update(){
            Ray ray = new Ray(interactorSource.position, interactorSource.forward);
            if (Physics.Raycast(ray, out RaycastHit hitInfo, interactRange)){
                if (hitInfo.collider.gameObject.TryGetComponent(out IInteractable interactObj)){
                    cursor.SetActive(false);
                    cursorE.SetActive(true);
                    if (Input.GetKeyDown(KeyCode.E)){

                        interactObj.Interact(actor);
                    }
                }
            }
            else{
                cursor.SetActive(true);
                cursorE.SetActive(false);
            }
        }
    }
}