using System;
using System.Collections.Generic;
using UnityEngine;

namespace CustomAS.Scripts.Interaction{
    public class PlayerInventory : MonoBehaviour{
        private List<KeyCard> _keyCards = new();
        public List<String> DebugCards;
        public void AddKeyCard(int id ,string color){
            _keyCards.Add(new KeyCard(id,color));
            DebugCards.Add(color);
        }
        public bool CheckKeyCard(int id ,string color){
            return _keyCards.Contains( new KeyCard(id,color));
        }
        public void DropKeyCard (int id,string color){
            _keyCards.Remove(new KeyCard(id,color));
            DebugCards.Remove(color);
        }
    }
}

