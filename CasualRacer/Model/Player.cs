using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasualRacer.Model
{
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Windows;

    /// <summary>
    /// Abbildung eines Spielers.
    /// </summary>

    internal class Player : INotifyPropertyChanged
    {


        private float direction = 90f;

        private float velocity = 0f;

        private int lap = 0;

        private int measuredLap = 1;

        //public Vector position = new Vector();
        private Point position = default(Point);

        /// <summary>
        /// Ruft die Richtung ab oder setzt diese.
        /// </summary>
        public float Direction
        {
            get { return direction; }
            set
            {
                if (direction != value)
                {
                    direction = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Direction)));
                }
            }
        }
        
        /// <summary>
        /// Ruft die Position ab oder setzt diese.
        /// </summary>
        public Vector Position
        {
            get { return position; }
            set
            {
                if (position != value)
                {
                    position = value;
                    if (PropertyChanged != null)
                        PropertyChanged(this, new PropertyChangedEventArgs("Position"));
                }
            }
        }

        /// <summary>
        /// Ruft die Geschwindigkeit ab oder setzt diese.
        /// </summary>
        public float Velocity
        {
            get { return velocity; }
            set
            {
                if (velocity != value)
                {
                    velocity = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Velocity)));
                }
            }
        }

        public Player()
        {

        }

        /// <summary>
        /// Tritt ein, wenn sich ein Eigenschaftswert ändert.
        /// </summary>

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
