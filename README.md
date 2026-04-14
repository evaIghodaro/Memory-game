# 🧠 Memory Cybersecurity

Jeu de Memory développé en C# avec WinForms (.NET 10), sur le thème de la cybersécurité.

---

##  Fonctionnalités

- Grille dynamique :
  - 4x4 (facile)
  - 6x6 (moyen)
  - 8x8 (difficile)
- Cartes avec thèmes cybersécurité (Virus, Firewall, Hacker, etc.)
- Système de paires avec vérification
- Timer en temps réel
- Compteur d’essais
- Options :
  - Choix de la difficulté
  - Choix de la vitesse
- Boutons :
  - Jouer
  - Options
  - Quitter

---

## 🚀 Lancer le projet

1. Ouvrir la solution `MemoryGame` dans Visual Studio
2. Lancer le projet (F5 ou Ctrl + F5)
3. Cliquer sur **Jouer** pour démarrer une partie

---

##  Conception

Le projet utilise une approche orientée objet :

- Classe `Carte` :
  - Gère l'identité de la carte
  - Son état (cachée, révélée, trouvée)
  - Son apparence

- `Form1` :
  - Gère l’interface utilisateur
  - Les événements (clics, timer)
  - La logique du jeu

---

##  Remarques techniques

- Les images sont générées dynamiquement (placeholders)
- Possibilité d’utiliser de vraies images :
  - Ajouter un dossier `Images`
  - Modifier la méthode `PrepareImages()`

---

## 👤 Maxime Bailly 

Projet réalisé par Eva Ighdaro et Maxime Bailly dans le cadre d’un projet de développement de jeux vidéo en C#.