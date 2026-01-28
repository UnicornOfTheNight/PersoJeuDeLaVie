# 🧬 Perso Jeu de la Vie (Conway's Game of Life)

![Type](https://img.shields.io/badge/Type-Automate%20Cellulaire-purple)
![License](https://img.shields.io/badge/License-MIT-blue)
![Status](https://img.shields.io/badge/Status-Completed-green)

Une implémentation personnelle du célèbre **Jeu de la Vie**, l'automate cellulaire imaginé par John Horton Conway en 1970. C'est un "jeu à zéro joueur", ce qui signifie que son évolution est déterminée uniquement par son état initial, sans intervention humaine ultérieure.

## 📜 Les Règles

L'univers du jeu est une grille infinie (ou bouclée) à deux dimensions. Chaque case est une "cellule", qui peut être soit **vivante** ⬜, soit **morte** ⬛.

À chaque étape (génération), l'état d'une cellule est déterminé par l'état de ses **8 voisines** :

1.  **Sous-population** : Une cellule vivante possédant moins de 2 voisines vivantes meurt. 💀
2.  **Survie** : Une cellule vivante possédant 2 ou 3 voisines vivantes reste vivante. 💖
3.  **Surpopulation** : Une cellule vivante possédant plus de 3 voisines vivantes meurt. 💀
4.  **Reproduction** : Une cellule morte possédant exactement 3 voisines vivantes devient vivante. 🐣

## ✨ Fonctionnalités

* **Grille Dynamique** : Affichage de l'évolution des cellules génération après génération.
* **Initialisation** :
    * Aléatoire (remplissage au hasard).
    * Manuelle (clic pour placer des cellules) ou via fichiers de configuration.
* **Contrôles** :
    * `Pause` / `Play`.
    * `Reset` pour effacer la grille.
    * Gestion de la vitesse de simulation.
* **Structures Connues** : Capable de simuler des motifs classiques comme les *Gliders* (Planeurs), *Blinkers* (Clignotants) ou *Spaceships*.

## 🛠 Technologies & Algorithmes

* **Langage** : [C / C++ / Python / Java]
* **Affichage** : [Console / SDL / SFML / PyGame / Canvas HTML5]

### Défi Technique : Le Double Buffering
Pour que la simulation soit correcte, les calculs de la génération `N+1` doivent se baser uniquement sur l'état de la génération `N`.
> Ce projet utilise deux grilles (tableaux 2D) : une pour l'état actuel (lecture) et une pour l'état futur (écriture). À la fin du tour, on échange les tableaux.

## 🚀 Installation & Utilisation

1.  **Cloner le dépôt :**
    ```bash
    git clone [https://github.com/UnicornOfTheNight/PersoJeuDeLaVie.git](https://github.com/UnicornOfTheNight/PersoJeuDeLaVie.git)
    ```

2.  **Compiler / Lancer :**
    * *Si C/C++ :* `make` ou `gcc main.c -o game && ./game`
    * *Si Python :* `python main.py`

3.  **Commandes (Exemple) :**
    * **Espace** : Mettre en pause.
    * **R** : Réinitialiser.
    * **Clic Souris** : Ajouter/Enlever une cellule.
    * **Echap** : Quitter.

## 🧠 Structures Intéressantes à Tester

Voici quelques motifs que vous pouvez dessiner pour tester l'algorithme :

* **Le Planeur (Glider)** : Se déplace en diagonale.
    ```text
    . O .
    . . O
    O O O
    ```
* **Le Crapaud (Toad)** : Oscille sur 2 périodes.
    ```text
    . O O O
    O O O .
    ```

## 👥 Auteur

* **UnicornOfTheNight** - *Implémentation de l'automate*

---
*Projet réalisé pour explorer les automates cellulaires et la manipulation de tableaux multidimensionnels.*
