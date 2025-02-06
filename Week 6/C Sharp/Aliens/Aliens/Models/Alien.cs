using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Aliens.Models
{
    internal class Alien
    {
        // Properties
        private bool dead;
        private bool dodging;
        private int health;

        //Implementing appropriate getters and setters for the class

        public bool Dead { get => dead; set => dead = value; }
        public bool Dodging { get => dodging; set => dodging = value; }
        public int Health { get => health; set => health = value; }

        // Class constructor
        public Alien(bool dodging, int alienHealth)
        {
            //Initializing the data members
            Dodging = dodging;
            Health = alienHealth;
            Dead = Health <= 0; //If the health is less than or equal to 0, the alien is dead

        }

        // Methods

        //Set dodging to true if the alien is alive//
        public void Dodge()
        {
            if (!Dead)
            {
                Dodging = true;
            }
            else
            {
                Dodging = false;
            }

        }

        //Reduces the alien health by 1. Minimum Alien health should 0.//
        public void Hit()
        {
            if (Health > 0)
            {
                Health--;
            }
            else
            {
                Health = 0;
            }
        }

        //Sets dodging to false//
        public void Miss()
        {
            Dodging = false;

        }

    }
}
