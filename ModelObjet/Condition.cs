using System;

namespace ModelObjet
{
    public class Condition
    {
        const int nbJours = 30;
        // Permet de savoir si on a le droit d'être remboursé
        // On l'est à condition que le nombre de jours ne dépasse pas 30 !
        public static bool Valider(int unNbDeJours)
        {
            
            if (unNbDeJours < nbJours) {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Permet de renvoyer le montant MAX remboursé en fonction de la catégorie
        public static int CalculerMontantMax(string uneCategorie)
        {
            
            int montantMax = 0;
            if(uneCategorie == "Livres")
            {           
                montantMax = 30;
            }

            if(uneCategorie == "Jouets")
            {             
                montantMax = 50;
            }
            if(uneCategorie == "Informatique")
            {
                montantMax = 1000;
            }

            return montantMax;
        }
        // Permet de retourner le total remboursé en fonction de tous les critères
        public static double CalculerMontantRembourse(int unNbDeJours, string uneCategorie, bool estMembre, string unEtat, int unPrix)
        {
            

            return 0;

        }
        // Permet de renvoyer la réduction si on est membre ou pas
        public static double CalculerReductionMembre(bool estMembre)
        {
           double reductionMembre = 0;
            int prix = 0;
            if(estMembre == true)
            {
                reductionMembre = 0;
            }
            else
            {
                reductionMembre = 0.2 * prix;
            }
            
            return reductionMembre;
        }
        // Permet de renvoyer la réduction en fonction de l'état de l'achat
        public static double CalculerReduction(string unEtat)
        {
           double reduction = 0;
          
            if (unEtat == "Abimé")
            {
                reduction = 0.3;
            }
            if (unEtat == "Très abimé")
            {
                reduction = 0.3;
            }
            else
            {
                reduction = 0.1;
            }

            return reduction; 
        }

    }
}

