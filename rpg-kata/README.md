 
# Kata dojo RPG

## L'équipement simple

On est dans un RPG (jeu de rôle), on a un personnage qui a des caractéristiques: l'attaque et la défense

Ce personnage possède un équipement, c'est une liste d'items qui peuvent modifier les caractéristiques du personnage

une épée +2 en attaque ajoutera 2 points d'attaque au personnage.

ex:
- un personnage avec 10 points en attaque et 10 points en défense qui possède dans son équipement une épée +2 en attaque aura 12 points en attaque et 10 points en défense
- un personnage avec 10 points en attaque et 10 points en défense avec un bouclier -1 en attaque et +5 en défense aura 9 en attaque et 15 en défense
- un personnage avec 10 points en attaque et 10 points en défense avec un arc +3 en attaque et une armure +7 en défense aura 13 en attaque et 17 en défense

*Note: on aura besoin des caractéristiques du personnage avant et après avoir appliqué l'équipement.*

## L'équipement avancé

certain équipements peuvent ajouter un pourcentage d'une caractéristique sur la valeur d'origine du personnage.

ex:
- un personnage avec 10 points en attaque et 10 points en défense avec une cape +20% en défense aura 12 points en défense
- un personnage avec 10 points en attaque et 10 points en défense avec une cape +20% en défense et un casque +50% en défense aura 17 points en défense
- un personnage avec 18 points en attaque avec une dague +40% en attaque aura 25 points en attaque (arrondi)

## Usure de l'équipement

Un item peut s'user, une pourcentage d'usure s'appliquera sur les valeurs qu'il apporte.

ex:
- un personnage avec 10 points en attaque et 10 points en défense avec un bouclier -2 en attaque et +6 en défense usé à 50% aura 9 en attaque et 13 en défense
- un personnage avec 10 points en attaque et 10 points en défense avec un bouclier +6 en défense usé à 70% aura 15 en défense (arrondi supérieur)


# FAQ:

- Si la valeur d'une caractéristiques est inférieure à 0, on mettra 0 pour la caractéristiques à la fin.
