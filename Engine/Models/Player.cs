using System;
using System.Collections.Generic;
using System.Collections.ObjectModel; //neccesary for inventory
using System.ComponentModel; //neccesary for pub/sub pattern
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Player : BaseNotificationClass
    {
        //Subscriber Variables to hold attribute values
        private string _name;
        private string _characterClass;
        private int _hitPoints;
        private int _experiencePoints;
        private int _level;
        private int _gold;

        //Pub/Sub Design Pattern to update Private Vars when Properties change in event channel
        public string Name 
        {
            get { return _name; }
            set 
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            } 
        }
        public string CharacterClass
        { 
            get { return _characterClass; }
            set 
            {
                _characterClass = value;
                OnPropertyChanged(nameof(CharacterClass));
            } 
        }
        public int HitPoints 
        { 
            get { return _hitPoints; }
            set 
            {
                _hitPoints = value;
                OnPropertyChanged(nameof(HitPoints));
            } 
        }
        public int ExperiencePoints
        {
            get { return _experiencePoints; }
            set 
            {
                _experiencePoints = value;
                OnPropertyChanged(nameof(ExperiencePoints));
            }
        }
        public int Level 
        { 
            get { return _level; }
            set 
            {
                _level = value;
                OnPropertyChanged(nameof(Level));
            }
        }
        public int Gold 
        { 
            get { return _gold; }
            set 
            {
                _gold = value;
                OnPropertyChanged(nameof(Gold));
            } 
        }

        public ObservableCollection<GameItem> Inventory { get; set; }

        public Player() 
        {
            Inventory = new ObservableCollection<GameItem>();
        }
        
        
    }
}
