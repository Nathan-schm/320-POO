using Drones.Helpers;
using Drones.Model;
using Drones.Properties;

namespace Drones
{
    // Cette partie de la classe Drone définit ce qu'est un drone par un modèle numérique
    public partial class Drone
    {
        private int _charge;                          // La charge actuelle de la batterie
        private string _name;                         // Un nom
        private int _x;                               // Position en X depuis la gauche de l'espace aérien
        private int _y;                               // Position en Y depuis le haut de l'espace aérien
        private int _targetX;                         // Objectif en X vers lequel le drone se dirige
        private int _targetY;                         // Objectif en Y vers lequel le drone se dirige
        private State _state;

        enum State { CRASH, LOW_BATTERY, LOADING, ROAMING };


        // Constructeur
        public Drone(int x, int y, string name)
        {
            _x = x;
            _y = y;
            _name = name;
            _charge = RandomHelpers.Next(Config.MAX_LOAD); // La charge initiale de la batterie est choisie aléatoirement
            this._state = State.ROAMING; //état inital du Drone est en Roaming

            // Le drone se fixe un objectif aléatoire quelque part dans l'espace aérien
            _targetX = RandomHelpers.Next(Config.AIRSPACE_WIDTH);
            _targetY = RandomHelpers.Next(Config.AIRSPACE_HEIGHT);
        }

        #region ================ Modelisation du drone et de son comportement ================

        // Cette méthode calcule le nouvel état dans lequel le drone se trouve après
        // que 'interval' millisecondes se sont écoulées
        public void Update(int interval, Charger charger)
        {
            if (_state == State.LOADING)
            {
                _charge += 10;
                if (_charge >= Config.MAX_LOAD)
                {
                    _state = State.ROAMING;
                    _targetX = RandomHelpers.Next(Config.AIRSPACE_WIDTH);
                    _targetY = RandomHelpers.Next(Config.AIRSPACE_HEIGHT);
                }
            }

            if (_charge <= Config.MIN_LOAD)
            {
                _state = State.LOW_BATTERY;
                _targetX = charger.GetX();
                _targetY = charger.GetY();
            }

            double distance = MathHelpers.Distance(_x, _y, _targetX, _targetY);

            if (_state == State.LOW_BATTERY && distance <= Config.SPEED * interval / 1000)
            {
                _state = State.LOADING;
            }

            if (distance <= Config.SPEED * interval / 1000)                 // L'objectif est atteint (ou tout proche)
            {
                _x = _targetX;
                _y = _targetY;
                return;                                   // Le drone s'immobilise
            }

            // Déplacement le long du vecteur unitaire vers l'objectif, à la vitesse du drone
            double dx = _targetX - _x;
            double dy = _targetY - _y;
            _x += (int)(dx / distance * Config.SPEED * interval / 1000);
            _y += (int)(dy / distance * Config.SPEED * interval / 1000);
            _charge-=3;                                    // Il a dépensé de l'énergie


        }

        #endregion

        #region  ================ Rendu graphique  ================

        private const int SIZE = 50;
        private Pen _droneBrush = new Pen(new SolidBrush(Color.Purple), 3);

        // De manière graphique
        public void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawImage(_charge > 0 ? Resources.drone : Resources.boom, _x - SIZE / 2, _y - SIZE / 2, SIZE, SIZE);
            drawingSpace.Graphics.DrawString($"{this}", TextHelpers.drawFont, TextHelpers.writingBrush, _x - SIZE / 2, _y - SIZE);
        }

        // De manière textuelle
        public override string ToString()
        {
            return $"{_name} ({((int)((double)_charge / Config.MAX_LOAD * 100)).ToString()}%)";
        }
        #endregion

    }
}
