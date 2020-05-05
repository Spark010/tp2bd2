using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2bd2
{
    class Menu_Console
    {

        /*
         * if(Int32.TryParse(input, out int number)){}else{}
         */

        /*---------------- Affichage des menus ------------------*/
        public static void afficher_menu_principale()
        {
            //Affiche le menu principale
            Console.Out.WriteLine("Menu Principale");
            Console.Out.WriteLine("-----------------");
            Console.Out.WriteLine("1: Créer");
            Console.Out.WriteLine("2: Afficher");
            Console.Out.WriteLine("3: Mettre à jour");
            Console.Out.WriteLine("4: Supprimer");
            Console.Out.WriteLine("");
            Console.Out.WriteLine("0: Quitter");
            Console.Out.WriteLine("");
            Console.Out.Write("Choix: ");
        }

        public static void afficher_menu_creer()
        {
            //affiche le menu de création
            Console.Out.WriteLine("");
            Console.Out.WriteLine("Menu Créer");
            Console.Out.WriteLine("-----------------");
            Console.Out.WriteLine("1: Étudiant");
            Console.Out.WriteLine("2: Supérieur");
            Console.Out.WriteLine("");
            Console.Out.WriteLine("0: Quitter");
            Console.Out.WriteLine("");
            Console.Out.Write("Choix: ");
        }

        public static void afficher_menu_affichage()
        {
            //affiche le menu d'affichage
            Console.Out.WriteLine("Menu d'affichage");
            Console.Out.WriteLine("-----------------");
            Console.Out.WriteLine("1: Étudiant");
            Console.Out.WriteLine("2: Supérieur");
            Console.Out.WriteLine("");
            Console.Out.WriteLine("0: Quitter");
            Console.Out.WriteLine("");
            Console.Out.Write("Choix: ");
        }

        public static void afficher_menu_mise_a_jour()
        {
            //affiche le menu de mise à jour
            Console.Out.WriteLine("Menu de Mise à jour");
            Console.Out.WriteLine("-----------------");
            Console.Out.WriteLine("1: Étudiant");
            Console.Out.WriteLine("2: Supérieur");
            Console.Out.WriteLine("");
            Console.Out.WriteLine("0: Quitter");
            Console.Out.WriteLine("");
            Console.Out.Write("Choix: ");
        }

        public static void afficher_menu_maj_etudiant()
        {
            //affiche le menu de choix de mise à jour d'attribut d'étudiant
            Console.Out.WriteLine("Menu Mettre à jour étudiant");
            Console.Out.WriteLine("-----------------");
            Console.Out.WriteLine("1: Prénom");
            Console.Out.WriteLine("2: Nom");
            Console.Out.WriteLine("3: Supérieur");
            Console.Out.WriteLine("");
            Console.Out.WriteLine("0: Quitter");
            Console.Out.WriteLine("");
            Console.Out.Write("Choix: ");
        }

        public static void afficher_menu_maj_superieur()
        {
            //affiche le menu de choix de mise à jour d'attribut de supérieur
            Console.Out.WriteLine("Menu mise à jour Supérieur");
            Console.Out.WriteLine("-----------------");
            Console.Out.WriteLine("1: Prénom");
            Console.Out.WriteLine("2: Nom");
            Console.Out.WriteLine("");
            Console.Out.WriteLine("0: Quitter");
            Console.Out.WriteLine("");
            Console.Out.Write("Choix: ");
        }

        public static void afficher_supprimer()
        {
            //affiche le menu de suppression
            Console.Out.WriteLine("Menu Supprimer");
            Console.Out.WriteLine("-----------------");
            Console.Out.WriteLine("1: Étudiant");
            Console.Out.WriteLine("2: Supérieur");
            Console.Out.WriteLine("");
            Console.Out.WriteLine("0: Quitter");
            Console.Out.WriteLine("");
            Console.Out.Write("Choix: ");
        }

        /*------------------- Mécanique du menu ------------------*/

        public static void attendre()
        {
            //Permet d'attendre la lecture de la sortie à l'utilisateur
            Console.Out.WriteLine("");
            Console.Out.WriteLine("appuyer sur une touche pour continuer ...");
            Console.ReadKey();
        }

        public static bool MenuPrincipal(bool est_en_fonction)
        {
            //affichage du menu
            Console.Clear();
            afficher_menu_principale();
            String temp_entree = Console.ReadLine(); //aquisition de l'entrée de l'utilisateur
            if (Int32.TryParse(temp_entree, out int entreeUtilisateur)) //si on as une string pouvant être un int on continue
            {
                switch (entreeUtilisateur) //Sélection de la fonction
                {
                    case 1:
                        //Création
                        MenuCreer();
                        attendre();
                        break;
                    case 2:
                        //Afficher
                        MenuAffichage();
                        attendre();
                        break;
                    case 3:
                        //Mise à jour
                        MenuMiseAJour();
                        attendre();
                        break;
                    case 4:
                        //Supprimer
                        MenuSupprimer();
                        attendre();
                        break;
                    case 0:
                        est_en_fonction = false;
                        break;
                    default:
                        //par défaut de trouver un cas on indique une erreur de choix
                        Console.Beep();
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Out.WriteLine("Le chiffre entrée ne correspond pas à une entrée valide.");
                        attendre();
                        Console.BackgroundColor = ConsoleColor.Black;
                        break;
                }
            }
            else
            {
                //sinon on indique que la valeur n'est pas un chiffre
                Console.Beep();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Out.WriteLine("Erreur la valeur entrée n'est pas un chiffre.");
                attendre();
                Console.BackgroundColor = ConsoleColor.Black;
            }
            return est_en_fonction;
        }

        public static void MenuCreer()
        {
            //affichage du menu
            bool menu_creer_en_fonction = true;
            do
            {
                Console.Clear();
                afficher_menu_creer();
                String temp_entree = Console.ReadLine();
                //aquisition de l'entrée de l'utilisateur
                if (Int32.TryParse(temp_entree, out int entreeUtilisateur))
                //si la valeur peut être un int on continue
                {
                    switch (entreeUtilisateur) //on sélection la fonction
                    {
                        case 1:
                            //Etudiant
                            creer__etudiant();
                            attendre();
                            break;
                        case 2:
                            //Superieur
                            creer_superviseur();
                            attendre();
                            break;
                        case 0:
                            menu_creer_en_fonction = false;
                            break;
                        default:
                            //par défaut si aucun cas n'est trouvée on indique un message d'erreur de choix invalide
                            Console.Beep();
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Out.WriteLine("Le chiffre entrée ne correspond pas à une entrée valide.");
                            attendre();
                            break;
                    }
                }
                else
                {
                    //sinon on indique un message d'erreur que la valeur entrée n'est pas un chiffre
                    Console.Beep();
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Out.WriteLine("Erreur la valeur entrée n'est pas un chiffre.");
                    attendre();
                }
            } while (menu_creer_en_fonction);
        }

        public static void MenuAffichage()
        {
            //affichage du menu
            bool menu_affichage_en_fonction = true;
            do
            {
                Console.Clear();
                afficher_menu_affichage();
                String temp_entree = Console.ReadLine();
                //aquisition de l'entrée de l'utilisateur
                if (Int32.TryParse(temp_entree, out int entreeUtilisateur))
                //si la valeur peut être un int on continue
                {
                    switch (entreeUtilisateur) //on sélection la fonction
                    {
                        case 1:
                            //Étudiant
                            afficher_etudiant();
                            attendre();
                            break;
                        case 2:
                            //Supérieur
                            afficher_superviseur();
                            attendre();
                            break;
                        case 0:
                            menu_affichage_en_fonction = false;
                            break;
                        default:
                            //par défaut si aucun cas n'est trouvée on indique un message d'erreur de choix invalide
                            Console.Beep();
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Out.WriteLine("Le chiffre entrée ne correspond pas à une entrée valide.");
                            attendre();
                            Console.BackgroundColor = ConsoleColor.Black;
                            break;
                    }
                }
                else
                {
                    //sinon on indique un message d'erreur que la valeur entrée n'est pas un chiffre
                    Console.Beep();
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Out.WriteLine("Erreur la valeur entrée n'est pas un chiffre.");
                    attendre();
                    Console.BackgroundColor = ConsoleColor.Black;
                }
            } while (menu_affichage_en_fonction);
        }

        public static void MenuMiseAJour()
        {
            //affichage du menu
            bool menu_en_fonction = true;
            do
            {
                Console.Clear();
                afficher_menu_mise_a_jour();
                String temp_entree = Console.ReadLine();
                //aquisition de l'entrée de l'utilisateur
                if (Int32.TryParse(temp_entree, out int entreeUtilisateur))
                //si la valeur peut être un int on continue
                {
                    switch (entreeUtilisateur) //on sélection la fonction
                    {
                        case 1:
                            //Étudiant
                            MenuMAJEtudiant();
                            attendre();
                            break;
                        case 2:
                            //Supérieur
                            MenuMAJSuperieur();
                            attendre();
                            break;
                        case 0:
                            menu_en_fonction = false;
                            break;
                        default:
                            //par défaut si aucun cas n'est trouvée on indique un message d'erreur de choix invalide
                            Console.Beep();
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Out.WriteLine("Le chiffre entrée ne correspond pas à une entrée valide.");
                            attendre();
                            Console.BackgroundColor = ConsoleColor.Black;
                            break;
                    }
                }
                else
                {
                    //sinon on indique un message d'erreur que la valeur entrée n'est pas un chiffre
                    Console.Beep();
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Out.WriteLine("Erreur la valeur entrée n'est pas un chiffre.");
                    attendre();
                    Console.BackgroundColor = ConsoleColor.Black;
                }
            } while (menu_en_fonction);
        }

        public static void MenuMAJSuperieur()
        {
            //affichage du menu
            bool menu_en_fonction = true;
            do
            {
                Console.Clear();
                afficher_supprimer();
                String temp_entree = Console.ReadLine();
                //aquisition de l'entrée de l'utilisateur
                if (Int32.TryParse(temp_entree, out int entreeUtilisateur))
                //si la valeur peut être un int on continue
                {
                    switch (entreeUtilisateur) //on sélection la fonction
                    {
                        case 1:
                            //Prénom
                            maj_superviseur_prenom();
                            attendre();
                            break;
                        case 2:
                            //Nom
                            maj_superviseur_nom();
                            attendre();
                            break;
                        case 0:
                            menu_en_fonction = false;
                            break;
                        default:
                            //par défaut si aucun cas n'est trouvée on indique un message d'erreur de choix invalide
                            Console.Beep();
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Out.WriteLine("Le chiffre entrée ne correspond pas à une entrée valide.");
                            attendre();
                            Console.BackgroundColor = ConsoleColor.Black;
                            break;
                    }
                }
                else
                {
                    //sinon on indique un message d'erreur que la valeur entrée n'est pas un chiffre
                    Console.Beep();
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Out.WriteLine("Erreur la valeur entrée n'est pas un chiffre.");
                    attendre();
                    Console.BackgroundColor = ConsoleColor.Black;
                }
            } while (menu_en_fonction);
        }

        public static void MenuMAJEtudiant()
        {
            //affichage du menu
            bool menu_en_fonction = true;
            do
            {
                Console.Clear();
                afficher_supprimer();
                String temp_entree = Console.ReadLine();
                //aquisition de l'entrée de l'utilisateur
                if (Int32.TryParse(temp_entree, out int entreeUtilisateur))
                //si la valeur peut être un int on continue
                {
                    switch (entreeUtilisateur) //on sélection la fonction
                    {
                        case 1:
                            //Prénom
                            maj_etudiant_prenom();
                            attendre();
                            break;
                        case 2:
                            //Nom
                            maj_etudiant_nom();
                            attendre();
                            break;
                        case 3:
                            //superviseur
                            maj_etudiant_superviseur();
                            attendre();
                            break;
                        case 0:
                            menu_en_fonction = false;
                            break;
                        default:
                            //par défaut si aucun cas n'est trouvée on indique un message d'erreur de choix invalide
                            Console.Beep();
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Out.WriteLine("Le chiffre entrée ne correspond pas à une entrée valide.");
                            attendre();
                            Console.BackgroundColor = ConsoleColor.Black;
                            break;
                    }
                }
                else
                {
                    //sinon on indique un message d'erreur que la valeur entrée n'est pas un chiffre
                    Console.Beep();
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Out.WriteLine("Erreur la valeur entrée n'est pas un chiffre.");
                    attendre();
                    Console.BackgroundColor = ConsoleColor.Black;
                }
            } while (menu_en_fonction);
        }

        public static void MenuSupprimer()
        {
            //affichage du menu
            bool menu_en_fonction = true;
            do
            {
                Console.Clear();
                afficher_supprimer();
                String temp_entree = Console.ReadLine();
                //aquisition de l'entrée de l'utilisateur
                if (Int32.TryParse(temp_entree, out int entreeUtilisateur))
                //si la valeur peut être un int on continue
                {
                    switch (entreeUtilisateur) //on sélection la fonction
                    {
                        case 1:
                            //Étudiant
                            supprimer_etudiant();
                            attendre();
                            break;
                        case 2:
                            //Supérieur
                            supprimer_superviseur();
                            attendre();
                            break;
                        case 0:
                            menu_en_fonction = false;
                            break;
                        default:
                            //par défaut si aucun cas n'est trouvée on indique un message d'erreur de choix invalide
                            Console.Beep();
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Out.WriteLine("Le chiffre entrée ne correspond pas à une entrée valide.");
                            attendre();
                            Console.BackgroundColor = ConsoleColor.Black;
                            break;
                    }
                }
                else
                {
                    //sinon on indique un message d'erreur que la valeur entrée n'est pas un chiffre
                    Console.Beep();
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Out.WriteLine("Erreur la valeur entrée n'est pas un chiffre.");
                    attendre();
                    Console.BackgroundColor = ConsoleColor.Black;
                }
            } while (menu_en_fonction);
        }

        /*------------------------ TODO --------------------------*/

        public static int creer_personne()
        {
            //crée une personne
            String new_prenom; //Son prenom
            String new_nom; //son nom de famille
            int p_id; //son numéro d'identification
            Personne la_personne; //l'objet qui sera utiliser pour créer la personne
            Console.Out.WriteLine("Création du compte utilisateur");
            Console.Out.WriteLine("-----------------");
            //on demande son prénom
            Console.Out.Write("Prenom: ");
            new_prenom = Console.ReadLine();
            //on demande son nom de famille
            Console.Out.Write("Nom Famille: ");
            new_nom = Console.ReadLine();
            //on vas chercher le prochain numéro d'identification valide
            p_id = get_new_personne_id();
            //on crée l'objet de la prersonne avec les informations requeillis
            la_personne = new Personne { personne_id = p_id, prenom = new_prenom, nom = new_nom };
            using (var db = new tp2bd2Entities())
            {
                //on ajoute la personne
                db.Personnes.Add(la_personne);
                //on enregistre le contexte
                db.SaveChanges();
            }
            //on retoure l'identifiant de la personne (celui-ci est réutiliser)
            return p_id;
        }

        public static void creer__etudiant()
        {
            //crée un superviseur
            int e_da; //Le numéro de dadmission
            int s_id; // le numéro d'identification du supérieur
            int p_id; //le numéro d'identification de la personne
            Etudiant un_etudiant; //objet etudiant
            //on crée la personne et on récupere son identifiant
            p_id = creer_personne();
            //on vas voir sur la base de donnée le prochain identifiant disponible
            e_da = get_new_etudiant_da();
            //on demande a l'utilisateur de choisir un superviseur
            s_id = choisir_superviseur();
            //on crée l'objet etudiant avec les information requillis
            un_etudiant = new Etudiant { personne_id = p_id, superviseurs_id = s_id, da = e_da};
            using (var db = new tp2bd2Entities())
            {
                //ajour a la base de donnée et sauvegarde du context
                db.Etudiants.Add(un_etudiant);
                db.SaveChanges();
            }
        }

        public static void creer_superviseur()
        {
            //Est le menu de base du logiciel Affiche seulement la base
            int p_id; //identification de la personne
            int s_id; //identification du supérieur
            //on crée la personne et récupéere son nouvele identifiant
            p_id = creer_personne();
            //on récupere le prochain identifiant de supérieur disponible
            s_id = get_new_superviseur_id();
            //on crée l'objet de supérieur avec les informations requillis
            Superviseur un_superviseur = new Superviseur { superviseurs_id = s_id, personne_id = p_id };
            using (var db = new tp2bd2Entities())
            {
                //on ajoute et sauvegarde 
                db.Superviseurs.Add(un_superviseur);
                db.SaveChanges();
            }
        }

        public static int choisir_superviseur()
        {
            bool choix_superviseur_en_cours = true;
            //permet de choisir un superviseur
            int retour = 0;
            using (var db = new tp2bd2Entities())
            {
                //on demande la liste des Id existant
                var querySuperviseur = from i in db.Superviseurs
                                       orderby i.superviseurs_id
                                       select i.superviseurs_id;

                while (choix_superviseur_en_cours)
                {
                    //on affiche la liste puis demande qui on veut et valide le choix
                    afficher_superviseur();
                    Console.Out.Write("ID Choisis: ");
                    String temp_entree = Console.ReadLine();
                    if (Int32.TryParse(temp_entree, out int entreeUtilisateur))
                    {
                        foreach (var element in querySuperviseur)
                        {
                            if (entreeUtilisateur == element)
                            {
                                choix_superviseur_en_cours = false;
                                retour = entreeUtilisateur;
                            }
                        }
                        if (choix_superviseur_en_cours)
                        {
                            Console.Beep();
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Out.WriteLine("Erreur: le chiffre entrée n'est pas valide");
                            attendre();
                            Console.BackgroundColor = ConsoleColor.Black;
                        }
                    }
                    else
                    {
                        Console.Beep();
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Erreur l'entrée n'est pas un chiffre");
                        attendre();
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                }
                //on retourne l'identifiant
                return retour;
            }
        }

        public static int choisir_etudiant()
        {
            bool choix_en_cours = true;
            int retour = 0;
            //permet de choisir un superviseur
            //on récupère la liste des id existant
            using (var db = new tp2bd2Entities())
            {
                var queryEtudiant = from i in db.Etudiants
                                       orderby i.da
                                       select i.da;

                while (choix_en_cours)
                {
                    afficher_etudiant();
                    //on montre la liste a l'utilisateur puis on demande pour quelle étudiant
                    Console.Out.Write("ID Choisis: ");
                    String temp_entree = Console.ReadLine();
                    //ici on valide que le choix est valide puis retourne l'identifiant
                    if (Int32.TryParse(temp_entree, out int entreeUtilisateur))
                    {
                        foreach (var element in queryEtudiant)
                        {
                            if (entreeUtilisateur == element)
                            {
                                choix_en_cours = false;

                            }
                            
                        }
                        if (choix_en_cours)
                        {
                            Console.Out.WriteLine("Erreur: le chiffre entrée n'est pas valide");
                        } else
                        {
                            retour = entreeUtilisateur;
                        }
                    } else {
                        Console.WriteLine("Erreur l'entrée n'est pas un chiffre");
                    }
                }
                return retour;
            }
        }

        public static void afficher_superviseur()
        {
            //affiche la liste de superviseurs
            using (var db = new tp2bd2Entities())
            {
                var querySuperviseur = from i in db.Superviseurs
                                       join j in db.Personnes on i.personne_id equals j.personne_id
                                       orderby i.superviseurs_id
                                       select new { s_id = i.superviseurs_id, s_prenom = j.prenom, s_nom = j.nom };

                foreach (var element in querySuperviseur)
                {
                    Console.Out.WriteLine("ID: " + element.s_id + "  " + element.s_prenom + " " + element.s_nom);
                }
            }
        }

        public static void afficher_etudiant()
        {
            //affiche la liste des étudiants
            //on veux le nom de la personne et son id
            using (var db = new tp2bd2Entities())
            {
                var queryEtudiants = from i in db.Etudiants
                                     join j in db.Personnes on i.personne_id equals j.personne_id
                                     orderby i.da
                                     select new { e_id = i.da, e_prenom = j.prenom, e_nom = j.nom };
                foreach (var element in queryEtudiants)
                {
                    Console.Out.WriteLine("DA: " + element.e_id + "  " + element.e_prenom + " " + element.e_nom);
                }
            }
        }

        public static int get_new_personne_id()
        {
            int retour = 0;
            //récupère le prochain identifiant valide
            using (var db = new tp2bd2Entities())
            {
                var queryPersonne = from i in db.Personnes
                                     orderby i.personne_id
                                     select i.personne_id;
                foreach (var element in queryPersonne)
                {
                    if (element > retour)
                    {
                        retour = element;
                    }
                }
            }
            retour += 1;
            return retour;
        }

        public static int get_new_etudiant_da()
        {
            //récupéere le prochain identifiant valide
            int retour = 0;
            using (var db = new tp2bd2Entities())
            {
                var queryEtudiants = from i in db.Etudiants
                                     orderby i.da
                                     select i.da;
                foreach (var element in queryEtudiants)
                {
                    if (element > retour)
                    {
                        retour = element;
                    }
                }
            }
            retour += 1;
            return retour;
        }

        public static int get_new_superviseur_id()
        {
            //récupére le prochain identifiant valide
            int retour = 0;
            using (var db = new tp2bd2Entities())
            {
                var querySuperviseur = from i in db.Superviseurs
                                       orderby i.superviseurs_id
                                       select i.superviseurs_id;

                foreach (var element in querySuperviseur)
                {
                    if (element > retour)
                    {
                        retour = element;
                    }
                }
            }
            retour += 1;
            return retour;
        }
        public static void maj_superviseur_prenom()
        {
            //met a jour le prenom du superviseur
            int s_id = choisir_superviseur();
            Personne la_personne = get_personne_id_superviseur(s_id);
            Console.Out.Write("Nouveau prenom : ");
            la_personne.prenom = Console.ReadLine();
            maj_personne_prenom(la_personne);
        }

        public static void maj_superviseur_nom()
        {
            //met a jour le nom du superviseur
            int s_id = choisir_superviseur();
            Personne la_personne = get_personne_id_superviseur(s_id);
            Console.Out.Write("Nouveau nom de famille : ");
            la_personne.nom = Console.ReadLine();
            maj_personne_nom(la_personne);
        }

        public static void maj_etudiant_prenom()
        {
            //mettre à jour le prénom de l'etudiant
            int e_id = choisir_etudiant();
            Personne la_personne = get_personne_id_etudiant(e_id);
            Console.Out.Write("Nouveau prenom : ");
            la_personne.prenom = Console.ReadLine();
            maj_personne_prenom(la_personne);
        }

        public static void maj_etudiant_nom()
        {
            //mettre à jour le nom de l'etudiant
            int e_id = choisir_etudiant();
            Personne la_personne = get_personne_id_etudiant(e_id);
            Console.Out.Write("Nouveau nom de famille : ");
            la_personne.nom = Console.ReadLine();
            maj_personne_nom(la_personne);
        }

        public static void maj_etudiant_superviseur()
        {
            //mettre à jour le superviseur de l'etudiant
            int e_id = choisir_etudiant();
            Etudiant un_etudiant =  get_objet_etudiant(e_id);
            un_etudiant.superviseurs_id = choisir_superviseur();
            using (var db = new tp2bd2Entities())
            {
                db.Etudiants.Attach(un_etudiant);
                db.Entry(un_etudiant).Property(x => x.superviseurs_id).IsModified = true;
                db.SaveChanges();
            }
            

        }

        public static Etudiant get_objet_etudiant(int e_id)
        {
            //permet de récupéré l'objet de l'étudiant
            Etudiant un_etudiant = new Etudiant();
            using (var db = new tp2bd2Entities())
            {
                var queryEtudiant = from i in db.Etudiants
                                    where i.da == e_id
                                    orderby i.da
                                    select new { e_da = i.da, e_personne_id = i.personne_id, e_superviseurs_id = i.superviseurs_id };


                foreach (var element in queryEtudiant)
                {
                    if (e_id == element.e_da)
                    {
                        un_etudiant = new Etudiant { personne_id = element.e_personne_id, superviseurs_id = element.e_superviseurs_id };
                    }
                }
            }
            return un_etudiant;
        }
        public static void supprimer_etudiant()
        {
            //suprime un étudiant
            int e_da = choisir_etudiant();
            Personne la_personne = get_personne_id_etudiant(e_da);

            using (var db = new tp2bd2Entities())
            {
                var un_etudiant = new Etudiant { da = e_da };
                db.Etudiants.Attach(un_etudiant);
                db.Etudiants.Remove(un_etudiant);
                db.Personnes.Attach(la_personne);
                db.Personnes.Remove(la_personne);
                db.SaveChanges();

            }
        }

        public static void supprimer_superviseur()
        {
            //supprime un superviseur
            int s_id = choisir_superviseur();
            Personne la_personne = get_personne_id_superviseur(s_id);
            using (var db = new tp2bd2Entities())
            {
                var un_superviseur = new Etudiant { superviseurs_id = s_id };
                db.Etudiants.Attach(un_superviseur);
                db.Etudiants.Remove(un_superviseur);
                db.Personnes.Attach(la_personne);
                db.Personnes.Remove(la_personne);
                db.SaveChanges();

            }
        }

        public static Personne get_personne_id_superviseur(int s_id)
        {
            //choisie le superciseur selon l'identifiant
            Personne retour = new Personne();
            using (var db = new tp2bd2Entities())
            {
                var querySuperviseur = from i in db.Superviseurs
                                       join j in db.Personnes on i.personne_id equals j.personne_id
                                       orderby i.superviseurs_id
                                       select new { pid = j.personne_id, p_prenom = j.prenom , p_nom = j.nom, sid = i.superviseurs_id };

                
                foreach (var element in querySuperviseur)
                {
                    if (s_id == element.sid)
                    {
                        retour = new Personne { personne_id = element.pid, prenom = element.p_prenom, nom = element.p_nom };
                    }
                }
            }
                    return retour;
        }

        public static Personne get_personne_id_etudiant(int e_id)
        {
            //choisie l'étudiant par son identifiant
            Personne retour = new Personne();
            using (var db = new tp2bd2Entities())
            {
                var queryEtudiant = from i in db.Etudiants
                                    join j in db.Personnes on i.personne_id equals j.personne_id
                                       orderby i.da
                                       select new {eda = i.da, pid = j.personne_id, p_prenom = j.prenom, p_nom = j.nom, };


                foreach (var element in queryEtudiant)
                {
                    if (e_id == element.eda)
                    {
                        retour = new Personne { personne_id = element.pid, prenom = element.p_prenom, nom = element.p_nom };
                    }
                }
            }
            return retour;
        }

        public static void maj_personne_prenom(Personne la_personne)
        {
            //met à jour le prenom de la personne
            using (var db = new tp2bd2Entities())
            {
                db.Personnes.Attach(la_personne);
                db.Entry(la_personne).Property(x => x.prenom).IsModified = true;
                db.SaveChanges();
            }
        }

        public static void maj_personne_nom(Personne la_personne)
        {
            //met à jour le nom de la personne
            using (var db = new tp2bd2Entities())
            {
                db.Personnes.Attach(la_personne);
                db.Entry(la_personne).Property(x => x.nom).IsModified = true;
                db.SaveChanges();
            }
        }


    }
}
