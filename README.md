# Calculomath

Application Windows Forms pour aider les enfants à pratiquer les calculs de base : addition, soustraction, multiplication et division.

## Prérequis

- Windows
- .NET 10 SDK
- Visual Studio 2026 ou la commande `dotnet`

## Lancer l'application

Depuis Visual Studio, ouvrez la solution et démarrez le projet.

Ou en ligne de commande, à la racine du projet :

- `dotnet run`

## Comment utiliser l'application

### 1. Choisir un utilisateur

Au démarrage, l'écran de configuration s'affiche.

- Pour un nouvel utilisateur, entrez un nom puis cliquez sur `Créer utilisateur`.
- Pour un utilisateur existant, sélectionnez son nom dans la liste.

> Il faut créer ou sélectionner un utilisateur avant de commencer.

### 2. Configurer la séance

Choisissez ensuite les paramètres de la partie :

- le type de calcul : addition, soustraction, multiplication ou division ;
- la valeur minimale ;
- la valeur maximale ;
- la durée de la séance en minutes.

Le minimum doit être inférieur ou égal au maximum.

### 3. Démarrer la partie

Cliquez sur `On commence` pour lancer la séance.

Pendant la partie :

- un calcul apparaît à l'écran ;
- tapez la réponse dans la zone prévue ;
- appuyez sur `Entrée` pour valider.

### 4. Répondre aux calculs

- Si la réponse est correcte, le calcul suivant apparaît automatiquement.
- Si la réponse est incorrecte, la zone devient rouge et l'application affiche une aide visuelle.
- La touche `Suppr` vide la zone de réponse.

Le compteur affiche le nombre de calculs réussis pendant la séance.

### 5. Arrêter la séance

Vous pouvez arrêter la séance avec le bouton `Arrêt`.

Si le temps prévu est écoulé, la séance se termine automatiquement.

Les résultats sont enregistrés automatiquement pour l'utilisateur sélectionné.

## Analyse des résultats

Le bouton `Analyse` permet d'afficher les archives de l'utilisateur courant.

L'écran d'analyse permet de consulter les résultats par période :

- quotidien ;
- hebdomadaire ;
- mensuel ;
- annuel.

## Emplacement des données

Les résultats sont enregistrés dans le dossier :

- `App\Data\<NomUtilisateur>`

Chaque séance est stockée dans un fichier JSON.
